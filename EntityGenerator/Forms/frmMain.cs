using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntityGenerator.Forms
{
    public partial class frmMain : Form
    {
        Generators.DBGenerator _generator;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        #region 控件事件
        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_generator != null)
                _generator.DBName = cboDatabase.SelectedItem.ToString();
            LoadDataTable();
        }

        private void cboDataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDataTable.SelectedItem!=null)
                txtEntityName.Text = cboDataTable.SelectedItem.ToString();
        }

        private void chkMul_CheckedChanged(object sender, EventArgs e)
        {
            lsvTable.Enabled = chkMul.Checked;
            chkCheckAll.Enabled = chkMul.Checked;
        }

        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheckAll.Checked)
            {
                for (int i = 0; i < lsvTable.Items.Count; i++)
                {
                    lsvTable.Items[i].Checked = true;
                }
            }
            else
                for (int i = 0; i < lsvTable.Items.Count; i++)
                {
                    lsvTable.Items[i].Checked = false;
                }
        }

        private void chkSyncFileName_CheckedChanged(object sender, EventArgs e)
        {
            lblFileName.Visible = !chkSyncFileName.Checked;
            txtFileName.Visible = !chkSyncFileName.Checked;
        }

        private void chkSavePath_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSavePath.Checked)
            {
                txtFilePath.Text = "";
                return;
            }
            var save = new FolderBrowserDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = save.SelectedPath + "\\";
            }
            else
                chkSavePath.Checked = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValueValidate())
                return;
            if (chkMul.Checked)
                CreateEntityMul();
            else
            {
                string fileName = "";
                if (chkSyncFileName.Checked)
                    fileName = txtEntityName.Text;
                else
                    fileName = txtFileName.Text;
                txtCode.Text = _generator.CreateEntity(cboDataTable.SelectedItem.ToString(), txtNameSpace.Text, txtEntityName.Text, txtFilePath.Text + fileName + ".cs");
                CodeBrush();
            }
        }
        #endregion

        #region 加载数据库信息
        private void LoadDataBase()
        {
            if (rbMSSQL.Checked)
            {
                _generator = new Generators.MssqlGenerator(txtConnection.Text);
            }
            else if (rbMySQL.Checked)
            {
                _generator = new Generators.MySqlGenerator(txtConnection.Text);
            }
            else if (rbOracle.Checked)
            {
                //_generator = new Generators.MssqlGenerator(conName);
            }
            if (_generator.DBType == Entity.DBType.UnKnown)
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "数据库连接失败";
                return;
            }
            var db = _generator.GetDatabaseNames();
            if (db == null || db.Count == 0)
                return;
            cboDatabase.Items.AddRange(db.ToArray());
            lblInfo.ForeColor = Color.Green;
            lblInfo.Text = "数据库连接成功";
        }

        private void LoadDataTable()
        {
            if (_generator == null)
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "数据库连接失败";
                return;
            }
            var tables = _generator.GetTableNames();
            if (tables == null || tables.Count == 0)
                return;
            cboDataTable.Items.AddRange(tables.ToArray());
            InitListItems(tables);
        }

        private void InitListItems(List<Entity.TableInfo> tables)
        {
            lsvTable.Items.AddRange(tables.Select(x => new ListViewItem(x.TableName)).ToArray());
        }
        #endregion

        #region 方法
        private void CreateEntityMul()
        {
            if (!chkSavePath.Checked||string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("请先选择文件保存的路径");
                return;
            }
            if (MessageBox.Show("多选生成时，只能保存文件，并且以表名作为文件名分别存储，确认生成吗？",
                "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            foreach (ListViewItem item in lsvTable.CheckedItems)
            {
                txtCode.AppendText(txtFilePath.Text + item.SubItems[0].Text + ".cs\r\n");
                _generator.CreateEntity(item.SubItems[0].Text, txtNameSpace.Text, item.SubItems[0].Text, txtFilePath.Text + item.SubItems[0].Text + ".cs");
            }
        }

        private bool ValueValidate()
        {
            if (_generator == null || _generator.DBType == Entity.DBType.UnKnown)
            {
                lblInfo.ForeColor = Color.Red;
                txtConnection.Focus();
                return false;
            }
            if (cboDatabase.Items.Count == 0 || cboDatabase.SelectedItem == null)
            {
                lblDatabase.ForeColor = Color.Red;
                cboDatabase.Focus();
                return false;
            }
            else
                lblDatatable.ForeColor = Color.Black;
            if (!chkMul.Checked &&( cboDataTable.Items.Count == 0 || cboDataTable.SelectedItem == null))
            {
                lblDatatable.ForeColor = Color.Red;
                cboDataTable.Focus();
                return false;
            }
            else
                lblDatatable.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(txtNameSpace.Text))
            {
                lblNamespace.ForeColor = Color.Red;
                txtNameSpace.Focus();
                return false;
            }
            else
                lblNamespace.ForeColor = Color.Black;
            if (!chkMul.Checked && string.IsNullOrEmpty(txtEntityName.Text))
            {
                lblClass.ForeColor = Color.Red;
                txtEntityName.Focus();
                return false;
            }
            else
                lblClass.ForeColor = Color.Black;
            if (chkSavePath.Checked && !chkSyncFileName.Checked && string.IsNullOrEmpty(txtFileName.Text))
            {
                lblFileName.ForeColor = Color.Red;
                txtFileName.Focus();
                return false;
            }
            else
                lblFileName.ForeColor = Color.Black;

            return true;
        }

        /// <summary>
        /// 代码着色
        /// </summary>
        private void CodeBrush()
        {
            try
            {
                var parser = new Controls.Parser(Entity.Language.CSharp);
                foreach (var item in parser.KeyColor.Keys)
                {
                    var code = parser.KeyColor[item] as Entity.KeyCodeInfo;
                    if (!code.UseRegex)
                        SetColor(parser, code);
                    else
                    {
                        var regex = new System.Text.RegularExpressions.Regex(code.Key);
                        var values = regex.Matches(txtCode.Text);
                        foreach (System.Text.RegularExpressions.Match match in values)
                        {
                            SetColor(parser, new Entity.KeyCodeInfo {
                                Key = match.Value,
                                ColorStr = code.ColorStr,
                                UseRegex = false
                            });
                        }
                    }
                }
            }
            catch { }
        }


        private void SetColor(Controls.Parser parser, Entity.KeyCodeInfo code)
        {
            int position = -1;
            int length = txtCode.Text.Length;
            position = txtCode.Find(code.Key);
            while (position >= 0)
            {
                txtCode.SelectionStart = position;
                txtCode.SelectionLength = code.Key.Length;
                if (parser.ColorFromRGB)
                {
                    var rgb = code.ColorStr.Split(',');
                    txtCode.SelectionColor = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                }
                else
                    txtCode.SelectionColor = Color.FromName(code.ColorStr);

                position = txtCode.Find(code.Key, position + code.Key.Length, length, RichTextBoxFinds.WholeWord);
            }
        }
        #endregion
    }
}

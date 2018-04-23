namespace EntityGenerator.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOracle = new System.Windows.Forms.RadioButton();
            this.rbMySQL = new System.Windows.Forms.RadioButton();
            this.rbMSSQL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.lblDatatable = new System.Windows.Forms.Label();
            this.cboDataTable = new System.Windows.Forms.ComboBox();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkSavePath = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.plCode = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lsvTable = new System.Windows.Forms.ListView();
            this.tableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkCheckAll = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.chkSyncFileName = new System.Windows.Forms.CheckBox();
            this.plCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOracle
            // 
            this.rbOracle.AutoSize = true;
            this.rbOracle.Enabled = false;
            this.rbOracle.Location = new System.Drawing.Point(216, 5);
            this.rbOracle.Name = "rbOracle";
            this.rbOracle.Size = new System.Drawing.Size(59, 16);
            this.rbOracle.TabIndex = 2;
            this.rbOracle.Text = "Oracle";
            this.rbOracle.UseVisualStyleBackColor = true;
            // 
            // rbMySQL
            // 
            this.rbMySQL.AutoSize = true;
            this.rbMySQL.Location = new System.Drawing.Point(158, 5);
            this.rbMySQL.Name = "rbMySQL";
            this.rbMySQL.Size = new System.Drawing.Size(53, 16);
            this.rbMySQL.TabIndex = 1;
            this.rbMySQL.Text = "MySQL";
            this.rbMySQL.UseVisualStyleBackColor = true;
            // 
            // rbMSSQL
            // 
            this.rbMSSQL.AutoSize = true;
            this.rbMSSQL.Checked = true;
            this.rbMSSQL.Location = new System.Drawing.Point(94, 5);
            this.rbMSSQL.Name = "rbMSSQL";
            this.rbMSSQL.Size = new System.Drawing.Size(59, 16);
            this.rbMSSQL.TabIndex = 0;
            this.rbMSSQL.TabStop = true;
            this.rbMSSQL.Text = "MS-SQL";
            this.rbMSSQL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "数据库类型";
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(94, 28);
            this.txtConnection.Multiline = true;
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConnection.Size = new System.Drawing.Size(261, 100);
            this.txtConnection.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "数据库链接串";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(20, 168);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(65, 12);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "选择数据库";
            // 
            // cboDatabase
            // 
            this.cboDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(94, 165);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(261, 20);
            this.cboDatabase.TabIndex = 7;
            this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // lblDatatable
            // 
            this.lblDatatable.AutoSize = true;
            this.lblDatatable.Location = new System.Drawing.Point(20, 194);
            this.lblDatatable.Name = "lblDatatable";
            this.lblDatatable.Size = new System.Drawing.Size(65, 12);
            this.lblDatatable.TabIndex = 8;
            this.lblDatatable.Text = "选择数据表";
            // 
            // cboDataTable
            // 
            this.cboDataTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDataTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDataTable.FormattingEnabled = true;
            this.cboDataTable.Location = new System.Drawing.Point(94, 191);
            this.cboDataTable.Name = "cboDataTable";
            this.cboDataTable.Size = new System.Drawing.Size(261, 20);
            this.cboDataTable.TabIndex = 9;
            this.cboDataTable.SelectedIndexChanged += new System.EventHandler(this.cboDataTable_SelectedIndexChanged);
            // 
            // txtEntityName
            // 
            this.txtEntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntityName.BackColor = System.Drawing.Color.White;
            this.txtEntityName.Location = new System.Drawing.Point(94, 375);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(171, 21);
            this.txtEntityName.TabIndex = 16;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(32, 380);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(53, 12);
            this.lblClass.TabIndex = 15;
            this.lblClass.Text = "实体类名";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNameSpace.BackColor = System.Drawing.Color.White;
            this.txtNameSpace.Location = new System.Drawing.Point(94, 348);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(261, 21);
            this.txtNameSpace.TabIndex = 14;
            // 
            // lblNamespace
            // 
            this.lblNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(32, 353);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(53, 12);
            this.lblNamespace.TabIndex = 13;
            this.lblNamespace.Text = "命名空间";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilePath.Location = new System.Drawing.Point(94, 428);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilePath.Size = new System.Drawing.Size(261, 55);
            this.txtFilePath.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "文件存放路径";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(280, 488);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chkSavePath
            // 
            this.chkSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSavePath.BackColor = System.Drawing.Color.Transparent;
            this.chkSavePath.Location = new System.Drawing.Point(94, 403);
            this.chkSavePath.Name = "chkSavePath";
            this.chkSavePath.Size = new System.Drawing.Size(104, 19);
            this.chkSavePath.TabIndex = 18;
            this.chkSavePath.Text = "保存到文件";
            this.chkSavePath.UseVisualStyleBackColor = false;
            this.chkSavePath.CheckedChanged += new System.EventHandler(this.chkSavePath_CheckedChanged);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(3, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(447, 512);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            // 
            // plCode
            // 
            this.plCode.BackColor = System.Drawing.Color.Transparent;
            this.plCode.Controls.Add(this.txtCode);
            this.plCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCode.Location = new System.Drawing.Point(367, 49);
            this.plCode.Name = "plCode";
            this.plCode.Padding = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.plCode.Size = new System.Drawing.Size(463, 518);
            this.plCode.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSyncFileName);
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.chkCheckAll);
            this.panel1.Controls.Add(this.chkMul);
            this.panel1.Controls.Add(this.lsvTable);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtConnection);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkSavePath);
            this.panel1.Controls.Add(this.rbMSSQL);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.rbMySQL);
            this.panel1.Controls.Add(this.txtEntityName);
            this.panel1.Controls.Add(this.rbOracle);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.txtNameSpace);
            this.panel1.Controls.Add(this.lblNamespace);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboDatabase);
            this.panel1.Controls.Add(this.lblDatatable);
            this.panel1.Controls.Add(this.lblDatabase);
            this.panel1.Controls.Add(this.cboDataTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 518);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 49);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(-7, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(848, 2);
            this.label9.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(280, 134);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "连接数据库";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(92, 139);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(77, 12);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "            ";
            // 
            // lsvTable
            // 
            this.lsvTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvTable.CheckBoxes = true;
            this.lsvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableName});
            this.lsvTable.Enabled = false;
            this.lsvTable.FullRowSelect = true;
            this.lsvTable.Location = new System.Drawing.Point(94, 238);
            this.lsvTable.Name = "lsvTable";
            this.lsvTable.Size = new System.Drawing.Size(261, 104);
            this.lsvTable.TabIndex = 12;
            this.lsvTable.UseCompatibleStateImageBehavior = false;
            this.lsvTable.View = System.Windows.Forms.View.List;
            // 
            // tableName
            // 
            this.tableName.Text = "表名";
            this.tableName.Width = 233;
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.BackColor = System.Drawing.Color.Transparent;
            this.chkMul.Location = new System.Drawing.Point(305, 220);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(48, 16);
            this.chkMul.TabIndex = 10;
            this.chkMul.Text = "多选";
            this.chkMul.UseVisualStyleBackColor = false;
            this.chkMul.CheckedChanged += new System.EventHandler(this.chkMul_CheckedChanged);
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.BackColor = System.Drawing.Color.Transparent;
            this.chkCheckAll.Enabled = false;
            this.chkCheckAll.Location = new System.Drawing.Point(94, 220);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(48, 16);
            this.chkCheckAll.TabIndex = 11;
            this.chkCheckAll.Text = "全选";
            this.chkCheckAll.UseVisualStyleBackColor = false;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.chkCheckAll_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFileName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileName.Location = new System.Drawing.Point(94, 489);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(181, 21);
            this.txtFileName.TabIndex = 21;
            this.txtFileName.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(44, 493);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(41, 12);
            this.lblFileName.TabIndex = 20;
            this.lblFileName.Text = "文件名";
            this.lblFileName.Visible = false;
            // 
            // chkSyncFileName
            // 
            this.chkSyncFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSyncFileName.AutoSize = true;
            this.chkSyncFileName.BackColor = System.Drawing.Color.Transparent;
            this.chkSyncFileName.Checked = true;
            this.chkSyncFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyncFileName.Location = new System.Drawing.Point(271, 377);
            this.chkSyncFileName.Name = "chkSyncFileName";
            this.chkSyncFileName.Size = new System.Drawing.Size(84, 16);
            this.chkSyncFileName.TabIndex = 17;
            this.chkSyncFileName.Text = "设为文件名";
            this.chkSyncFileName.UseVisualStyleBackColor = false;
            this.chkSyncFileName.CheckedChanged += new System.EventHandler(this.chkSyncFileName_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 589);
            this.Controls.Add(this.plCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(846, 569);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.plCode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOracle;
        private System.Windows.Forms.RadioButton rbMySQL;
        private System.Windows.Forms.RadioButton rbMSSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label lblDatatable;
        private System.Windows.Forms.ComboBox cboDataTable;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkSavePath;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Panel plCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListView lsvTable;
        private System.Windows.Forms.ColumnHeader tableName;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.CheckBox chkSyncFileName;
    }
}
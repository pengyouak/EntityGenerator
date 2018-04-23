using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace EntityGenerator.Controls
{
    public class Parser
    {
#pragma warning disable S2933 // Fields that are only assigned in the constructor should be "readonly"
        private bool caseSensitive = false; //记录当前语言大小写敏感否
        private bool colorFromRGB = false; //记录当前语言大小写敏感否
        private Hashtable keyColor = null;
#pragma warning restore S2933 // Fields that are only assigned in the constructor should be "readonly"

#pragma warning disable S2292 // Trivial properties should be auto-implemented
        public Hashtable KeyColor
        {
            get { return keyColor; }
            set { keyColor = value; }
        }

        public bool ColorFromRGB {
            get { return colorFromRGB; }
            set { colorFromRGB = value; }
        }
#pragma warning restore S2292 // Trivial properties should be auto-implemented


        internal Parser(Entity.Language language) //构造函数接受一个枚举变量
        {
            string filename = "";
            switch (language) //取得xml文件名
            {
                case Entity.Language.CSharp:
                    filename = "csharp.xml";
                    break;
                case Entity.Language.Java:
                    filename = "jsharp.xml";
                    break;
                default:
                    break;
            }

            StreamReader reader = new StreamReader(filename,
                System.Text.Encoding.UTF8
            ); //下面的代码解析xml流

            var xd = new XmlDocument();
            xd.Load(reader);

            keyColor = new Hashtable();
            XmlElement root = xd.DocumentElement;

            XmlNodeList xnl = root.SelectNodes("/definition/word");
            for (int i = 0; i < xnl.Count; i++)
            {
                if (!keyColor.ContainsKey(xnl[i].ChildNodes[0].Value))
                    keyColor.Add(xnl[i].ChildNodes[0].Value, new Entity.KeyCodeInfo {
                        ColorStr = xnl[i].Attributes["color"].Value,
                        Key = xnl[i].ChildNodes[0].Value,
                        UseRegex = bool.Parse(xnl[i].Attributes["regex"].Value)
                    });
            }

            //检测是否判断大小写
            this.caseSensitive = bool.Parse(root.Attributes["caseSensitive"].Value);
            //检查颜色的值是否来源于RGB，否则按颜色名称
            this.colorFromRGB = bool.Parse(root.Attributes["colorFromRGB"].Value);
        }

        public Color IsKeyWord(string word) //判断字符串是否为关键字
        {
            foreach (object item in keyColor.Keys)
            {
                var code = keyColor[item] as Entity.KeyCodeInfo;
                if (code.UseRegex)
                {
                    var regex = new System.Text.RegularExpressions.Regex(code.Key);
                    var value = regex.Match(word);
                    if(!string.IsNullOrEmpty(value.Value))
                        return SetColor(code);
                }
                else if (string.Compare(word, item.ToString(), !caseSensitive) == 0)
                {

                    return SetColor(code);
                }
            }

            return Color.Black;
        }

        private Color SetColor(Entity.KeyCodeInfo code)
        {
            string ColorTemp = (code.ColorStr != string.Empty ? code.ColorStr : "Black");
            Color c;
            try
            {
                var rgb = ColorTemp.Split(',');
                if (colorFromRGB)
                    c = Color.FromArgb(int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));
                else
                    c = Color.FromName(ColorTemp);
            }
            catch (Exception e)
            {
                c = Color.Black;
            }
            return c;
        }
    }
}

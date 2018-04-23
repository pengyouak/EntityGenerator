# EntityGenerator
* 实体类生成工具
* 附带RichTextBox代码着色方案
* 可自定义颜色方案，方案跟随配置文件

#### 批量根据着色配置，刷新RichTextBox中的着色方案，着色方案可以使用正则表达式。
```CSharp
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
```

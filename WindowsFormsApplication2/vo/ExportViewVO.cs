using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExportViewVO
{
    public ExportViewVO(){ }
    public String DateNO { get; set; } = string.Empty;
    public String Code { get; set; } = string.Empty;
    public String Name { get; set; } = string.Empty;
    public String Grp { get; set; } = string.Empty;
    public String Date { get; set; } = string.Empty;
    public int Num { get; set; } = 0;
    public int OnePrice { get; set; } = 0;
    public String id { get; set; } = string.Empty;
    public String Note { get; set; } = string.Empty;
    public int payWay { get; set; } = 0;
}

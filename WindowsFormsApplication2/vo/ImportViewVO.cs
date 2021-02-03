using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ImportViewVO
{
    public ImportViewVO(){ }
    public String DateNO { get; set; } = string.Empty;
    public String Code { get; set; } = string.Empty;
    public String Name { get; set; } = string.Empty;
    public String Grp { get; set; } = string.Empty;
    public String Date { get; set; } = string.Empty;
    public String Unit { get; set; } = string.Empty;
    public int UnitNum { get; set; } = 0;
    public int ImportNum { get; set; } = 0;
    public int OnePrice { get; set; } = 0;
    public String id { get; set; } = string.Empty;
    public String company { get; set; } = string.Empty;
    public String Note { get; set; } = string.Empty;
}

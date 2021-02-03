using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProducViewVO
{
    public ProducViewVO()
    {
    }
    public String Code { get; set; } = string.Empty;
    public String Grp { get; set; } = string.Empty;
    public String Name { get; set; } = string.Empty;
    public String Num { get; set; } = string.Empty;
    public int Price { get; set; } = 0;
    public String Date { get; set; } = string.Empty;    
    public String Note { get; set; } = string.Empty;
}

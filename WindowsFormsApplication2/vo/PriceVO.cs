using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PriceVO
{
    public PriceVO()
    {
    }
    public String Code { get; set; } = string.Empty;
    public String Date { get; set; } = string.Empty;
    public int Price { get; set; } = 0;
    public String Note { get; set; } = string.Empty;
}

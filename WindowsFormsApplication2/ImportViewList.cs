using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ImportViewList : Form
    {
        public ImportViewList()
        {
            InitializeComponent();
        }

        private void listAdd()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("품번",50);
            listView1.Columns.Add("그룹", 100);
            listView1.Columns.Add("품명",100);
            listView1.Columns.Add("구매일", 80);
            listView1.Columns.Add("포장단위", 80);
            listView1.Columns.Add("단위수량", 80);
            listView1.Columns.Add("입고수량", 80);
            listView1.Columns.Add("개당가격", 100);
            listView1.Columns.Add("구매자ID",80);
            listView1.Columns.Add("비고", 200);
            listView1.BeginUpdate();

            //ProductVO[] vo = StockFunction.StockList();
            List<ImportViewVO> list = StockDetFunction.ImportViewList("");
            
            if (list != null) {
                foreach (ImportViewVO vo in list)
                {
                    ListViewItem newitem = new ListViewItem(new String[]{ vo.Code,vo.Grp,vo.Name,vo.Date,vo.Unit ,vo.UnitNum.ToString(),vo.ImportNum.ToString(), vo.OnePrice.ToString(), vo.id,vo.Note});
                    listView1.Items.Add(newitem);  
                }
            }
            listView1.EndUpdate();

            //label1.Text += vo[0].Name;

        }

        private void StockCheck_Load(object sender, EventArgs e)
        {
            listAdd();
        }
    }
}

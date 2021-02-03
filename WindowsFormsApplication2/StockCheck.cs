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
    public partial class StockCheck : Form
    {
        public StockCheck()
        {
            InitializeComponent();
        }

        private void listAdd()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("품번",100);
            listView1.Columns.Add("품명",150);
            listView1.Columns.Add("개수",100);
            listView1.Columns.Add("그룹", 100);  
            listView1.BeginUpdate();

            //ProductVO[] vo = StockFunction.StockList();
            List<ProductVO> list = StockFunction.StockList();
            
            if (list != null) {
                foreach (ProductVO vo_data in list)
                {
                    ListViewItem newitem = new ListViewItem(new String[]{ vo_data.Code, vo_data.Name, vo_data.Num, vo_data.Grp});
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

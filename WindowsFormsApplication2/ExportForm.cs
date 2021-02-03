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
    public partial class ExportForm : Form
    {
        private int totalNum; // 전체제품개수
        public ExportForm()
        {
            InitializeComponent();
        }
        private void ImportForm_Load(object sender, EventArgs e)
        {
            text_reset();
            listAdd(StockFunction.StockViewList());
            idTextBox.Text = Session.CurrentUserId.ToString();
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            string textData = ((TextBox)sender).Text;

            switch (((TextBox)sender).Name.ToString())
            {
                case "nSearchTextBox":
                    if (textData == "제품명")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        nSearchTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "cSerachTextBox":
                    if (textData == "제품코드")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        cSerachTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "numTextBox":
                    if (textData == "판매수량")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        numTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "onePTextBox":
                    if (textData == "개당가격")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        onePTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "noteTextBox":
                    if (textData == "비고")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        noteTextBox.ForeColor = Color.Black;
                    }
                    break;
                default:
                    break;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            string textData = ((TextBox)sender).Text;

            switch (((TextBox)sender).Name.ToString())
            {
                case "nSearchTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "제품명";
                        nSearchTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "cSerachTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "제품코드";
                        cSerachTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "numTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "판매수량";
                        numTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "onePTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "개당가격";
                        onePTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "noteTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "비고";
                        noteTextBox.ForeColor = Color.Gray;
                    }
                    break;
                default:
                    break;
            }
        }
        private void text_reset()
        {
            tPriceLabel.Text = "";
            listAdd(StockFunction.StockViewList());
            pNameTextBox.Text = "";
            codeTextBox.Text = "";
            nSearchTextBox.Text = "제품명";
            cSerachTextBox.Text = "제품코드";
            numTextBox.Text = "판매수량";
            onePTextBox.Text = "개당가격";
            noteTextBox.Text = "비고";
            cardradioButton.Checked = false;
            cashradioButton.Checked = false;
            nSearchTextBox.ForeColor = numTextBox.ForeColor = onePTextBox.ForeColor = noteTextBox.ForeColor = cSerachTextBox.ForeColor = Color.Gray;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            text_reset();
        }

        private void listAdd(List<ProducViewVO> list)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("품번", 50);
            listView1.Columns.Add("그룹", 100);
            listView1.Columns.Add("품명", 150);
            listView1.Columns.Add("개수", 50);
            listView1.Columns.Add("가격", 100);
            listView1.Columns.Add("기준날짜", 100);
            listView1.BeginUpdate();

            if (list != null)
            {
                foreach (ProducViewVO vo_data in list)
                {
                    ListViewItem newitem = new ListViewItem(new String[] { vo_data.Code, vo_data.Grp, vo_data.Name, vo_data.Num, vo_data.Price.ToString(), vo_data.Date/*, vo_data.Note */});
                    listView1.Items.Add(newitem);
                }
            }
            listView1.EndUpdate();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                // 품번 품명 개수 그룹
                codeTextBox.Text = items[0].SubItems[0].Text;
                pNameTextBox.Text = items[0].SubItems[2].Text;
                totalNum = Convert.ToInt32(items[0].SubItems[3].Text);         
            }
        }
        private void nSearchButton_Click(object sender, EventArgs e)
        {
            listAdd(StockDetFunction.SearchStockListForName(nSearchTextBox.Text.ToString().Trim()));            
        }
        private void cSerachButton_Click(object sender, EventArgs e)
        {
            listAdd(StockDetFunction.SearchStockListForCode(cSerachTextBox.Text.ToString().Trim()));
        }
        private void TextBoxToNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void TextBoxToNum_KeyUp(object sender, KeyEventArgs e)
        {
            string textData = ((TextBox)sender).Text;

            textData = string.Format("{0:###,###,###,###,###,###,###}", Convert.ToInt32(textData));
            TotalPrice(numTextBox.Text.Trim().Replace(",", ""), onePTextBox.Text.Trim().Replace(",", ""));
            
        }
        private void TotalPrice(String importNum, String onePrice)
        {
            Int64 total, price;
            if (Int64.TryParse(importNum, out total) && Int64.TryParse(onePrice, out price))
            {
                price = total * price;

                tPriceLabel.Text = " 합계 : " + string.Format("{0:###,###,###,###,###,###,###}", total) + "개, "
                                    + string.Format("{0:###,###,###,###,###,###,###}", price) + "원";
            }         
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd").Trim();
            String pName = pNameTextBox.Text.ToString();
            String code = codeTextBox.Text.ToString();
            int num;
            int onePrice;
            String note = noteTextBox.Text.ToString().Trim();
            if (pName == string.Empty || code == string.Empty)
            {
                MessageBox.Show("제품을 선택해주십시오");
                return;
            }
            
            if (Int32.TryParse(numTextBox.Text.ToString().Trim().Replace(",", ""), out num))
            {
                numTextBox.Focus();
                MessageBox.Show("판매수량을 입력해주십시오");
                return;
            }
            if (Int32.TryParse(onePTextBox.Text.ToString().Trim().Replace(",", ""), out onePrice))
            {
                onePTextBox.Focus();
                MessageBox.Show("개당가격을 입력해주십시오");
                return;
            }
            if (cardradioButton.Checked && cashradioButton.Checked)
            {
                MessageBox.Show("결제수단을 선택해주십시오");
                return;
            }
            if (note == "비고")
            {
                note = "";
            }
            if (totalNum < Convert.ToInt32(num))
            {
                numTextBox.Focus();
                MessageBox.Show("판매수량이 전체개수보다 많을 수 없습니다");
                return;
            }
            String message = "제품명 : " + pName +  ", 판매일 : " + date
                + "\n판매수량 : " + num + ", 개당가격 : " + onePrice + ", 결제방식 : " + (cashradioButton.Checked ? "현금" : "카드")
                + "\n전체금액 : " + Convert.ToInt32(num) * Convert.ToInt32(onePrice)
                + "\n저장하시겠습니까";
            if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StockDetFunction.InsertExportDetail(code, num, onePrice, note);
                StockDetFunction.InsertExport(date, Convert.ToInt32(num), Convert.ToInt32(num) * Convert.ToInt32(onePrice), Session.CurrentUserId, (cashradioButton.Checked ? 0 : 1));
                StockFunction.UpdateStock(code, (totalNum - num));
                text_reset();
                listAdd(StockFunction.StockViewList());
                MessageBox.Show("저장 되었습니다");
            }
            else return; 
        }
    }
}

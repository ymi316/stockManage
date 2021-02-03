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
    public partial class ImportForm : Form
    {
        private int totalNum; // 전체제품개수
        public ImportForm()
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
                case "companyTextBox":
                    if (textData == "구매처명")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        companyTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "unitTextBox":
                    if (textData == "포장단위명")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        unitTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "unitNTextBox":
                    if (textData == "단위수량")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        unitNTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "importNTextBox":
                    if (textData == "입고수량")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        importNTextBox.ForeColor = Color.Black;
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
                case "companyTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "구매처명";
                        companyTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "unitTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "포장단위명";
                        unitTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "unitNTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "단위수량";
                        unitNTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "importNTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "입고수량";
                        importNTextBox.ForeColor = Color.Gray;
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
            companyTextBox.Text = "구매처명";
            unitTextBox.Text = "포장단위명";
            unitNTextBox.Text = "단위수량";
            importNTextBox.Text = "입고수량";
            onePTextBox.Text = "개당가격";
            noteTextBox.Text = "비고";
            nSearchTextBox.ForeColor  = Color.Gray;
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
            //listView1.Columns.Add("비고", 200);
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
                //cSerachTextBox.ForeColor = nSearchTextBox.ForeColor = Color.Black;                
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
            TotalPrice(unitNTextBox.Text.Replace(",",""), importNTextBox.Text.Replace(",", ""), onePTextBox.Text.Replace(",", ""));
        }
        private void TotalPrice(String unitNum, String importNum, String onePrice)
        {
            Int64 unit=0, import=0, price=0;
            if (Int64.TryParse(unitNum, out unit) && Int64.TryParse(importNum, out import) && Int64.TryParse(onePrice, out price))
            {
                import = unit * import;
                price = import * price;

                tPriceLabel.Text = " 합계 : " + string.Format("{0:###,###,###,###,###,###,###}", import) + "개, "
                                    + string.Format("{0:###,###,###,###,###,###,###}", price) + "원";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd").Trim();
            String pName = pNameTextBox.Text.ToString();
            String code = codeTextBox.Text.ToString();
            String unit = unitTextBox.Text.ToString().Replace(" ", "");
            int unitNum;
            int importNum;
            int onePrice;
            String company = companyTextBox.Text.ToString().Replace(" ","");
            String note = noteTextBox.Text.ToString().Trim();

            if (pName == string.Empty || code == string.Empty)
            {
                MessageBox.Show("제품을 선택해주십시오");
                return;
            }
            if (unit == string.Empty || unit == "포장단위명")
            {
                unitTextBox.Focus();
                MessageBox.Show("포장단위명을 입력해주십시오");
                return;
            }
            if (Int32.TryParse(unitNTextBox.Text.ToString().Trim().Replace(",", ""), out unitNum)==false)
            {
                unitNTextBox.Focus();
                MessageBox.Show("단위수량을 입력해주십시오");
                return;
            }
            if (Int32.TryParse(importNTextBox.Text.ToString().Trim().Replace(",", ""), out importNum))
            {
                importNTextBox.Focus();
                MessageBox.Show("입고수량을 입력해주십시오");
                return;
            }
            if (Int32.TryParse(onePTextBox.Text.ToString().Trim().Replace(",", ""), out onePrice))
            {
                onePTextBox.Focus();
                MessageBox.Show("개당가격을 입력해주십시오");
                return;
            }
            if (company == string.Empty || company == "구매처명")
            {
                companyTextBox.Focus();
                MessageBox.Show("구매처명을 입력해주십시오");
                return;
            }
            if (note == "비고")
            {
                note = "";
            }
            String message = "제품명 : "+ pName + ", 구매처 : " + company + Environment.NewLine + "구매일 : " + date + Environment.NewLine 
                           + "포장단위 : " + unit + ", 단위수량 : " + unitNum + ", 입고수량 : " + importNum + ", 개당가격 : " + onePrice + Environment.NewLine
                           + "전체수량 : " + Convert.ToInt32(unitNum) * Convert.ToInt32(importNum) 
                           + ", 전체금액 : " + Convert.ToInt32(unitNum) * Convert.ToInt32(importNum) * Convert.ToInt32(onePrice) + Environment.NewLine
                           + "저장하시겠습니까?";
            if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StockDetFunction.InsertimportDetail(code, unit, unitNum, importNum, onePrice, Session.CurrentUserId, note);
                StockDetFunction.Insertimport(date, (unitNum * importNum),(unitNum * importNum * onePrice), company);
                StockFunction.UpdateStock(code, (totalNum + unitNum * importNum));
                text_reset();
                listAdd(StockFunction.StockViewList());

                MessageBox.Show("저장되었습니다.");
            }
            else
            {
                return;
            }
        }

        /*
        private void nSearchTextBox_ForeColorChanged(object sender, EventArgs e)
        {
            companyTextBox.ForeColor = nSearchTextBox.ForeColor;
            unitTextBox.ForeColor = nSearchTextBox.ForeColor;
            unitNTextBox.ForeColor = nSearchTextBox.ForeColor;
            importNTextBox.ForeColor = nSearchTextBox.ForeColor;
            onePTextBox.ForeColor = nSearchTextBox.ForeColor;
            noteTextBox.ForeColor = nSearchTextBox.ForeColor;
            cSerachTextBox.ForeColor = nSearchTextBox.ForeColor;
        }
        */
    }
}

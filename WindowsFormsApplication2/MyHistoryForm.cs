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
    public partial class MyHistoryForm : Form
    {
        private int totalNum; // 전체제품개수
        private String history = String.Empty;
        private String dateno = String.Empty;
        public MyHistoryForm()
        {
            InitializeComponent();
        }
        private void ImportForm_Load(object sender, EventArgs e)
        {
            text_reset();
            //idTextBox.Text = Session.CurrentUserId.ToString();
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            string textData = ((TextBox)sender).Text;

            switch (((TextBox)sender).Name.ToString())
            {
                case "nSearchTextBox":
                    if (textData == "상품명")
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
                    if (textData == (history == "판매" ? "수량" : "입고수량"))
                    {
                        ((TextBox)sender).Text = string.Empty;
                        importNTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "onePTextBox":
                    if (textData == (history=="판매"? "가격": "개당가격"))
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
                        ((TextBox)sender).Text = "상품명";
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
                        ((TextBox)sender).Text = (history == "판매" ? "수량" : "입고수량");
                        importNTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "onePTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = (history == "판매" ? "가격" : "개당가격");
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
            pNameTextBox.Text = "";
            codeTextBox.Text = "";
            nSearchTextBox.Text = "상품명";
            cSerachTextBox.Text = "제품코드";
            companyTextBox.Text = "구매처명";
            unitTextBox.Text = "포장단위명";
            unitNTextBox.Text = "단위수량";
            if (history == "판매") { 
                importNTextBox.Text = "수량";
                onePTextBox.Text = "가격";
            }
            else
            {
                importNTextBox.Text = "입고수량";
                onePTextBox.Text = "개당가격";
            }
            noteTextBox.Text = "비고";
            cashRadioButton.Checked = false;
            cardRadioButton.Checked = false;
            nSearchTextBox.ForeColor = companyTextBox.ForeColor = unitTextBox.ForeColor = unitNTextBox.ForeColor 
                = importNTextBox.ForeColor = onePTextBox.ForeColor = noteTextBox.ForeColor = cSerachTextBox.ForeColor = Color.Gray;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            text_reset();
        }

        private void listAddImport(String where)
        {
            history = "구매";
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("순번", 80);
            listView1.Columns.Add("품번", 50);
            listView1.Columns.Add("그룹", 100);
            listView1.Columns.Add("품명", 100);
            listView1.Columns.Add("구매일", 80);
            listView1.Columns.Add("포장단위", 80);
            listView1.Columns.Add("단위수량", 80);
            listView1.Columns.Add("입고수량", 80);
            listView1.Columns.Add("개당가격", 100);
            listView1.Columns.Add("구매자ID", 80);
            listView1.Columns.Add("구매처", 80);
            listView1.Columns.Add("비고", 200);
            listView1.BeginUpdate();

            //ProductVO[] vo = StockFunction.StockList();
            List<ImportViewVO> list = StockDetFunction.ImportViewList("ID='" + Session.CurrentUserId + "' " +where);

            if (list != null)
            {
                foreach (ImportViewVO vo in list)
                {
                    ListViewItem newitem = new ListViewItem(new String[] { vo.DateNO,vo.Code, vo.Grp, vo.Name, vo.Date, vo.Unit, vo.UnitNum.ToString(), vo.ImportNum.ToString(), vo.OnePrice.ToString(), vo.id,vo.company, vo.Note });
                    listView1.Items.Add(newitem);
                }
            }
            listView1.EndUpdate();

            //label1.Text += vo[0].Name;

        }
        private void listAddExport(String where)
        {
            history = "판매";
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("순번", 80);
            listView1.Columns.Add("품번", 50);
            listView1.Columns.Add("그룹", 100);
            listView1.Columns.Add("품명", 100);
            listView1.Columns.Add("구매일", 80);
            listView1.Columns.Add("판매수량", 80);
            listView1.Columns.Add("개당가격", 100);
            listView1.Columns.Add("판매자ID", 80);
            listView1.Columns.Add("구매방법", 80);
            listView1.Columns.Add("비고", 200);
            listView1.BeginUpdate();

            //ProductVO[] vo = StockFunction.StockList();
            List<ExportViewVO> list = StockDetFunction.ExportViewList("ID='" + Session.CurrentUserId + "' " + where);

            if (list != null)
            {
                foreach (ExportViewVO vo in list)
                {
                    ListViewItem newitem = new ListViewItem(new String[] { vo.DateNO, vo.Code, vo.Grp, vo.Name, vo.Date, vo.Num.ToString(), vo.OnePrice.ToString(), vo.id, (vo.payWay == 0 ? "현금" : "카드"), vo.Note });
                    listView1.Items.Add(newitem);
                }
            }
            listView1.EndUpdate();

            //label1.Text += vo[0].Name;

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                dateno = items[0].SubItems[0].Text;
                // 품번 그룹 품명 구매일
                dateTimePicker1.Value = Convert.ToDateTime(items[0].SubItems[4].Text);
                codeTextBox.Text = items[0].SubItems[1].Text;
                pNameTextBox.Text = items[0].SubItems[3].Text;
                //codeTextBox.ForeColor = pNameTextBox.ForeColor = Color.Black;
                if (history == "구매")
                { //포장단위 단위수량 입고수량 개당가격 구매자id 비고
                    unitTextBox.Text = items[0].SubItems[5].Text;
                    unitNTextBox.Text = items[0].SubItems[6].Text;
                    importNTextBox.Text = items[0].SubItems[7].Text;
                    onePTextBox.Text = items[0].SubItems[8].Text;
                    companyTextBox.Text = items[0].SubItems[10].Text;
                    noteTextBox.Text = items[0].SubItems[11].Text;
                    unitTextBox.ForeColor = unitNTextBox.ForeColor = importNTextBox.ForeColor = onePTextBox.ForeColor = companyTextBox.ForeColor
                        = noteTextBox.ForeColor = Color.Black;
                }
                if (history == "판매")
                {
                    importNTextBox.Text = items[0].SubItems[5].Text;
                    onePTextBox.Text = items[0].SubItems[6].Text;
                    if (items[0].SubItems[8].Text == "현금") cashRadioButton.Checked = true;
                    if (items[0].SubItems[8].Text == "카드") cardRadioButton.Checked = true;
                    noteTextBox.Text = items[0].SubItems[9].Text;
                    importNTextBox.ForeColor = onePTextBox.ForeColor = noteTextBox.ForeColor = Color.Black;
                }
            }
        }
        private void nSearchButton_Click(object sender, EventArgs e)
        {
            if (history == String.Empty)
            {
                MessageBox.Show("구매내역 또는 판매내역을 선택주십시오");
                return;
            }
            if (nSearchTextBox.Text.ToString().Trim() == ""|| nSearchTextBox.Text.ToString().Trim() == "제품명")
            {
                MessageBox.Show("검색하실 제품명을 입력해주십시오");
                return;
            }
            if (history == "구매")
            {
                listAddImport("AND [NAME] Like '%" + nSearchTextBox.Text.ToString().Trim()+"%'");
            }
            if (history == "판매")
            {
                listAddExport("AND [NAME] Like '%" + nSearchTextBox.Text.ToString().Trim() + "%'");
            }
        }
        private void cSerachButton_Click(object sender, EventArgs e)
        {
            if (history == String.Empty)
            {
                MessageBox.Show("구매내역 또는 판매내역을 선택주십시오");
                return;
            }
            if (cSerachTextBox.Text.ToString().Trim() == ""|| cSerachTextBox.Text.ToString().Trim() == "제품코드")
            {
                MessageBox.Show("검색하실 코드를 입력해주십시오");
                return;
            }
            if (history == "구매")
            {
                listAddImport("AND [CODE] Like '%" + cSerachTextBox.Text.ToString().Trim() + "%'");
            }
            if (history == "판매")
            {
                listAddExport("AND [CODE] Like '%" + cSerachTextBox.Text.ToString().Trim() + "%'");
            }
            //listAdd(StockDetFunction.SearchStockListForCode(cSerachTextBox.Text.ToString().Trim()));
        }
        private void TextBoxToNum_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void totalPrice(int unitNum, int importNum, int onePrice)
        {
            Int64 total = Convert.ToInt32(unitNum) * Convert.ToInt32(importNum);
            Int64 price = Convert.ToInt32(unitNum) * Convert.ToInt32(importNum) * Convert.ToInt32(onePrice);
            
            tPriceLabel.Text = " 합계 : "+ string.Format("{0:###,###,###,###,###,###,###}", total) + "개, "
                                +string.Format("{0:###,###,###,###,###,###,###}", price) +"원";            
        }        

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd").Trim();
            String pName = pNameTextBox.Text.ToString();
            String code = codeTextBox.Text.ToString();
            String unit = unitTextBox.Text.ToString().Replace(" ", "");
            int unitNum=0;
            int importNum=0;
            int onePrice=0;
            String company = companyTextBox.Text.ToString().Replace(" ","");
            String note = noteTextBox.Text.ToString().Trim();
            String message=String.Empty;
            int pway = 0;
            if (history == String.Empty)
            {
                MessageBox.Show("구매내역 또는 판매내역을 선택주십시오");
                return;
            }
            if (pName == string.Empty || code == string.Empty)
            {
                MessageBox.Show("제품을 선택해주십시오");
                return;
            }

            if (history == "구매")
            {
                if (unit == string.Empty || unit == "포장단위명")
                {
                    unitTextBox.Focus();
                    MessageBox.Show("포장단위명을 입력해주십시오");
                    return;
                }
                if (Int32.TryParse(unitNTextBox.Text.ToString().Trim().Replace(",", ""), out unitNum))
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
                message = "제품명 : " + pName + ", 구매처 : " + company + "\n 구매일 : " + date
                    + "\n포장단위 : " + unit + ", 단위수량 : " + unitNum + ", 입고수량 : " + importNum + ", 개당가격 : " + onePrice
                    + "\n전체수량 : " + unitNum * importNum
                    + ", 전체금액 : " + unitNum * importNum * onePrice
                    + "\n수정하시겠습니까?";
            }
            if (history == "판매")
            {                
                if (Int32.TryParse(importNTextBox.Text.ToString().Trim().Replace(",", ""), out importNum))
                {
                    importNTextBox.Focus();
                    MessageBox.Show("수량을 입력해주십시오");
                    return;
                }
                if (Int32.TryParse(onePTextBox.Text.ToString().Trim().Replace(",", ""), out onePrice))
                {
                    onePTextBox.Focus();
                    MessageBox.Show("가격을 입력해주십시오");
                    return;
                }
                if (cardRadioButton.Checked==false&& cashRadioButton.Checked == false)
                {
                    companyTextBox.Focus();
                    MessageBox.Show("결제수단을 선택해주십시오");
                    return;
                }
                pway = (cashRadioButton.Checked ? 0 : 1);
                message = "제품명 : " + pName + ", 판매일 : " + date
                    + "\n수량 : " + importNum + ", 가격 : " + onePrice
                    + "\n전체수량 : " + importNum
                    + ", 전체금액 : " + importNum * onePrice
                    + "\n수정하시겠습니까?";
            }
            if (note == "비고")
            {
                note = "";
            }
            if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                                       
                text_reset();
                if (history == "구매")
                {
                    StockDetFunction.updateImportData(dateno, unit, unitNum, importNum, onePrice
                        , note, date, unitNum* importNum
                        , (unitNum * importNum*onePrice), company);
                    listAddImport("");
                }
                if (history == "판매")
                {
                    StockDetFunction.UpdateExportData(dateno, date, importNum, onePrice, pway, note);
                    listAddExport("");
                }

                MessageBox.Show("수정되었습니다.");
            }
            else
            {
                return;
            }
        }

        private void importbutton_Click(object sender, EventArgs e)
        {
            history = "구매";
            listAddImport("");
            text_reset();
            unitTextBox.Show();
            unitNTextBox.Show();
            companyTextBox.Show();
            label2.Hide();
            cashRadioButton.Hide();
            cardRadioButton.Hide();
            importNTextBox.Location = new Point(172, 60);
            onePTextBox.Location = new Point(237, 60);
            tPriceLabel.Location = new Point(371, 65);
            importNTextBox.Text = "입고수량";
            onePTextBox.Text = "개당가격";
            label1.Text = "구매일자";
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            history = " 판매";
            listAddExport("");
            text_reset();
            unitTextBox.Hide();
            unitNTextBox.Hide();
            companyTextBox.Hide();
            label2.Show();
            cashRadioButton.Show();
            cardRadioButton.Show();
            importNTextBox.Location = new Point(11,60);
            onePTextBox.Location = new Point(90,60);
            tPriceLabel.Location = new Point(237,60);
            importNTextBox.Text = "판매수량";
            onePTextBox.Text = "가격";
            label1.Text = "판매일자";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (history == String.Empty)
            {
                MessageBox.Show("구매내역 또는 판매내역을 선택주십시오");
                return;
            }
            if (pNameTextBox.Text.ToString() == String.Empty || codeTextBox.Text.ToString() == String.Empty)
            {
                MessageBox.Show("제품을 선택해주십시오");
                return;
            }
            if (MessageBox.Show("정말 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                text_reset();
                if (history == "구매")
                {
                    StockDetFunction.DeleteImportData(dateno);
                    listAddImport("");
                }
                if (history == "판매")
                {
                    StockDetFunction.DeleteExportData(dateno);
                    listAddExport("");
                }

                MessageBox.Show("삭제되었습니다.");
            }

        }
    }
}

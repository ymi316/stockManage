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
    public partial class StockUpdate : Form
    {
        public StockUpdate()
        {
            InitializeComponent();
        }
        private String selectTextBoxTT;
        private String updateCode;
        private void StockUpdate_Load(object sender, EventArgs e)
        {
            text_reset();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            listAdd();
            
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            string textData = ((TextBox)sender).Text;

            switch (((TextBox)sender).Name.ToString())
            {
                case "NameTextBox":
                    if (textData == "상품명")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        NameTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "numTextBox":
                    if (textData == "수량")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        numTextBox.ForeColor = Color.Black;
                    }
                    break;
                case "priceTextBox":
                    if (textData == "가격")
                    {
                        ((TextBox)sender).Text = string.Empty;
                        priceTextBox.ForeColor = Color.Black;
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
                case "NameTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "상품명";
                        NameTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "numTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "수량";
                        numTextBox.ForeColor = Color.Gray;
                    }
                    break;
                case "priceTextBox":
                    if (textData == string.Empty)
                    {
                        ((TextBox)sender).Text = "가격";
                        priceTextBox.ForeColor = Color.Gray;
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
        private void TextBoxToNum_KeyPress(object sender, KeyPressEventArgs e)
        {            
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void listAdd()
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
            listView1.Columns.Add("비고", 200);
            listView1.BeginUpdate();

            List<ProducViewVO> list = StockFunction.StockViewList();

            if (list != null)
            {
                foreach (ProducViewVO vo_data in list)
                {
                    ListViewItem newitem = new ListViewItem(new String[] { vo_data.Code, vo_data.Grp, vo_data.Name, vo_data.Num, vo_data.Price.ToString(), vo_data.Date,vo_data.Note});
                    listView1.Items.Add(newitem);
                }
            }
            listView1.EndUpdate();            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            String grp = grpComboBox.Text.ToString().Trim();
            String name = NameTextBox.Text.ToString().Replace(" ", "");
            int num;
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd").Trim();
            int price;
            String note = noteTextBox.Text.ToString().Trim();
            
            if (grp == "그룹선택")
            {
                grpComboBox.Focus();
                MessageBox.Show("그룹을 선택해주십시오");
                return;
            }
            if (name == "" || name == "상품명")
            {
                NameTextBox.Focus();
                MessageBox.Show("상품명을 입력해주십시오");
                return;
            }
            if (int.TryParse(numTextBox.Text.ToString().Trim().Replace(",", ""), out num))
            {
                numTextBox.Focus();
                MessageBox.Show("수량을 입력해주십시오");
                return;
            }
            if (Int32.TryParse(priceTextBox.Text.ToString().Trim().Replace(",", ""), out price))
            {
                priceTextBox.Focus();
                MessageBox.Show("가격을 입력해주십시오");
                return;
            }
            if (note == "비고")
            {
                note = "";
            }

            if (editButton.Text == "추가하기") { 
                StockFunction.insertStockPrice(grp, name, num, date, price, note);

                MessageBox.Show( "상품이 추가되었습니다.");
            }
            if (editButton.Text == "수정하기")
            {
                StockFunction.updateStockPrice(updateCode, num, date, price, note);

                MessageBox.Show("상품이 수정되었습니다.");
            }
            text_reset();
            listAdd();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                NameTextBox.ForeColor = numTextBox.ForeColor = priceTextBox.ForeColor = noteTextBox.ForeColor = Color.Black;
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;

                updateCode = items[0].SubItems[0].Text;
                selectTextBoxTT = items[0].SubItems[1].Text; // TT
                grpComboBox.SelectedItem= items[0].SubItems[1].Text;
                NameTextBox.Text = items[0].SubItems[2].Text;
                numTextBox.Text = items[0].SubItems[3].Text;
                priceTextBox.Text = items[0].SubItems[4].Text;
                dateTimePicker1.Value = Convert.ToDateTime(items[0].SubItems[5].Text);
                noteTextBox.Text = items[0].SubItems[6].Text;
                if (noteTextBox.Text == "")
                {
                    noteTextBox.Text = "비고";
                    noteTextBox.ForeColor = Color.Gray;
                }
                //grpComboBox.DropDown = false; // disabled하고 싶은데 안되네ㅠㅜㅠ
                NameTextBox.ReadOnly=true;
                editButton.Text = "수정하기";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            text_reset();
        }    
        private void text_reset()
        {
            editButton.Text = "추가하기";
            grpComboBox.SelectedIndex = 0;
            NameTextBox.Text = "상품명";
            numTextBox.Text = "수량";
            priceTextBox.Text = "가격";
            noteTextBox.Text = "비고";
            NameTextBox.ReadOnly = false;
            NameTextBox.ForeColor = numTextBox.ForeColor = priceTextBox.ForeColor = noteTextBox.ForeColor = Color.Gray;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void grpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(editButton.Text == "수정하기")
            {
                grpComboBox.SelectedItem = selectTextBoxTT;
            }
        }
    }
}

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
    public partial class Main : Form
    {
        private LoginForm loginForm = new LoginForm();
        private static StockCheck stockCheck = new StockCheck();
        private static StockUpdate stockUpdate = new StockUpdate();
        private static ImportForm importForm = new ImportForm();
        private static ExportForm exportForm = new ExportForm();
        private static ImportViewList importViewList = new ImportViewList();
        private static ExportViewList exportViewList = new ExportViewList();
        private static MyHistoryForm myHistoryForm = new MyHistoryForm();

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Session.CurrentUserId = "관리자"; // 테스트용~

            currentID.Hide();
            logout.Hide();
            if (string.IsNullOrEmpty(Session.CurrentUserId) == false)
            {
                currentID.Show();
                currentID.Text = Session.CurrentUserId + "님";
                logout.Show();
            }
        }  

        private void myPageMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void MyPageMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("마이페이지");
        }
        private void MyHistoryMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                myHistoryForm.TopLevel = false;
                panel1.Controls.Add(myHistoryForm);
                myHistoryForm.ControlBox = false;
                myHistoryForm.Text = "";
                myHistoryForm.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (logout.Text == "로그아웃")
            {
                currentID.Hide();
                MessageBox.Show("로그아웃 되었습니다.");
                hide();
                logout.Text = "로그인";
                Session.CurrentUserId = null;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                //loginForm.Show();
                loginForm.ShowDialog();

                if (string.IsNullOrEmpty(Session.CurrentUserId) == false)
                {
                    currentID.Show();
                    currentID.Text = Session.CurrentUserId + "님";
                    logout.Text = "로그아웃";
                }
            }
        }

        private void stockCheckMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                stockCheck.TopLevel = false;
                panel1.Controls.Add(stockCheck);
                stockCheck.ControlBox = false;
                stockCheck.Text = "";
                stockCheck.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }
        private void stockUpdateMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            { 
                stockUpdate.TopLevel = false;
                panel1.Controls.Add(stockUpdate);
                stockUpdate.ControlBox = false;
                stockUpdate.Text = "";
                stockUpdate.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }
        private void importpMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                importForm.TopLevel = false;
                panel1.Controls.Add(importForm);
                importForm.ControlBox = false;
                importForm.Text = "";
                importForm.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                exportForm.TopLevel = false;
                panel1.Controls.Add(exportForm);
                exportForm.ControlBox = false;
                exportForm.Text = "";
                exportForm.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }

        private void importListMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                importViewList.TopLevel = false;
                panel1.Controls.Add(importViewList);
                importViewList.ControlBox = false;
                importViewList.Text = "";
                importViewList.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }
        private void exportListMenuItem_Click(object sender, EventArgs e)
        {
            hide();
            if (!string.IsNullOrEmpty(Session.CurrentUserId))
            {
                exportViewList.TopLevel = false;
                panel1.Controls.Add(exportViewList);
                exportViewList.ControlBox = false;
                exportViewList.Text = "";
                exportViewList.Show();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }
        private void hide()
        {
            stockCheck.Hide();
            stockUpdate.Hide();
            importForm.Hide();
            exportForm.Hide();
            importViewList.Hide();
            exportViewList.Hide();
            myHistoryForm.Hide();
        }

    }
}

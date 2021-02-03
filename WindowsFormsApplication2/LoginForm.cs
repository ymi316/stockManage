using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginFunction;

namespace WindowsFormsApplication2
{
    public partial class LoginForm : Form
    {
        //public delegate void LoginSendData(String sendLoginString);
        //public event LoginSendData formSendLoginData;

        private LoginFunction loginfunction = new LoginFunction();
        public LoginForm()
        {
            InitializeComponent();
        } 

        private void login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)){
                label2.Text="아이디를 입력해주세요";
                textBox1.Focus();
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                label2.Text = "비밀번호를 입력해주세요";
                textBox2.Focus();
                return;
            }
            // 특수문자 지워야 하나??
            if (loginCheck(textBox1.Text.ToString().Trim(), textBox2.Text.ToString().Trim())){
                label2.Text = "로그인 성공";
                //this.formSendLoginData(label2.Text.ToString());
                Session.BeginTimer();
                Session.CurrentUserId = textBox1.Text.ToString().Trim();
                this.Close();
            }
            else{
                label2.Text = "아이디나 비밀번호가 올바르지 않습니다";
            }
            
        }
        private Boolean loginCheck(String id, String pw)
        {              
            return loginfunction.PWCheck(id, pw);
        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {
            SignForm signform = new SignForm();
            signform.Show();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            Session.CurrentUserId = string.Empty;
        }
    }
}

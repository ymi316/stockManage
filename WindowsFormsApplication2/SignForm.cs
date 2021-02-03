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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class SignForm : Form
    {
        private LoginFunction loginfunction = new LoginFunction();
        private Boolean idOverap = true;
        private int gender=0;
        public SignForm()
        {
            InitializeComponent();
        }
        private void idtextbox_TextChanged(object sender, EventArgs e)
        {
            String id = idtextbox.Text.ToString().Trim();
            if (id.Length < 5)
            {
                idOverlapCheck.Text = "ID를 5글자 이상 입력해주세요";
                idOverlapCheck.ForeColor = Color.Red;
                return;
            }
            if (loginfunction.IdCheck(id))
            {
                idOverlapCheck.Text = "이미 사용중인 ID 입니다";
                idOverlapCheck.ForeColor= Color.Red;
                idOverap = true;
            }
            else
            {
                idOverlapCheck.Text = "사용 가능한 ID 입니다";
                idOverlapCheck.ForeColor = Color.Green;
                idOverap = false;
            }
        }
        private void pwCon_TextChanged(object sender, EventArgs e)
        {
            String pw = pwtextBox.Text.ToString().Trim();
            String pw2 = pwCon.Text.ToString().Trim();
            if (pw2.Equals(pw))
            {
                label9.Text = "";
            }else
            {
                label9.Text = "비밀번호가 다릅니다";
                label9.ForeColor = Color.Red;
            }
        }
        private void femaieCheck2_CheckedChanged(object sender, EventArgs e)
        {
            gender = 2;
        }
        private void maleCheck2_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String id = idtextbox.Text.ToString().Trim();
            String pw = pwtextBox.Text.ToString().Trim();
            String pw2 = pwCon.Text.ToString().Trim();
            String name = nameTextBox.Text.ToString().Trim();
            String phone = phoneTextBox.Text.ToString().Trim();            
            String email = emailTextBox.Text.ToString().Trim();

            if (id.Length < 1)
            {
                warning_label.Text = "아이디를 입력해주세요";
                idtextbox.Focus();
                return;
            }
            if (pw.Length < 1)
            {
                warning_label.Text = "비밀번호를 입력해주세요";
                pwtextBox.Focus();
                return;
            }
            if (pw2.Length < 1)
            {
                warning_label.Text = "비밀번호 확인을 입력해주세요";
                pwCon.Focus();
                return;
            }
            if (name.Length < 1)
            {
                warning_label.Text = "이름를 입력해주세요";
                nameTextBox.Focus();
                return;
            }
            if (phone.Length < 1)
            {
                warning_label.Text = "전화번호를 입력해주세요";
                phoneTextBox.Focus();
                return;
            }
            if (phone.Length <10 || phone.Length > 11)
            {
                warning_label.Text = "전화번호를 바르게 입력해주세요";
                phoneTextBox.Focus();
                return;
            }

            Regex pwRegex = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
            Match m = pwRegex.Match(phone);
            if (!m.Success)
            {
                warning_label.Text = "전화번호를 부호없이 올바른 형식으로 입력해주세요\nEX) 01012340000";
                phoneTextBox.Focus();
                return;
            }
            if (gender==0)
            {
                warning_label.Text = "성별을 선택해주세요";
                return;
            }
            if (email.Length < 1)
            {
                warning_label.Text = "이메일을 입력해주세요";
                emailTextBox.Focus();
                return;
            }
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match m2 = emailRegex.Match(email);
            if (!m2.Success)
            {
                warning_label.Text = "이메일을 정확히 입력해주십시오";
                emailTextBox.Focus();
                return;
            }
            if (loginfunction.PhoneOverlapCheck(phone))
            {
                warning_label.Text = "이미 가입한 사용자입니다";
                phoneTextBox.Focus();
                return;
            }
            if(loginfunction.MemberCreate(id, pw, name, phone, gender, email))
            {
                MessageBox.Show("회원가입이 완료되었습니다");
                this.Close();
            }
            else
            {
                MessageBox.Show ("데이터 저장에 실패하였습니다.");
                return;
            }
        }
    }
}

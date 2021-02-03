using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private SqlConnection Con;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            //this.Close();
        }
        private void PrintTable()
        {
            Con = new SqlConnection();
            Con.ConnectionString = "Server=DESKTOP-O8EDJ6L\\SQLEXPRESS;database=Exercise;Integrated Security=true";
            //+"User Id=;Password=;";
            Con.Open();
            string Rec;
            SqlCommand Com = new SqlCommand("SELECT * FROM stockManage_product", Con);
            SqlDataReader R;
            R = Com.ExecuteReader();
            listBox1.Items.Add("연결성공");
            listBox1.Items.Add(Con.Database);
            listBox1.Items.Add(Con.State);
            listBox1.Items.Add(Com.CommandText);
            listBox1.Items.Add(Com.CommandTimeout);
            
            while (R.Read())
            {
                Rec = string.Format("CDDE : {0}, NAME : {1}, NUM : {2}, GRP : {3}", R["CODE"].ToString(), R[1].ToString(), R[2].ToString(), R[3].ToString());
                listBox1.Items.Add(Rec);
            }
            R.Close();
            Con.Close();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            PrintTable();
        }

    }
}
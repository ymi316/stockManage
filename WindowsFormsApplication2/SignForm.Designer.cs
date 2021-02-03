namespace WindowsFormsApplication2
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.pwtextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idOverlapCheck = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.warning_label = new System.Windows.Forms.Label();
            this.pwCon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.femaieCheck2 = new System.Windows.Forms.RadioButton();
            this.maleCheck2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "성별";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "이메일";
            // 
            // idtextbox
            // 
            this.idtextbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.idtextbox.Location = new System.Drawing.Point(212, 90);
            this.idtextbox.MaxLength = 20;
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(100, 21);
            this.idtextbox.TabIndex = 8;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // pwtextBox
            // 
            this.pwtextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pwtextBox.Location = new System.Drawing.Point(212, 129);
            this.pwtextBox.MaxLength = 30;
            this.pwtextBox.Name = "pwtextBox";
            this.pwtextBox.PasswordChar = '*';
            this.pwtextBox.Size = new System.Drawing.Size(100, 21);
            this.pwtextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(212, 203);
            this.nameTextBox.MaxLength = 40;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.phoneTextBox.Location = new System.Drawing.Point(212, 239);
            this.phoneTextBox.MaxLength = 11;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneTextBox.TabIndex = 26;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.emailTextBox.Location = new System.Drawing.Point(212, 306);
            this.emailTextBox.MaxLength = 60;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 21);
            this.emailTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(172, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "회원가입";
            // 
            // idOverlapCheck
            // 
            this.idOverlapCheck.AutoSize = true;
            this.idOverlapCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idOverlapCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.idOverlapCheck.Location = new System.Drawing.Point(143, 114);
            this.idOverlapCheck.Name = "idOverlapCheck";
            this.idOverlapCheck.Size = new System.Drawing.Size(0, 12);
            this.idOverlapCheck.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "가입하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(136, 339);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(0, 12);
            this.warning_label.TabIndex = 16;
            // 
            // pwCon
            // 
            this.pwCon.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pwCon.Location = new System.Drawing.Point(212, 164);
            this.pwCon.MaxLength = 30;
            this.pwCon.Name = "pwCon";
            this.pwCon.PasswordChar = '*';
            this.pwCon.Size = new System.Drawing.Size(100, 21);
            this.pwCon.TabIndex = 17;
            this.pwCon.TextChanged += new System.EventHandler(this.pwCon_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "비밀번호 확인";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(210, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 11);
            this.label10.TabIndex = 28;
            this.label10.Text = "ex) 01000000000";
            // 
            // femaieCheck2
            // 
            this.femaieCheck2.AutoSize = true;
            this.femaieCheck2.Location = new System.Drawing.Point(212, 282);
            this.femaieCheck2.Name = "femaieCheck2";
            this.femaieCheck2.Size = new System.Drawing.Size(47, 16);
            this.femaieCheck2.TabIndex = 29;
            this.femaieCheck2.TabStop = true;
            this.femaieCheck2.Text = "여자";
            this.femaieCheck2.UseVisualStyleBackColor = true;
            this.femaieCheck2.CheckedChanged += new System.EventHandler(this.femaieCheck2_CheckedChanged);
            // 
            // maleCheck2
            // 
            this.maleCheck2.AutoSize = true;
            this.maleCheck2.Location = new System.Drawing.Point(265, 282);
            this.maleCheck2.Name = "maleCheck2";
            this.maleCheck2.Size = new System.Drawing.Size(47, 16);
            this.maleCheck2.TabIndex = 30;
            this.maleCheck2.TabStop = true;
            this.maleCheck2.Text = "남자";
            this.maleCheck2.UseVisualStyleBackColor = true;
            this.maleCheck2.CheckedChanged += new System.EventHandler(this.maleCheck2_CheckedChanged);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.maleCheck2);
            this.Controls.Add(this.femaieCheck2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pwCon);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idOverlapCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pwtextBox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignForm";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox pwtextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idOverlapCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.TextBox pwCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton femaieCheck2;
        private System.Windows.Forms.RadioButton maleCheck2;
    }
}
namespace WindowsFormsApplication2
{
    partial class ExportForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nSearchTextBox = new System.Windows.Forms.TextBox();
            this.nSearchButton = new System.Windows.Forms.Button();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.onePTextBox = new System.Windows.Forms.TextBox();
            this.tPriceLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.cSerachTextBox = new System.Windows.Forms.TextBox();
            this.cSerachButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.cardradioButton = new System.Windows.Forms.RadioButton();
            this.cashradioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(11, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1121, 478);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "구매일자";
            // 
            // nSearchTextBox
            // 
            this.nSearchTextBox.Location = new System.Drawing.Point(11, 32);
            this.nSearchTextBox.Name = "nSearchTextBox";
            this.nSearchTextBox.Size = new System.Drawing.Size(148, 21);
            this.nSearchTextBox.TabIndex = 1;
            this.nSearchTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.nSearchTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // nSearchButton
            // 
            this.nSearchButton.Location = new System.Drawing.Point(165, 31);
            this.nSearchButton.Name = "nSearchButton";
            this.nSearchButton.Size = new System.Drawing.Size(124, 22);
            this.nSearchButton.TabIndex = 5;
            this.nSearchButton.Text = "검색";
            this.nSearchButton.UseVisualStyleBackColor = true;
            this.nSearchButton.Click += new System.EventHandler(this.nSearchButton_Click);
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.Location = new System.Drawing.Point(295, 32);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.ReadOnly = true;
            this.pNameTextBox.Size = new System.Drawing.Size(241, 21);
            this.pNameTextBox.TabIndex = 98;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(988, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(144, 21);
            this.idTextBox.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(931, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "회원ID";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(1029, 87);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(103, 24);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "확인";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(11, 90);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(916, 21);
            this.noteTextBox.TabIndex = 8;
            this.noteTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.noteTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(11, 60);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(148, 21);
            this.numTextBox.TabIndex = 5;
            this.numTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.numTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxToNum_KeyUp);
            this.numTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // onePTextBox
            // 
            this.onePTextBox.Location = new System.Drawing.Point(165, 60);
            this.onePTextBox.Name = "onePTextBox";
            this.onePTextBox.Size = new System.Drawing.Size(124, 21);
            this.onePTextBox.TabIndex = 6;
            this.onePTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.onePTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.onePTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxToNum_KeyUp);
            this.onePTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // tPriceLabel
            // 
            this.tPriceLabel.AutoSize = true;
            this.tPriceLabel.ForeColor = System.Drawing.Color.Blue;
            this.tPriceLabel.Location = new System.Drawing.Point(316, 64);
            this.tPriceLabel.Name = "tPriceLabel";
            this.tPriceLabel.Size = new System.Drawing.Size(45, 12);
            this.tPriceLabel.TabIndex = 15;
            this.tPriceLabel.Text = "총 금액";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(940, 87);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 24);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "모두지우기";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cSerachTextBox
            // 
            this.cSerachTextBox.Location = new System.Drawing.Point(542, 33);
            this.cSerachTextBox.Name = "cSerachTextBox";
            this.cSerachTextBox.Size = new System.Drawing.Size(168, 21);
            this.cSerachTextBox.TabIndex = 2;
            this.cSerachTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.cSerachTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // cSerachButton
            // 
            this.cSerachButton.Location = new System.Drawing.Point(716, 32);
            this.cSerachButton.Name = "cSerachButton";
            this.cSerachButton.Size = new System.Drawing.Size(129, 24);
            this.cSerachButton.TabIndex = 18;
            this.cSerachButton.Text = "검색";
            this.cSerachButton.UseVisualStyleBackColor = true;
            this.cSerachButton.Click += new System.EventHandler(this.cSerachButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(851, 33);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(280, 21);
            this.codeTextBox.TabIndex = 99;
            // 
            // cardradioButton
            // 
            this.cardradioButton.AutoSize = true;
            this.cardradioButton.Location = new System.Drawing.Point(1085, 61);
            this.cardradioButton.Name = "cardradioButton";
            this.cardradioButton.Size = new System.Drawing.Size(47, 16);
            this.cardradioButton.TabIndex = 100;
            this.cardradioButton.TabStop = true;
            this.cardradioButton.Text = "카드";
            this.cardradioButton.UseVisualStyleBackColor = true;
            // 
            // cashradioButton
            // 
            this.cashradioButton.AutoSize = true;
            this.cashradioButton.Location = new System.Drawing.Point(1029, 61);
            this.cashradioButton.Name = "cashradioButton";
            this.cashradioButton.Size = new System.Drawing.Size(47, 16);
            this.cashradioButton.TabIndex = 101;
            this.cashradioButton.TabStop = true;
            this.cashradioButton.Text = "현금";
            this.cashradioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(957, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "결제수단";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cashradioButton);
            this.Controls.Add(this.cardradioButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.cSerachButton);
            this.Controls.Add(this.cSerachTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.tPriceLabel);
            this.Controls.Add(this.onePTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.nSearchButton);
            this.Controls.Add(this.nSearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Name = "ExportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nSearchTextBox;
        private System.Windows.Forms.Button nSearchButton;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox onePTextBox;
        private System.Windows.Forms.Label tPriceLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox cSerachTextBox;
        private System.Windows.Forms.Button cSerachButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.RadioButton cardradioButton;
        private System.Windows.Forms.RadioButton cashradioButton;
        private System.Windows.Forms.Label label3;
    }
}
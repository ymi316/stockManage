namespace WindowsFormsApplication2
{
    partial class MyHistoryForm
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
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.nSearchTextBox = new System.Windows.Forms.TextBox();
            this.nSearchButton = new System.Windows.Forms.Button();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.unitNTextBox = new System.Windows.Forms.TextBox();
            this.importNTextBox = new System.Windows.Forms.TextBox();
            this.onePTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.tPriceLabel = new System.Windows.Forms.Label();
            this.cSerachTextBox = new System.Windows.Forms.TextBox();
            this.cSerachButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.importbutton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(11, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1121, 476);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "구매일자";
            // 
            // companyTextBox
            // 
            this.companyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.companyTextBox.Location = new System.Drawing.Point(887, 61);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(245, 21);
            this.companyTextBox.TabIndex = 7;
            this.companyTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.companyTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // nSearchTextBox
            // 
            this.nSearchTextBox.Location = new System.Drawing.Point(436, 34);
            this.nSearchTextBox.Name = "nSearchTextBox";
            this.nSearchTextBox.Size = new System.Drawing.Size(131, 21);
            this.nSearchTextBox.TabIndex = 1;
            this.nSearchTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.nSearchTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // nSearchButton
            // 
            this.nSearchButton.Location = new System.Drawing.Point(573, 33);
            this.nSearchButton.Name = "nSearchButton";
            this.nSearchButton.Size = new System.Drawing.Size(67, 24);
            this.nSearchButton.TabIndex = 5;
            this.nSearchButton.Text = "검색";
            this.nSearchButton.UseVisualStyleBackColor = true;
            this.nSearchButton.Click += new System.EventHandler(this.nSearchButton_Click);
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.Location = new System.Drawing.Point(646, 34);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.ReadOnly = true;
            this.pNameTextBox.Size = new System.Drawing.Size(124, 21);
            this.pNameTextBox.TabIndex = 98;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1026, 88);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 24);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "수정하기";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(11, 90);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(900, 21);
            this.noteTextBox.TabIndex = 8;
            this.noteTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.noteTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // unitNTextBox
            // 
            this.unitNTextBox.Location = new System.Drawing.Point(107, 60);
            this.unitNTextBox.Name = "unitNTextBox";
            this.unitNTextBox.Size = new System.Drawing.Size(59, 21);
            this.unitNTextBox.TabIndex = 4;
            this.unitNTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.unitNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.unitNTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // importNTextBox
            // 
            this.importNTextBox.Location = new System.Drawing.Point(172, 60);
            this.importNTextBox.Name = "importNTextBox";
            this.importNTextBox.Size = new System.Drawing.Size(59, 21);
            this.importNTextBox.TabIndex = 5;
            this.importNTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.importNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.importNTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // onePTextBox
            // 
            this.onePTextBox.Location = new System.Drawing.Point(237, 60);
            this.onePTextBox.Name = "onePTextBox";
            this.onePTextBox.Size = new System.Drawing.Size(124, 21);
            this.onePTextBox.TabIndex = 6;
            this.onePTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.onePTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.onePTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(11, 60);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(88, 21);
            this.unitTextBox.TabIndex = 3;
            this.unitTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.unitTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // tPriceLabel
            // 
            this.tPriceLabel.AutoSize = true;
            this.tPriceLabel.ForeColor = System.Drawing.Color.Blue;
            this.tPriceLabel.Location = new System.Drawing.Point(371, 65);
            this.tPriceLabel.Name = "tPriceLabel";
            this.tPriceLabel.Size = new System.Drawing.Size(45, 12);
            this.tPriceLabel.TabIndex = 15;
            this.tPriceLabel.Text = "총 금액";
            // 
            // cSerachTextBox
            // 
            this.cSerachTextBox.Location = new System.Drawing.Point(776, 34);
            this.cSerachTextBox.Name = "cSerachTextBox";
            this.cSerachTextBox.Size = new System.Drawing.Size(135, 21);
            this.cSerachTextBox.TabIndex = 2;
            this.cSerachTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.cSerachTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // cSerachButton
            // 
            this.cSerachButton.Location = new System.Drawing.Point(917, 32);
            this.cSerachButton.Name = "cSerachButton";
            this.cSerachButton.Size = new System.Drawing.Size(67, 24);
            this.cSerachButton.TabIndex = 18;
            this.cSerachButton.Text = "검색";
            this.cSerachButton.UseVisualStyleBackColor = true;
            this.cSerachButton.Click += new System.EventHandler(this.cSerachButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(990, 33);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(142, 21);
            this.codeTextBox.TabIndex = 99;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(917, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 24);
            this.deleteButton.TabIndex = 100;
            this.deleteButton.Text = "삭제하기";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // importbutton
            // 
            this.importbutton.Location = new System.Drawing.Point(11, 2);
            this.importbutton.Name = "importbutton";
            this.importbutton.Size = new System.Drawing.Size(103, 24);
            this.importbutton.TabIndex = 101;
            this.importbutton.Text = "구매내역";
            this.importbutton.UseVisualStyleBackColor = true;
            this.importbutton.Click += new System.EventHandler(this.importbutton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(120, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(103, 24);
            this.exportButton.TabIndex = 102;
            this.exportButton.Text = "판매내역";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(509, 63);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(47, 16);
            this.cashRadioButton.TabIndex = 103;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "현금";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(573, 63);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(47, 16);
            this.cardRadioButton.TabIndex = 104;
            this.cardRadioButton.TabStop = true;
            this.cardRadioButton.Text = "카드";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 105;
            this.label2.Text = "결제수단";
            // 
            // MyHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importbutton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.cSerachButton);
            this.Controls.Add(this.cSerachTextBox);
            this.Controls.Add(this.tPriceLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.onePTextBox);
            this.Controls.Add(this.importNTextBox);
            this.Controls.Add(this.unitNTextBox);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.nSearchButton);
            this.Controls.Add(this.nSearchTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Name = "MyHistoryForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox nSearchTextBox;
        private System.Windows.Forms.Button nSearchButton;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox unitNTextBox;
        private System.Windows.Forms.TextBox importNTextBox;
        private System.Windows.Forms.TextBox onePTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label tPriceLabel;
        private System.Windows.Forms.TextBox cSerachTextBox;
        private System.Windows.Forms.Button cSerachButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button importbutton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.Label label2;
    }
}
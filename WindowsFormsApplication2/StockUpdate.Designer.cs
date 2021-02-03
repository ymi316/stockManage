namespace WindowsFormsApplication2
{
    partial class StockUpdate
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
            this.editButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.grpComboBox = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1133, 523);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(1020, 35);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 21);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "추가하기";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(162, 7);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(155, 21);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // numTextBox
            // 
            this.numTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numTextBox.Location = new System.Drawing.Point(323, 7);
            this.numTextBox.MaxLength = 10;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(143, 21);
            this.numTextBox.TabIndex = 3;
            this.numTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.numTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(162, 35);
            this.noteTextBox.MaxLength = 200;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(852, 21);
            this.noteTextBox.TabIndex = 5;
            this.noteTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.noteTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(8, 35);
            this.priceTextBox.MaxLength = 100;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(148, 21);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxToNum_KeyPress);
            this.priceTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(543, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(484, 11);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(53, 12);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "기준날짜";
            // 
            // grpComboBox
            // 
            this.grpComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpComboBox.FormattingEnabled = true;
            this.grpComboBox.Items.AddRange(new object[] {
            "그룹선택",
            "전자기기/부품",
            "식료품",
            "섬유/의류",
            "가구/목재",
            "의료기기",
            "기타"});
            this.grpComboBox.Location = new System.Drawing.Point(8, 8);
            this.grpComboBox.Name = "grpComboBox";
            this.grpComboBox.Size = new System.Drawing.Size(148, 20);
            this.grpComboBox.TabIndex = 9;
            this.grpComboBox.SelectedIndexChanged += new System.EventHandler(this.grpComboBox_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(1065, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 10;
            this.reset.Text = "되돌리기";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // StockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 593);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.grpComboBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listView1);
            this.Name = "StockUpdate";
            this.Text = "StockUpdate";
            this.Load += new System.EventHandler(this.StockUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox grpComboBox;
        private System.Windows.Forms.Button reset;
    }
}
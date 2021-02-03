namespace WindowsFormsApplication2
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyHistoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockCheckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockUpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고상세보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currentID = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 632);
            this.panel1.TabIndex = 0;
            // 
            // MMenuItem
            // 
            this.MMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyPageMenuItem,
            this.MyHistoryMenuItem});
            this.MMenuItem.Name = "MMenuItem";
            this.MMenuItem.Size = new System.Drawing.Size(79, 20);
            this.MMenuItem.Text = "마이페이지";
            this.MMenuItem.Click += new System.EventHandler(this.myPageMenuItem_Click);
            // 
            // MyPageMenuItem
            // 
            this.MyPageMenuItem.Name = "MyPageMenuItem";
            this.MyPageMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MyPageMenuItem.Text = "내정보수정";
            this.MyPageMenuItem.Click += new System.EventHandler(this.MyPageMenuItem_Click_1);
            // 
            // MyHistoryMenuItem
            // 
            this.MyHistoryMenuItem.Name = "MyHistoryMenuItem";
            this.MyHistoryMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MyHistoryMenuItem.Text = "내내역보기";
            this.MyHistoryMenuItem.Click += new System.EventHandler(this.MyHistoryMenuItem_Click);
            // 
            // stockMenuItem
            // 
            this.stockMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockCheckMenuItem,
            this.stockUpdateMenuItem,
            this.재고상세보기ToolStripMenuItem});
            this.stockMenuItem.Name = "stockMenuItem";
            this.stockMenuItem.Size = new System.Drawing.Size(59, 20);
            this.stockMenuItem.Text = "  상품  ";
            // 
            // stockCheckMenuItem
            // 
            this.stockCheckMenuItem.Name = "stockCheckMenuItem";
            this.stockCheckMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stockCheckMenuItem.Text = "상품 확인하기 ";
            this.stockCheckMenuItem.Click += new System.EventHandler(this.stockCheckMenuItem_Click);
            // 
            // stockUpdateMenuItem
            // 
            this.stockUpdateMenuItem.Name = "stockUpdateMenuItem";
            this.stockUpdateMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stockUpdateMenuItem.Text = "상품 수정하기";
            this.stockUpdateMenuItem.Click += new System.EventHandler(this.stockUpdateMenuItem_Click);
            // 
            // 재고상세보기ToolStripMenuItem
            // 
            this.재고상세보기ToolStripMenuItem.Name = "재고상세보기ToolStripMenuItem";
            this.재고상세보기ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.재고상세보기ToolStripMenuItem.Text = "재고 상세보기";
            // 
            // 구매ToolStripMenuItem1
            // 
            this.구매ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importpMenuItem,
            this.importListMenuItem});
            this.구매ToolStripMenuItem1.Name = "구매ToolStripMenuItem1";
            this.구매ToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.구매ToolStripMenuItem1.Text = "  구매  ";
            // 
            // importpMenuItem
            // 
            this.importpMenuItem.Name = "importpMenuItem";
            this.importpMenuItem.Size = new System.Drawing.Size(150, 22);
            this.importpMenuItem.Text = "구매 입력하기";
            this.importpMenuItem.Click += new System.EventHandler(this.importpMenuItem_Click);
            // 
            // importListMenuItem
            // 
            this.importListMenuItem.Name = "importListMenuItem";
            this.importListMenuItem.Size = new System.Drawing.Size(150, 22);
            this.importListMenuItem.Text = "구매 내역보기";
            this.importListMenuItem.Click += new System.EventHandler(this.importListMenuItem_Click);
            // 
            // 판매ToolStripMenuItem
            // 
            this.판매ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMenuItem,
            this.exportListMenuItem});
            this.판매ToolStripMenuItem.Name = "판매ToolStripMenuItem";
            this.판매ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.판매ToolStripMenuItem.Text = "  판매  ";
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportMenuItem.Text = "판매 입력하기";
            this.exportMenuItem.Click += new System.EventHandler(this.exportMenuItem_Click);
            // 
            // exportListMenuItem
            // 
            this.exportListMenuItem.Name = "exportListMenuItem";
            this.exportListMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportListMenuItem.Text = "판매 내역보기";
            this.exportListMenuItem.Click += new System.EventHandler(this.exportListMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMenuItem,
            this.stockMenuItem,
            this.구매ToolStripMenuItem1,
            this.판매ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currentID
            // 
            this.currentID.AutoSize = true;
            this.currentID.Location = new System.Drawing.Point(1003, 8);
            this.currentID.Name = "currentID";
            this.currentID.Size = new System.Drawing.Size(55, 12);
            this.currentID.TabIndex = 3;
            this.currentID.Text = "currentID";
            this.currentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(1119, 8);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(53, 12);
            this.logout.TabIndex = 2;
            this.logout.Text = "로그아웃";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 681);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentID);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "EDBCount";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem MMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockCheckMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockUpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고상세보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label currentID;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.ToolStripMenuItem importListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyHistoryMenuItem;
    }
}
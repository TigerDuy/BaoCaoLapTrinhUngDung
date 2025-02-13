namespace quanlyquankem
{
    partial class fTableManager
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
            pnlTable = new Panel();
            flpTable = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            panel3 = new Panel();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDisCount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            v = new NumericUpDown();
            btnAllKem = new Button();
            cbKem = new ComboBox();
            cbCategory = new ComboBox();
            pnlTable.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v).BeginInit();
            SuspendLayout();
            // 
            // pnlTable
            // 
            pnlTable.Controls.Add(flpTable);
            pnlTable.Location = new Point(12, 31);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(411, 442);
            pnlTable.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(3, 0);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(405, 439);
            flpTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(851, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(224, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(439, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 297);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(383, 294);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDisCount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(439, 402);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 71);
            panel3.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(6, 36);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(97, 28);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(6, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(97, 28);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDisCount
            // 
            nmDisCount.Location = new Point(149, 35);
            nmDisCount.Name = "nmDisCount";
            nmDisCount.Size = new Size(97, 27);
            nmDisCount.TabIndex = 4;
            nmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(149, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(97, 28);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(289, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(97, 59);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(v);
            panel4.Controls.Add(btnAllKem);
            panel4.Controls.Add(cbKem);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(439, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 65);
            panel4.TabIndex = 1;
            // 
            // v
            // 
            v.Location = new Point(347, 21);
            v.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            v.Name = "v";
            v.Size = new Size(39, 27);
            v.TabIndex = 3;
            v.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAllKem
            // 
            btnAllKem.Location = new Point(242, 3);
            btnAllKem.Name = "btnAllKem";
            btnAllKem.Size = new Size(97, 59);
            btnAllKem.TabIndex = 2;
            btnAllKem.Text = "Thêm món";
            btnAllKem.UseVisualStyleBackColor = true;
            // 
            // cbKem
            // 
            cbKem.FormattingEnabled = true;
            cbKem.Location = new Point(6, 34);
            cbKem.Name = "cbKem";
            cbKem.Size = new Size(230, 28);
            cbKem.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(6, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(230, 28);
            cbCategory.TabIndex = 0;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 473);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlTable);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            Text = "Phần mềm quản lý quán kem";
            pnlTable.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDisCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)v).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTable;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private ComboBox cbCategory;
        private Button btnAllKem;
        private ComboBox cbKem;
        private NumericUpDown v;
        private FlowLayoutPanel flpTable;
        private Button btnCheckOut;
        private Button btnDiscount;
        private NumericUpDown nmDisCount;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
    }
}
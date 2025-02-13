namespace quanlyquankem
{
    partial class fAcountProfile
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
            panel2 = new Panel();
            txbUserName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txbDisPlayName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExti = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 60);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(200, 16);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(568, 27);
            txbUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(159, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisPlayName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 60);
            panel1.TabIndex = 2;
            // 
            // txbDisPlayName
            // 
            txbDisPlayName.Location = new Point(200, 16);
            txbDisPlayName.Name = "txbDisPlayName";
            txbDisPlayName.Size = new Size(568, 27);
            txbDisPlayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 60);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(200, 16);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(568, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 14);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 60);
            panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(200, 16);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(568, 27);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 14);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 276);
            panel5.Name = "panel5";
            panel5.Size = new Size(778, 60);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(200, 16);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(568, 27);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 14);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại :";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(560, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExti
            // 
            btnExti.Location = new Point(686, 354);
            btnExti.Name = "btnExti";
            btnExti.Size = new Size(94, 29);
            btnExti.TabIndex = 7;
            btnExti.Text = "Thoát";
            btnExti.UseVisualStyleBackColor = true;
            btnExti.Click += btnExti_Click;
            // 
            // fAcountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExti;
            ClientSize = new Size(798, 409);
            Controls.Add(btnExti);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAcountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += fAcountProfile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUserName;
        private Label label2;
        private Panel panel1;
        private TextBox txbDisPlayName;
        private Label label1;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label5;
        private Button btnUpdate;
        private Button btnExti;
    }
}
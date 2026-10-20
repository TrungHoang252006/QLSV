namespace baitest2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbTaiKhoan = new Label();
            lbMatKhau = new Label();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(198, 62);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(125, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(198, 127);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 1;
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.Location = new Point(103, 62);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(66, 20);
            lbTaiKhoan.TabIndex = 2;
            lbTaiKhoan.Text = "Nhập TK";
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(103, 134);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(71, 20);
            lbMatKhau.TabIndex = 3;
            lbMatKhau.Text = "Nhập MK";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(213, 222);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(btnDangNhap);
            Controls.Add(lbMatKhau);
            Controls.Add(lbTaiKhoan);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbTaiKhoan;
        private Label lbMatKhau;
        private Button btnDangNhap;
    }
}

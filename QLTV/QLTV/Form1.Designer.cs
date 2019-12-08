namespace QLTV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.ComboBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.xemmatkhau = new System.Windows.Forms.CheckBox();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.dangnhapnd = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(96, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(143, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tài Khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Chọn quyền:";
            // 
            // quyen
            // 
            this.quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyen.FormattingEnabled = true;
            this.quyen.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.quyen.Location = new System.Drawing.Point(351, 252);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(96, 24);
            this.quyen.TabIndex = 32;
            // 
            // matkhau
            // 
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(287, 208);
            this.matkhau.Multiline = true;
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(160, 25);
            this.matkhau.TabIndex = 31;
            // 
            // xemmatkhau
            // 
            this.xemmatkhau.AutoSize = true;
            this.xemmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.xemmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemmatkhau.Location = new System.Drawing.Point(456, 216);
            this.xemmatkhau.Name = "xemmatkhau";
            this.xemmatkhau.Size = new System.Drawing.Size(145, 24);
            this.xemmatkhau.TabIndex = 30;
            this.xemmatkhau.Text = "&Xem Mật Khẩu";
            this.xemmatkhau.UseVisualStyleBackColor = false;
            this.xemmatkhau.CheckedChanged += new System.EventHandler(this.xemmatkhau_CheckedChanged);
            // 
            // taikhoan
            // 
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.Location = new System.Drawing.Point(287, 161);
            this.taikhoan.Multiline = true;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(160, 29);
            this.taikhoan.TabIndex = 29;
            // 
            // dangnhapnd
            // 
            this.dangnhapnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dangnhapnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhapnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dangnhapnd.Location = new System.Drawing.Point(147, 301);
            this.dangnhapnd.Name = "dangnhapnd";
            this.dangnhapnd.Size = new System.Drawing.Size(143, 34);
            this.dangnhapnd.TabIndex = 36;
            this.dangnhapnd.Text = "Đăng Nhập";
            this.dangnhapnd.UseVisualStyleBackColor = false;
            this.dangnhapnd.Click += new System.EventHandler(this.dangnhapnd_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thoat.Location = new System.Drawing.Point(345, 301);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(102, 34);
            this.thoat.TabIndex = 37;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 436);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhapnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.xemmatkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox quyen;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.CheckBox xemmatkhau;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.Button dangnhapnd;
        private System.Windows.Forms.Button thoat;
    }
}


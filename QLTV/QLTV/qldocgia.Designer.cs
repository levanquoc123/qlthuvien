namespace QLTV
{
    partial class qldocgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qldocgia));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timkiem = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tencantim = new System.Windows.Forms.TextBox();
            this.chaychu = new System.Windows.Forms.Label();
            this.Reload = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(38, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 208);
            this.panel2.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(158, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thông Tin Độc Giả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 145);
            this.dataGridView1.TabIndex = 8;
            // 
            // timkiem
            // 
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timkiem.Location = new System.Drawing.Point(333, 113);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(121, 36);
            this.timkiem.TabIndex = 69;
            this.timkiem.Text = "Tìm Kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sua.Location = new System.Drawing.Point(38, 168);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(116, 36);
            this.sua.TabIndex = 68;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.them.Location = new System.Drawing.Point(171, 168);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(116, 36);
            this.them.TabIndex = 67;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xoa.Location = new System.Drawing.Point(171, 113);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(116, 36);
            this.xoa.TabIndex = 66;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(33, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 30);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nhập Tên Cần Tìm:";
            // 
            // tencantim
            // 
            this.tencantim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tencantim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tencantim.Location = new System.Drawing.Point(333, 63);
            this.tencantim.Name = "tencantim";
            this.tencantim.Size = new System.Drawing.Size(121, 32);
            this.tencantim.TabIndex = 65;
            // 
            // chaychu
            // 
            this.chaychu.AutoSize = true;
            this.chaychu.BackColor = System.Drawing.Color.Transparent;
            this.chaychu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaychu.ForeColor = System.Drawing.Color.Yellow;
            this.chaychu.Location = new System.Drawing.Point(219, 9);
            this.chaychu.Name = "chaychu";
            this.chaychu.Size = new System.Drawing.Size(257, 36);
            this.chaychu.TabIndex = 70;
            this.chaychu.Text = "Quản Lý Độc Giả";
            // 
            // Reload
            // 
            this.Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reload.Location = new System.Drawing.Point(38, 113);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(116, 36);
            this.Reload.TabIndex = 71;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Độc Giả",
            "Tên Độc Giả",
            "Số Thẻ"});
            this.comboBox1.Location = new System.Drawing.Point(496, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 72;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Độc Giả Đang Mượn Sách",
            "Độc Giả Trả Sách Quá Hạn"});
            this.comboBox2.Location = new System.Drawing.Point(496, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 21);
            this.comboBox2.TabIndex = 73;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(333, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 74;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qldocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.chaychu);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tencantim);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "qldocgia";
            this.Text = "qldocgia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tencantim;
        private System.Windows.Forms.Label chaychu;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}
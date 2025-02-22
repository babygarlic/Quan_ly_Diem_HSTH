namespace QuanLyDiemHSTH
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tendangnhap = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_quenmatkhau = new System.Windows.Forms.Label();
            this.cb_xemmatkhau = new System.Windows.Forms.CheckBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào Bạn !";
            // 
            // tb_tendangnhap
            // 
            this.tb_tendangnhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_tendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tendangnhap.Location = new System.Drawing.Point(16, 169);
            this.tb_tendangnhap.Name = "tb_tendangnhap";
            this.tb_tendangnhap.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_tendangnhap.Size = new System.Drawing.Size(226, 28);
            this.tb_tendangnhap.TabIndex = 1;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_matkhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matkhau.Location = new System.Drawing.Point(16, 231);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(226, 28);
            this.tb_matkhau.TabIndex = 1;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(253)))));
            this.bt_dangnhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_dangnhap.Font = new System.Drawing.Font("Corbel", 10F);
            this.bt_dangnhap.Location = new System.Drawing.Point(16, 342);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(217, 38);
            this.bt_dangnhap.TabIndex = 2;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_quenmatkhau);
            this.panel1.Controls.Add(this.cb_xemmatkhau);
            this.panel1.Controls.Add(this.tb_matkhau);
            this.panel1.Controls.Add(this.bt_huy);
            this.panel1.Controls.Add(this.bt_dangnhap);
            this.panel1.Controls.Add(this.tb_tendangnhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 516);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10F);
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10F);
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.Location = new System.Drawing.Point(136, 273);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(97, 17);
            this.lb_quenmatkhau.TabIndex = 4;
            this.lb_quenmatkhau.Text = "Quên mật khẩu";
            // 
            // cb_xemmatkhau
            // 
            this.cb_xemmatkhau.AutoSize = true;
            this.cb_xemmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_xemmatkhau.Location = new System.Drawing.Point(16, 272);
            this.cb_xemmatkhau.Name = "cb_xemmatkhau";
            this.cb_xemmatkhau.Size = new System.Drawing.Size(114, 21);
            this.cb_xemmatkhau.TabIndex = 3;
            this.cb_xemmatkhau.Text = "HIện mật khẩu";
            this.cb_xemmatkhau.UseVisualStyleBackColor = true;
            this.cb_xemmatkhau.CheckedChanged += new System.EventHandler(this.cb_xemmatkhau_CheckedChanged);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(214)))), ((int)(((byte)(253)))));
            this.bt_huy.Font = new System.Drawing.Font("Corbel", 10F);
            this.bt_huy.Location = new System.Drawing.Point(16, 417);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(217, 38);
            this.bt_huy.TabIndex = 2;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 516);
            this.panel2.TabIndex = 4;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 516);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "77";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_xemmatkhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Label lb_quenmatkhau;
        public System.Windows.Forms.TextBox tb_tendangnhap;
        public System.Windows.Forms.TextBox tb_matkhau;
        public System.Windows.Forms.Button bt_dangnhap;
    }
}
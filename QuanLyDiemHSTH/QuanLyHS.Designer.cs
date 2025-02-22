namespace QuanLyDiemHSTH
{
    partial class QuanLyHS
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
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.rdbt_nu = new System.Windows.Forms.RadioButton();
            this.rdbt_nam = new System.Windows.Forms.RadioButton();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mahs = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_danhsachhocsinh = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhsachhocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_them.Location = new System.Drawing.Point(84, 549);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 41);
            this.bt_them.TabIndex = 14;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_timkiem);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(70, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 60);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm ";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(29, 21);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(282, 24);
            this.tb_timkiem.TabIndex = 0;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(320, 16);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(84, 34);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sua.Location = new System.Drawing.Point(186, 549);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(74, 41);
            this.bt_sua.TabIndex = 15;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(291, 549);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(74, 41);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Controls.Add(this.rdbt_nu);
            this.groupBox1.Controls.Add(this.rdbt_nam);
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_mahs);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 420);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(139, 291);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(241, 26);
            this.cb_lop.TabIndex = 7;
            // 
            // rdbt_nu
            // 
            this.rdbt_nu.AutoSize = true;
            this.rdbt_nu.Location = new System.Drawing.Point(270, 188);
            this.rdbt_nu.Name = "rdbt_nu";
            this.rdbt_nu.Size = new System.Drawing.Size(48, 22);
            this.rdbt_nu.TabIndex = 6;
            this.rdbt_nu.TabStop = true;
            this.rdbt_nu.Text = "Nữ";
            this.rdbt_nu.UseVisualStyleBackColor = true;
            // 
            // rdbt_nam
            // 
            this.rdbt_nam.AutoSize = true;
            this.rdbt_nam.Location = new System.Drawing.Point(142, 189);
            this.rdbt_nam.Name = "rdbt_nam";
            this.rdbt_nam.Size = new System.Drawing.Size(61, 22);
            this.rdbt_nam.TabIndex = 6;
            this.rdbt_nam.TabStop = true;
            this.rdbt_nam.Text = "Nam";
            this.rdbt_nam.UseVisualStyleBackColor = true;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(139, 133);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(241, 24);
            this.dt_ngaysinh.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lớp ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Và Tên";
            // 
            // tb_mahs
            // 
            this.tb_mahs.Location = new System.Drawing.Point(139, 79);
            this.tb_mahs.Name = "tb_mahs";
            this.tb_mahs.Size = new System.Drawing.Size(241, 24);
            this.tb_mahs.TabIndex = 0;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(139, 33);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(241, 24);
            this.tb_hoten.TabIndex = 0;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(139, 239);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(241, 24);
            this.tb_diachi.TabIndex = 0;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(390, 549);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(74, 41);
            this.btn_huy.TabIndex = 17;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh Sách Học Sinh";
            // 
            // dt_danhsachhocsinh
            // 
            this.dt_danhsachhocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_danhsachhocsinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_danhsachhocsinh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_danhsachhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_danhsachhocsinh.Location = new System.Drawing.Point(497, 79);
            this.dt_danhsachhocsinh.Name = "dt_danhsachhocsinh";
            this.dt_danhsachhocsinh.RowHeadersWidth = 51;
            this.dt_danhsachhocsinh.RowTemplate.Height = 24;
            this.dt_danhsachhocsinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_danhsachhocsinh.Size = new System.Drawing.Size(707, 567);
            this.dt_danhsachhocsinh.TabIndex = 10;
            this.dt_danhsachhocsinh.Click += new System.EventHandler(this.dt_danhsachhocsinh_Click);
            // 
            // QuanLyHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 646);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_danhsachhocsinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyHS";
            this.Text = "QuanLyHS";
            this.Load += new System.EventHandler(this.QuanLyHS_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhsachhocsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbt_nu;
        private System.Windows.Forms.RadioButton rdbt_nam;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_mahs;
        public System.Windows.Forms.DataGridView dt_danhsachhocsinh;
    }
}
namespace QuanLyDiemHSTH
{
    partial class QuanLyDiem
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
            this.dt_danhsachhocsinh = new System.Windows.Forms.DataGridView();
            this.gb_nhapdiem = new System.Windows.Forms.GroupBox();
            this.rdbt_nu = new System.Windows.Forms.RadioButton();
            this.rdbt_nam = new System.Windows.Forms.RadioButton();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_mahs = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_thi = new System.Windows.Forms.TextBox();
            this.tb45 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tx = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_themdiem = new System.Windows.Forms.Button();
            this.btn_xoadiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_hocky = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhsachhocsinh)).BeginInit();
            this.gb_nhapdiem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_danhsachhocsinh
            // 
            this.dt_danhsachhocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_danhsachhocsinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_danhsachhocsinh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_danhsachhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_danhsachhocsinh.Location = new System.Drawing.Point(880, 155);
            this.dt_danhsachhocsinh.Name = "dt_danhsachhocsinh";
            this.dt_danhsachhocsinh.RowHeadersWidth = 51;
            this.dt_danhsachhocsinh.RowTemplate.Height = 24;
            this.dt_danhsachhocsinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_danhsachhocsinh.Size = new System.Drawing.Size(476, 421);
            this.dt_danhsachhocsinh.TabIndex = 0;
            this.dt_danhsachhocsinh.Click += new System.EventHandler(this.dt_danhsachhocsinh_Click);
            // 
            // gb_nhapdiem
            // 
            this.gb_nhapdiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_nhapdiem.Controls.Add(this.rdbt_nu);
            this.gb_nhapdiem.Controls.Add(this.rdbt_nam);
            this.gb_nhapdiem.Controls.Add(this.dt_ngaysinh);
            this.gb_nhapdiem.Controls.Add(this.label11);
            this.gb_nhapdiem.Controls.Add(this.btn_thoat);
            this.gb_nhapdiem.Controls.Add(this.label12);
            this.gb_nhapdiem.Controls.Add(this.label13);
            this.gb_nhapdiem.Controls.Add(this.label14);
            this.gb_nhapdiem.Controls.Add(this.label15);
            this.gb_nhapdiem.Controls.Add(this.tb_mahs);
            this.gb_nhapdiem.Controls.Add(this.tb_hoten);
            this.gb_nhapdiem.Controls.Add(this.tb_diachi);
            this.gb_nhapdiem.Controls.Add(this.groupBox3);
            this.gb_nhapdiem.Controls.Add(this.btn_sua);
            this.gb_nhapdiem.Controls.Add(this.btn_themdiem);
            this.gb_nhapdiem.Controls.Add(this.btn_xoadiem);
            this.gb_nhapdiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_nhapdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_nhapdiem.Location = new System.Drawing.Point(22, 151);
            this.gb_nhapdiem.Name = "gb_nhapdiem";
            this.gb_nhapdiem.Size = new System.Drawing.Size(835, 418);
            this.gb_nhapdiem.TabIndex = 1;
            this.gb_nhapdiem.TabStop = false;
            this.gb_nhapdiem.Text = "Thông Tin Học Sinh";
            // 
            // rdbt_nu
            // 
            this.rdbt_nu.AutoSize = true;
            this.rdbt_nu.Location = new System.Drawing.Point(275, 190);
            this.rdbt_nu.Name = "rdbt_nu";
            this.rdbt_nu.Size = new System.Drawing.Size(48, 22);
            this.rdbt_nu.TabIndex = 18;
            this.rdbt_nu.TabStop = true;
            this.rdbt_nu.Text = "Nữ";
            this.rdbt_nu.UseVisualStyleBackColor = true;
            // 
            // rdbt_nam
            // 
            this.rdbt_nam.AutoSize = true;
            this.rdbt_nam.Location = new System.Drawing.Point(147, 191);
            this.rdbt_nam.Name = "rdbt_nam";
            this.rdbt_nam.Size = new System.Drawing.Size(61, 22);
            this.rdbt_nam.TabIndex = 19;
            this.rdbt_nam.TabStop = true;
            this.rdbt_nam.Text = "Nam";
            this.rdbt_nam.UseVisualStyleBackColor = true;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Location = new System.Drawing.Point(144, 135);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(241, 24);
            this.dt_ngaysinh.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Địa Chỉ";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_thoat.Location = new System.Drawing.Point(692, 307);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(125, 32);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Giới Tính";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ngày Sinh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Mã Học Sinh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 16;
            this.label15.Text = "Họ Và Tên";
            // 
            // tb_mahs
            // 
            this.tb_mahs.Location = new System.Drawing.Point(144, 81);
            this.tb_mahs.Name = "tb_mahs";
            this.tb_mahs.ReadOnly = true;
            this.tb_mahs.Size = new System.Drawing.Size(241, 24);
            this.tb_mahs.TabIndex = 9;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(144, 35);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.ReadOnly = true;
            this.tb_hoten.Size = new System.Drawing.Size(241, 24);
            this.tb_hoten.TabIndex = 10;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(144, 241);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.ReadOnly = true;
            this.tb_diachi.Size = new System.Drawing.Size(241, 24);
            this.tb_diachi.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_tb);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_thi);
            this.groupBox3.Controls.Add(this.tb45);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_tx);
            this.groupBox3.Location = new System.Drawing.Point(421, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 242);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các Cột Điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Điểm trung bình môn";
            // 
            // tb_tb
            // 
            this.tb_tb.Location = new System.Drawing.Point(254, 160);
            this.tb_tb.Name = "tb_tb";
            this.tb_tb.Size = new System.Drawing.Size(112, 24);
            this.tb_tb.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Điểm Thi Cuối HK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Điểm Kiểm Tra 45 Phút";
            // 
            // tb_thi
            // 
            this.tb_thi.Location = new System.Drawing.Point(254, 118);
            this.tb_thi.Name = "tb_thi";
            this.tb_thi.Size = new System.Drawing.Size(112, 24);
            this.tb_thi.TabIndex = 2;
            // 
            // tb45
            // 
            this.tb45.Location = new System.Drawing.Point(254, 76);
            this.tb45.Name = "tb45";
            this.tb45.Size = new System.Drawing.Size(112, 24);
            this.tb45.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm Kiểm Tra Thường Xuyên";
            // 
            // tb_tx
            // 
            this.tb_tx.Location = new System.Drawing.Point(254, 34);
            this.tb_tx.Name = "tb_tx";
            this.tb_tx.Size = new System.Drawing.Size(112, 24);
            this.tb_tx.TabIndex = 3;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sua.Location = new System.Drawing.Point(291, 307);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(125, 32);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_themdiem
            // 
            this.btn_themdiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_themdiem.Location = new System.Drawing.Point(83, 307);
            this.btn_themdiem.Name = "btn_themdiem";
            this.btn_themdiem.Size = new System.Drawing.Size(125, 32);
            this.btn_themdiem.TabIndex = 1;
            this.btn_themdiem.Text = "Thêm ";
            this.btn_themdiem.UseVisualStyleBackColor = false;
            this.btn_themdiem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_xoadiem
            // 
            this.btn_xoadiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_xoadiem.Location = new System.Drawing.Point(489, 307);
            this.btn_xoadiem.Name = "btn_xoadiem";
            this.btn_xoadiem.Size = new System.Drawing.Size(125, 32);
            this.btn_xoadiem.TabIndex = 1;
            this.btn_xoadiem.Text = "Xóa";
            this.btn_xoadiem.UseVisualStyleBackColor = false;
            this.btn_xoadiem.Click += new System.EventHandler(this.btn_xoadiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.cb_lop);
            this.groupBox2.Controls.Add(this.cb_mon);
            this.groupBox2.Controls.Add(this.cb_namhoc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_hocky);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1164, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Lọc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(62, 27);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(196, 26);
            this.cb_lop.TabIndex = 1;
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(353, 27);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(185, 26);
            this.cb_mon.TabIndex = 1;
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Location = new System.Drawing.Point(933, 23);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(170, 26);
            this.cb_namhoc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(855, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Năm Học";
            // 
            // cb_hocky
            // 
            this.cb_hocky.FormattingEnabled = true;
            this.cb_hocky.Location = new System.Drawing.Point(628, 27);
            this.cb_hocky.Name = "cb_hocky";
            this.cb_hocky.Size = new System.Drawing.Size(187, 26);
            this.cb_hocky.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh Sách Học Sinh";
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dt_danhsachhocsinh);
            this.Controls.Add(this.gb_nhapdiem);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDiem";
            this.Text = "QuanLyDiem";
            this.Load += new System.EventHandler(this.QuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhsachhocsinh)).EndInit();
            this.gb_nhapdiem.ResumeLayout(false);
            this.gb_nhapdiem.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_danhsachhocsinh;
        private System.Windows.Forms.GroupBox gb_nhapdiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.ComboBox cb_hocky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tx;
        private System.Windows.Forms.Button btn_xoadiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_thi;
        private System.Windows.Forms.TextBox tb45;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_themdiem;
        private System.Windows.Forms.ComboBox cb_namhoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tb;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.RadioButton rdbt_nu;
        private System.Windows.Forms.RadioButton rdbt_nam;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_mahs;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Button button3;
    }
}
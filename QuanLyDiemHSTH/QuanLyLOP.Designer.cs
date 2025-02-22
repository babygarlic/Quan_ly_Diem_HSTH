namespace QuanLyDiemHSTH
{
    partial class QuanLyLOP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_gvcn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_lop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datalophoc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sualop = new System.Windows.Forms.Button();
            this.btnxoalop = new System.Windows.Forms.Button();
            this.btn_themlop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_gvcn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_soluong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_lop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học";
            // 
            // cb_gvcn
            // 
            this.cb_gvcn.FormattingEnabled = true;
            this.cb_gvcn.Location = new System.Drawing.Point(166, 221);
            this.cb_gvcn.Name = "cb_gvcn";
            this.cb_gvcn.Size = new System.Drawing.Size(162, 26);
            this.cb_gvcn.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(166, 170);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(162, 24);
            this.tb_soluong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Tối Đa";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(166, 109);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(162, 24);
            this.txt_malop.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã Lớp";
            // 
            // tb_lop
            // 
            this.tb_lop.Location = new System.Drawing.Point(166, 60);
            this.tb_lop.Name = "tb_lop";
            this.tb_lop.Size = new System.Drawing.Size(162, 24);
            this.tb_lop.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Lớp";
            // 
            // datalophoc
            // 
            this.datalophoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datalophoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalophoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datalophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalophoc.Location = new System.Drawing.Point(426, 100);
            this.datalophoc.Name = "datalophoc";
            this.datalophoc.RowHeadersWidth = 51;
            this.datalophoc.RowTemplate.Height = 24;
            this.datalophoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalophoc.Size = new System.Drawing.Size(816, 543);
            this.datalophoc.TabIndex = 1;
            this.datalophoc.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Sách Lớp Học";
            // 
            // btn_sualop
            // 
            this.btn_sualop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sualop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sualop.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sualop.Location = new System.Drawing.Point(302, 517);
            this.btn_sualop.Name = "btn_sualop";
            this.btn_sualop.Size = new System.Drawing.Size(86, 44);
            this.btn_sualop.TabIndex = 6;
            this.btn_sualop.Text = "Sửa";
            this.btn_sualop.UseVisualStyleBackColor = false;
            this.btn_sualop.Click += new System.EventHandler(this.btn_sualop_Click);
            // 
            // btnxoalop
            // 
            this.btnxoalop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnxoalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoalop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnxoalop.Location = new System.Drawing.Point(170, 517);
            this.btnxoalop.Name = "btnxoalop";
            this.btnxoalop.Size = new System.Drawing.Size(86, 44);
            this.btnxoalop.TabIndex = 6;
            this.btnxoalop.Text = "Xóa ";
            this.btnxoalop.UseVisualStyleBackColor = false;
            this.btnxoalop.Click += new System.EventHandler(this.btnxoalop_Click);
            // 
            // btn_themlop
            // 
            this.btn_themlop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_themlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themlop.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_themlop.Location = new System.Drawing.Point(31, 517);
            this.btn_themlop.Name = "btn_themlop";
            this.btn_themlop.Size = new System.Drawing.Size(86, 44);
            this.btn_themlop.TabIndex = 6;
            this.btn_themlop.Text = "Thêm ";
            this.btn_themlop.UseVisualStyleBackColor = false;
            this.btn_themlop.Click += new System.EventHandler(this.btn_themlop_Click);
            // 
            // QuanLyLOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 655);
            this.Controls.Add(this.btn_themlop);
            this.Controls.Add(this.btnxoalop);
            this.Controls.Add(this.btn_sualop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datalophoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyLOP";
            this.Text = "QuanLyLOP";
            this.Load += new System.EventHandler(this.QuanLyLOP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datalophoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lop;
        private System.Windows.Forms.ComboBox cb_gvcn;
        private System.Windows.Forms.Button btn_sualop;
        private System.Windows.Forms.Button btnxoalop;
        private System.Windows.Forms.Button btn_themlop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label8;
    }
}
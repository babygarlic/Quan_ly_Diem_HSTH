namespace QuanLyDiemHSTH
{
    partial class QuanlyMonHoc
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
            this.tb_tenmon = new System.Windows.Forms.TextBox();
            this.tbmamh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datamonhoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btb_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tenmon);
            this.groupBox1.Controls.Add(this.tbmamh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // tb_tenmon
            // 
            this.tb_tenmon.Location = new System.Drawing.Point(191, 126);
            this.tb_tenmon.Name = "tb_tenmon";
            this.tb_tenmon.Size = new System.Drawing.Size(303, 26);
            this.tb_tenmon.TabIndex = 4;
            // 
            // tbmamh
            // 
            this.tbmamh.Location = new System.Drawing.Point(191, 68);
            this.tbmamh.Name = "tbmamh";
            this.tbmamh.Size = new System.Drawing.Size(303, 26);
            this.tbmamh.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Môn Học";
            // 
            // datamonhoc
            // 
            this.datamonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datamonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datamonhoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datamonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamonhoc.Location = new System.Drawing.Point(579, 109);
            this.datamonhoc.Name = "datamonhoc";
            this.datamonhoc.RowHeadersWidth = 51;
            this.datamonhoc.RowTemplate.Height = 24;
            this.datamonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datamonhoc.Size = new System.Drawing.Size(563, 423);
            this.datamonhoc.TabIndex = 1;
            this.datamonhoc.Click += new System.EventHandler(this.datamonhoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(388, 373);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(98, 37);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btb_them
            // 
            this.btb_them.Location = new System.Drawing.Point(112, 373);
            this.btb_them.Name = "btb_them";
            this.btb_them.Size = new System.Drawing.Size(98, 37);
            this.btb_them.TabIndex = 8;
            this.btb_them.Text = "Thêm ";
            this.btb_them.UseVisualStyleBackColor = true;
            this.btb_them.Click += new System.EventHandler(this.btb_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(250, 373);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(98, 37);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // QuanlyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.datamonhoc);
            this.Controls.Add(this.btb_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanlyMonHoc";
            this.Text = " ";
            this.Load += new System.EventHandler(this.QuanlyMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbmamh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datamonhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btb_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox tb_tenmon;
    }
}
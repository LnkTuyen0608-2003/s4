namespace QLSV
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblĐTB = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.lblQLSV = new System.Windows.Forms.Label();
            this.cmbFalculty = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(54, 97);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(83, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã số Sinh viên";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(54, 178);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(54, 140);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblĐTB
            // 
            this.lblĐTB.AutoSize = true;
            this.lblĐTB.Location = new System.Drawing.Point(54, 215);
            this.lblĐTB.Name = "lblĐTB";
            this.lblĐTB.Size = new System.Drawing.Size(86, 13);
            this.lblĐTB.TabIndex = 0;
            this.lblĐTB.Text = "Điểm Trung Bình";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Location = new System.Drawing.Point(29, 65);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(97, 13);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông tin sinh viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 262);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(112, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(210, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(164, 90);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 20);
            this.txtMSSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(164, 137);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(164, 208);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 20);
            this.txtDTB.TabIndex = 4;
            // 
            // lblQLSV
            // 
            this.lblQLSV.AutoSize = true;
            this.lblQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSV.Location = new System.Drawing.Point(122, 9);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(466, 39);
            this.lblQLSV.TabIndex = 5;
            this.lblQLSV.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // cmbFalculty
            // 
            this.cmbFalculty.FormattingEnabled = true;
            this.cmbFalculty.Items.AddRange(new object[] {
            "Công nghệ Thông tin",
            "Ngôn ngữ anh",
            "Quản trị kinh doanh"});
            this.cmbFalculty.Location = new System.Drawing.Point(164, 178);
            this.cmbFalculty.Name = "cmbFalculty";
            this.cmbFalculty.Size = new System.Drawing.Size(121, 21);
            this.cmbFalculty.TabIndex = 6;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStudent.Location = new System.Drawing.Point(304, 65);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(440, 232);
            this.dgvStudent.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã số sinh viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Khoa";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm TB";
            this.Column4.Name = "Column4";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(620, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.cmbFalculty);
            this.Controls.Add(this.lblQLSV);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblĐTB);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblMSSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblĐTB;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label lblQLSV;
        private System.Windows.Forms.ComboBox cmbFalculty;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvStudent;
    }
}


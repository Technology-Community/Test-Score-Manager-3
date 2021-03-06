namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmDSGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSGiaoVien));
            this.gbDanhSachGiaoVien = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn();
            this.colNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCalendarColumn1 = new QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn();
            this.gbDanhSachGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDanhSachGiaoVien
            // 
            this.gbDanhSachGiaoVien.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gbDanhSachGiaoVien.Controls.Add(this.dgvDS);
            this.gbDanhSachGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.gbDanhSachGiaoVien.Name = "gbDanhSachGiaoVien";
            this.gbDanhSachGiaoVien.Size = new System.Drawing.Size(1066, 438);
            this.gbDanhSachGiaoVien.TabIndex = 1;
            this.gbDanhSachGiaoVien.TabStop = false;
            this.gbDanhSachGiaoVien.Text = "Danh sách giáo viên";
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGiaoVien,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colNoiSinh,
            this.colDiaChi,
            this.colDienThoai,
            this.colMonHoc});
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvDS.Location = new System.Drawing.Point(3, 16);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(1060, 419);
            this.dgvDS.TabIndex = 2;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.ReadOnly = true;
            this.colMaGiaoVien.Width = 105;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 105;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGioiTinh.Width = 105;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNgaySinh.Width = 105;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.DataPropertyName = "NoiSinh";
            this.colNoiSinh.HeaderText = "Nơi Sinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Width = 105;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 105;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.HeaderText = "Điện Thoại";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = false;
            this.colDienThoai.Width = 105;
            // 
            // colMonHoc
            // 
            this.colMonHoc.DataPropertyName = "MonHoc";
            this.colMonHoc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMonHoc.HeaderText = "Chuyên môn";
            this.colMonHoc.Name = "colMonHoc";
            this.colMonHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMonHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMonHoc.Width = 105;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaGiaoVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Giáo Viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewCalendarColumn1
            // 
            this.dataGridViewCalendarColumn1.DataPropertyName = "NgaySinh";
            this.dataGridViewCalendarColumn1.HeaderText = "Ngày Sinh";
            this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
            this.dataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCalendarColumn1.Width = 105;
            // 
            // frmDSGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 438);
            this.Controls.Add(this.gbDanhSachGiaoVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDSGiaoVien";
            this.Text = "Danh sách giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSGiaoVien_Load);
            this.gbDanhSachGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMonHoc;
    }
}
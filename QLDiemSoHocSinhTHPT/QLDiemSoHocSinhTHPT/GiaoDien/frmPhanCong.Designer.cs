namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmPhanCong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbKhoiLop = new System.Windows.Forms.ComboBox();
            this.lbGiaoVien = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.lbKhoiLop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bgDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colMonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGiaoVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnDS = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btChinhSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btThoat = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bgDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDS)).BeginInit();
            this.bnDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbThongTin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 125);
            this.panel1.TabIndex = 0;
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gbThongTin.Controls.Add(this.cmbLop);
            this.gbThongTin.Controls.Add(this.cmbGiaoVien);
            this.gbThongTin.Controls.Add(this.cmbMonHoc);
            this.gbThongTin.Controls.Add(this.cmbKhoiLop);
            this.gbThongTin.Controls.Add(this.lbGiaoVien);
            this.gbThongTin.Controls.Add(this.lbLop);
            this.gbThongTin.Controls.Add(this.lbMonHoc);
            this.gbThongTin.Controls.Add(this.lbNamHoc);
            this.gbThongTin.Controls.Add(this.lbKhoiLop);
            this.gbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThongTin.Location = new System.Drawing.Point(0, 0);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1135, 125);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(101, 78);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 2;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbGiaoVien.Enabled = false;
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(356, 78);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(171, 21);
            this.cmbGiaoVien.TabIndex = 4;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMonHoc.Enabled = false;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(356, 51);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(171, 21);
            this.cmbMonHoc.TabIndex = 3;
            // 
            // cmbKhoiLop
            // 
            this.cmbKhoiLop.FormattingEnabled = true;
            this.cmbKhoiLop.Location = new System.Drawing.Point(101, 51);
            this.cmbKhoiLop.Name = "cmbKhoiLop";
            this.cmbKhoiLop.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoiLop.TabIndex = 1;
            this.cmbKhoiLop.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLop_SelectedIndexChanged);
            // 
            // lbGiaoVien
            // 
            this.lbGiaoVien.AutoSize = true;
            this.lbGiaoVien.Location = new System.Drawing.Point(296, 81);
            this.lbGiaoVien.Name = "lbGiaoVien";
            this.lbGiaoVien.Size = new System.Drawing.Size(56, 13);
            this.lbGiaoVien.TabIndex = 0;
            this.lbGiaoVien.Text = "Giáo Viên:";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(43, 81);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(28, 13);
            this.lbLop.TabIndex = 0;
            this.lbLop.Text = "Lớp:";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Location = new System.Drawing.Point(296, 54);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(54, 13);
            this.lbMonHoc.TabIndex = 0;
            this.lbMonHoc.Text = "Môn Học:";
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(217, 16);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(58, 13);
            this.lbNamHoc.TabIndex = 0;
            this.lbNamHoc.Text = "Năm Học: ";
            // 
            // lbKhoiLop
            // 
            this.lbKhoiLop.AutoSize = true;
            this.lbKhoiLop.Location = new System.Drawing.Point(43, 54);
            this.lbKhoiLop.Name = "lbKhoiLop";
            this.lbKhoiLop.Size = new System.Drawing.Size(52, 13);
            this.lbKhoiLop.TabIndex = 0;
            this.lbKhoiLop.Text = "Khối Lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bgDanhSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 573);
            this.panel2.TabIndex = 0;
            // 
            // bgDanhSach
            // 
            this.bgDanhSach.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bgDanhSach.Controls.Add(this.dgvDS);
            this.bgDanhSach.Controls.Add(this.bnDS);
            this.bgDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgDanhSach.Location = new System.Drawing.Point(0, 0);
            this.bgDanhSach.Name = "bgDanhSach";
            this.bgDanhSach.Size = new System.Drawing.Size(1135, 573);
            this.bgDanhSach.TabIndex = 0;
            this.bgDanhSach.TabStop = false;
            this.bgDanhSach.Text = "Danh sách";
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDS.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonHoc,
            this.colGiaoVien,
            this.colMaPhanCong});
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(3, 60);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(1129, 510);
            this.dgvDS.TabIndex = 1;
            this.dgvDS.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDS_UserDeletingRow);
            // 
            // colMonHoc
            // 
            this.colMonHoc.DataPropertyName = "MaMonHoc";
            this.colMonHoc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMonHoc.HeaderText = "Môn Học";
            this.colMonHoc.Name = "colMonHoc";
            this.colMonHoc.Width = 57;
            // 
            // colGiaoVien
            // 
            this.colGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colGiaoVien.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colGiaoVien.HeaderText = "Giáo Viên";
            this.colGiaoVien.Name = "colGiaoVien";
            this.colGiaoVien.Width = 59;
            // 
            // colMaPhanCong
            // 
            this.colMaPhanCong.DataPropertyName = "MaPhanCong";
            this.colMaPhanCong.HeaderText = "Mã Phân Công";
            this.colMaPhanCong.Name = "colMaPhanCong";
            this.colMaPhanCong.Visible = false;
            this.colMaPhanCong.Width = 103;
            // 
            // bnDS
            // 
            this.bnDS.AddNewItem = null;
            this.bnDS.CountItem = this.bindingNavigatorCountItem;
            this.bnDS.DeleteItem = null;
            this.bnDS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btThemMoi,
            this.btChinhSua,
            this.toolStripSeparator1,
            this.btXoa,
            this.toolStripSeparator2,
            this.btThoat});
            this.bnDS.Location = new System.Drawing.Point(3, 16);
            this.bnDS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnDS.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnDS.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnDS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnDS.Name = "bnDS";
            this.bnDS.PositionItem = this.bindingNavigatorPositionItem;
            this.bnDS.Size = new System.Drawing.Size(1129, 44);
            this.bnDS.TabIndex = 0;
            this.bnDS.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 41);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // btThemMoi
            // 
            this.btThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btThemMoi.Image")));
            this.btThemMoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.RightToLeftAutoMirrorImage = true;
            this.btThemMoi.Size = new System.Drawing.Size(56, 41);
            this.btThemMoi.Text = "Thêm Mới";
            this.btThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // btChinhSua
            // 
            this.btChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btChinhSua.Image")));
            this.btChinhSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btChinhSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btChinhSua.Name = "btChinhSua";
            this.btChinhSua.Size = new System.Drawing.Size(60, 41);
            this.btChinhSua.Text = "Chỉnh Sửa";
            this.btChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btChinhSua.Click += new System.EventHandler(this.btChinhSua_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btXoa.Name = "btXoa";
            this.btXoa.RightToLeftAutoMirrorImage = true;
            this.btXoa.Size = new System.Drawing.Size(47, 41);
            this.btXoa.Text = "   Xóa   ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(51, 41);
            this.btThoat.Text = "  Thoát  ";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhanCong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phân Công";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanCong";
            this.Text = "Phân Công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.panel1.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.bgDanhSach.ResumeLayout(false);
            this.bgDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDS)).EndInit();
            this.bnDS.ResumeLayout(false);
            this.bnDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox bgDanhSach;
        private System.Windows.Forms.ComboBox cmbKhoiLop;
        private System.Windows.Forms.Label lbKhoiLop;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label lbGiaoVien;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.BindingNavigator bnDS;
        private System.Windows.Forms.ToolStripButton btThemMoi;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btChinhSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMonHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhanCong;
    }
}
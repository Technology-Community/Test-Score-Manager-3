namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmTimHocSinh1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimHocSinh1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDanToc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTonGiao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNNghiepCha = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHoTenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNNghiepMe = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.btBoQua = new System.Windows.Forms.ToolStripButton();
            this.btLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btChinhSua = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCalendarColumn1 = new QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDS)).BeginInit();
            this.bnDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.txtTenHocSinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tên học sinh";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(506, 17);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(234, 20);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(172, 20);
            this.txtTenHocSinh.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.dgvDS);
            this.groupBox2.Controls.Add(this.bnDS);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1159, 551);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh";
            // 
            // dgvDS
            // 
            this.dgvDS.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDanToc,
            this.colTonGiao,
            this.colNoiSinh,
            this.colDiaChi,
            this.colHoTenCha,
            this.colNNghiepCha,
            this.colHoTenMe,
            this.colNNghiepMe});
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(3, 60);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(1153, 488);
            this.dgvDS.TabIndex = 1;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã Học Sinh";
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDanToc
            // 
            this.colDanToc.DataPropertyName = "MaDanToc";
            this.colDanToc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colDanToc.HeaderText = "Dân Tộc";
            this.colDanToc.Name = "colDanToc";
            // 
            // colTonGiao
            // 
            this.colTonGiao.DataPropertyName = "MaTonGiao";
            this.colTonGiao.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTonGiao.HeaderText = "Tôn Giáo";
            this.colTonGiao.Name = "colTonGiao";
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.DataPropertyName = "NoiSinh";
            this.colNoiSinh.HeaderText = "Nơi Sinh";
            this.colNoiSinh.Name = "colNoiSinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colHoTenCha
            // 
            this.colHoTenCha.DataPropertyName = "HoTenCha";
            this.colHoTenCha.HeaderText = "Họ Tên Cha";
            this.colHoTenCha.Name = "colHoTenCha";
            this.colHoTenCha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHoTenCha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNNghiepCha
            // 
            this.colNNghiepCha.DataPropertyName = "MaNNghiepCha";
            this.colNNghiepCha.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colNNghiepCha.HeaderText = "Nghề Nghiệp";
            this.colNNghiepCha.Name = "colNNghiepCha";
            // 
            // colHoTenMe
            // 
            this.colHoTenMe.DataPropertyName = "HoTenMe";
            this.colHoTenMe.HeaderText = "Họ Tên Mẹ";
            this.colHoTenMe.Name = "colHoTenMe";
            // 
            // colNNghiepMe
            // 
            this.colNNghiepMe.DataPropertyName = "MaNNghiepMe";
            this.colNNghiepMe.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colNNghiepMe.HeaderText = "Nghề Nghiệp";
            this.colNNghiepMe.Name = "colNNghiepMe";
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
            this.btBoQua,
            this.btLuu,
            this.toolStripSeparator1,
            this.btXoa,
            this.toolStripSeparator2,
            this.btThoat,
            this.toolStripSeparator3,
            this.btChinhSua});
            this.bnDS.Location = new System.Drawing.Point(3, 16);
            this.bnDS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnDS.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnDS.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnDS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnDS.Name = "bnDS";
            this.bnDS.PositionItem = this.bindingNavigatorPositionItem;
            this.bnDS.Size = new System.Drawing.Size(1153, 44);
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
            // btBoQua
            // 
            this.btBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btBoQua.Image")));
            this.btBoQua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(58, 41);
            this.btBoQua.Text = "  Bỏ Qua  ";
            this.btBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(59, 41);
            this.btLuu.Text = "     Lưu     ";
            this.btLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
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
            this.btXoa.Size = new System.Drawing.Size(56, 41);
            this.btXoa.Text = "     Xóa    ";
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
            this.btThoat.Size = new System.Drawing.Size(60, 41);
            this.btThoat.Text = "    Thoát   ";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThoat.Click += new System.EventHandler(this.btThoat1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // btChinhSua
            // 
            this.btChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btChinhSua.Image")));
            this.btChinhSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btChinhSua.Name = "btChinhSua";
            this.btChinhSua.Size = new System.Drawing.Size(59, 41);
            this.btChinhSua.Text = "Chỉnh sửa";
            this.btChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btChinhSua.Click += new System.EventHandler(this.btChinhSua_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHocSinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Học Sinh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCalendarColumn1
            // 
            this.dataGridViewCalendarColumn1.DataPropertyName = "NgaySinh";
            this.dataGridViewCalendarColumn1.HeaderText = "Ngày Sinh";
            this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
            this.dataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NoiSinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nơi Sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HoTenCha";
            this.dataGridViewTextBoxColumn5.HeaderText = "Họ Tên Cha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HoTenMe";
            this.dataGridViewTextBoxColumn6.HeaderText = "Họ Tên Mẹ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmTimHocSinh1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimHocSinh1";
            this.Text = "Tìm học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimHocSinh1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDS)).EndInit();
            this.bnDS.ResumeLayout(false);
            this.bnDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.BindingNavigator bnDS;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btBoQua;
        private System.Windows.Forms.ToolStripButton btLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private QLDiemSoHocSinhTHPT.ThuVien.DataGridViewCalendarColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDanToc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenCha;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNNghiepCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenMe;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNNghiepMe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btChinhSua;
    }
}
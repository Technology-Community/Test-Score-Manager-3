namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmThemPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemPhanCong));
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.lbGiaoVien = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(89, 39);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(171, 21);
            this.cmbGiaoVien.TabIndex = 2;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(89, 12);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(171, 21);
            this.cmbMonHoc.TabIndex = 1;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // lbGiaoVien
            // 
            this.lbGiaoVien.AutoSize = true;
            this.lbGiaoVien.Location = new System.Drawing.Point(29, 42);
            this.lbGiaoVien.Name = "lbGiaoVien";
            this.lbGiaoVien.Size = new System.Drawing.Size(56, 13);
            this.lbGiaoVien.TabIndex = 3;
            this.lbGiaoVien.Text = "Giáo Viên:";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Location = new System.Drawing.Point(29, 15);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(54, 13);
            this.lbMonHoc.TabIndex = 4;
            this.lbMonHoc.Text = "Môn Học:";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(54, 78);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(153, 78);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Đóng";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmThemPhanCong
            // 
            this.AcceptButton = this.btThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(291, 120);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cmbGiaoVien);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.lbGiaoVien);
            this.Controls.Add(this.lbMonHoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemPhanCong";
            this.Text = "Thêm Phân Công";
            this.Load += new System.EventHandler(this.frmThemPhanCong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label lbGiaoVien;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
    }
}
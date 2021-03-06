using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Controller;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmNguoiDung : Form
    {

        #region Controller
        private NguoiDungController m_Controller;

        public NguoiDungController Controller
        {
            get { return m_Controller; }
            set { m_Controller = value; }
        }
        #endregion

        public frmNguoiDung()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            if (this.Controller == null)
            {
                this.Controller = new NguoiDungController();
            }
            //Hien thi combobox loai nguoi dung
            LoaiNguoiDungController ctrlLoaiNguoiDung = new LoaiNguoiDungController();
            ctrlLoaiNguoiDung.HienThiComboBox(this.cmbLoaiNguoiDung);
            ctrlLoaiNguoiDung.HienThiDataGridViewComboBoxColumn(this.colLoaiNguoiDung);

            //Hien thi combox giao vien
            GiaoVienController ctrlGiaoVien = new GiaoVienController();
            ctrlGiaoVien.HienThiComboBox(this.cmbGiaoVien);
            //Them mot dong co ma giao vien la null de khi chon loai nguoi dung k phai la  giao vien
            DataRow row = ctrlGiaoVien.Data.DataService.NewRow();
            row["MaGiaoVien"] = DBNull.Value;
            row["HoTen"] = "Khác...";
            ctrlGiaoVien.Data.DataService.Rows.Add(row);
            
            //An combobox giao vien
            this.lbGiaoVien.Visible = false;
            this.cmbGiaoVien.Visible = false;

            //Dat vi tri combobox giao vien trung voi ten nguoi dung
            this.lbGiaoVien.Location = this.lbTenNguoiDung.Location;
            this.cmbGiaoVien.Location = this.txtTenNguoiDung.Location;

            this.Controller.HienThiDS(this.dgvDS, this.bnDS, this.txtTenDangNhap, this.txtMatKhau, this.cmbLoaiNguoiDung, this.txtTenNguoiDung, this.cmbGiaoVien);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLoaiNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Neu chon loai nguoi dung la giao vien
            if (int.Parse(this.cmbLoaiNguoiDung.SelectedIndex.ToString()) == 2)
            {
                this.txtTenNguoiDung.Visible = false;
                this.lbTenNguoiDung.Visible = false;

                this.lbGiaoVien.Visible = true;
                this.cmbGiaoVien.Visible = true;
            }
            else
            {
                this.txtTenNguoiDung.Visible = true;
                this.lbTenNguoiDung.Visible = true;

                this.lbGiaoVien.Visible = false;
                this.cmbGiaoVien.Visible = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLuu_Click(object sender, EventArgs e)
        {
            //Neu dang chon loai nguoi dung la giao vien
            if (this.cmbLoaiNguoiDung.SelectedIndex == 2)
            {
                this.txtTenNguoiDung.Text = this.cmbGiaoVien.Text;
            }
            else
            {
                this.cmbGiaoVien.SelectedValue = DBNull.Value;
            }

            this.bindingNavigatorPositionItem.Focus();
            this.bnDS.BindingSource.Position = int.Parse(this.bindingNavigatorPositionItem.Text);
            this.Controller.Update();

            this.btThem.Enabled = true;
            this.btXoa.Enabled = true;
            this.btLuu.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không?", "Xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.dgvDS.SelectedRows.GetEnumerator();
                //Truong hop co nhieu dong duoc chon
                if (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    this.dgvDS.Rows.Remove(row);
                    while (ie.MoveNext())
                    {
                        row = (DataGridViewRow)ie.Current;
                        this.dgvDS.Rows.Remove(row);
                    }
                }
                else    //Chi chon mot dong
                {
                    this.bnDS.BindingSource.RemoveCurrent();
                }

                if (this.Controller.Update())
                {
                    MessageBox.Show("Đã xóa!", "Xóa người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Neu trong danh sach khong con dong nao
                    if (this.dgvDS.Rows.Count == 0)
                    {
                        this.btXoa.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Xóa người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    //Khong the xoa, load lai danh sach
                    this.Controller.Data.LayDS();

                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.bnDS.BindingSource.AddNew();
            this.bnDS.BindingSource.MoveLast();

            this.btThem.Enabled = false;
            this.btXoa.Enabled = false;
            this.btLuu.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /* 
       * Khi co mot cell trong DataGridView bo thay doi gia tri
       * Ta cho enable va disable cac button va cac item context menu cho phu hop
       * */
            this.btLuu.Enabled = true;
            this.btThem.Enabled = false;
            this.btXoa.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNguoiDung_Shown(object sender, EventArgs e)
        {
            this.btThem.Enabled = true;
            this.btXoa.Enabled = true;
        }
    }
}
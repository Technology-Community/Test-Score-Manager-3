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
    public partial class frmNhapDiem : Form
    {
        #region NamHocController
        private NamHocController m_NamHocController;

        public NamHocController NamHocController
        {
            get { return m_NamHocController; }
            set { m_NamHocController = value; }
        }

        #endregion

        #region KhoiLopController
        private KhoiLopController m_KhoiLopController;

        public KhoiLopController KhoiLopController
        {
            get { return m_KhoiLopController; }
            set { m_KhoiLopController = value; }
        }

        #endregion

        #region LopController
        private LopController m_LopController;

        public LopController LopController
        {
            get { return m_LopController; }
            set { m_LopController = value; }
        }

        #endregion

        #region HocKyController
        private HocKyController m_HocKyController;

        public HocKyController HocKyController
        {
            get { return m_HocKyController; }
            set { m_HocKyController = value; }
        }

        #endregion

        #region PhanLopController
        private PhanLopController m_PhanLopController;

        public PhanLopController PhanLopController
        {
            get { return m_PhanLopController; }
            set { m_PhanLopController = value; }
        }

        #endregion

        #region LopMonHocController
        private LopMonHocController m_LopMonHocController;

        public LopMonHocController LopMonHocController
        {
            get { return m_LopMonHocController; }
            set { m_LopMonHocController = value; }
        }

        #endregion

        #region LoaiDiemController
        private LoaiDiemController m_LoaiDiemController;

        public LoaiDiemController LoaiDiemController
        {
            get { return m_LoaiDiemController; }
            set { m_LoaiDiemController = value; }
        }

        #endregion

        #region DiemController
        private DiemController m_DiemController;

        public DiemController DiemController
        {
            get { return m_DiemController; }
            set { m_DiemController = value; }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public frmNhapDiem()
        {
            InitializeComponent();

            if (this.NamHocController == null)
            {
                this.NamHocController = new NamHocController();
            }
            if (this.KhoiLopController == null)
            {
                this.KhoiLopController = new KhoiLopController();
            }
            if (this.LopController == null)
            {
                this.LopController = new LopController();
            }
            if (this.HocKyController == null)
            {
                this.HocKyController = new HocKyController();
            }
            if (this.PhanLopController == null)
            {
                this.PhanLopController = new PhanLopController();
            }
            if (this.LopMonHocController == null)
            {
                this.LopMonHocController = new LopMonHocController();
            }
            if (this.LoaiDiemController == null)
            {
                this.LoaiDiemController = new LoaiDiemController();
            }
            if (this.DiemController == null)
            {
                this.DiemController = new DiemController();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int PhatSinhMa()
        {
            int lastID = new DiemController().LayMaCuoi();
            lastID++;
            return lastID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            this.NamHocController.HienThiCombobox(this.cmbNamHoc);
            this.KhoiLopController.HienThiCombobox(this.cmbKhoiLop);
            this.HocKyController.HienThiCombobox(this.cmbHocKy);
            //this.PhanLopController.HienThiDS(this.lvDSLopHoc, ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
            //this.PhanLopController.HienThiDS(this.lvDSLopHoc, ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
            this.LoaiDiemController.HienThiCombobox(this.cmbLoaiDiem);
            new LoaiDiemController().HienThiDataGridComboBoxColumnLoaiDiem(this.colLoaiDiem);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbNamHoc.SelectedIndex != -1 && this.cmbKhoiLop.SelectedIndex != -1)
            {
                string maGiaoVien = Utilities.TTNguoiDungDangNhap.GiaoVien.MaGiaoVien;
                this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbNamHoc.SelectedItem).Row.ItemArray[0].ToString(), maGiaoVien);
                if (this.cmbLop.Items.Count > 0)
                {
                    this.cmbLop.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbNamHoc.SelectedIndex != -1 && this.cmbKhoiLop.SelectedIndex != -1)
            {
                string maGiaoVien = Utilities.TTNguoiDungDangNhap.GiaoVien.MaGiaoVien;
                this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbNamHoc.SelectedItem).Row.ItemArray[0].ToString(), maGiaoVien);
                //this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbNamHoc.SelectedItem).Row.ItemArray[0].ToString(), Utilities.TTNguoiDungDangNhap.GiaoVien.MaGiaoVien);
                if (this.cmbLop.Items.Count > 0)
                {
                    this.cmbLop.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLop.SelectedIndex != -1)
            {
                this.PhanLopController.HienThiDS(this.lvDSLopHoc, ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
                LopInfo lop = new LopController().LayTuMa(((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
                this.LopMonHocController.HienThiComboBox(this.cmbMonHoc, lop, Utilities.TTNguoiDungDangNhap.GiaoVien);
            }
            else
            {
                this.PhanLopController.HienThiDS(this.lvDSLopHoc, "");
                LopInfo lop = new LopInfo();
                this.LopMonHocController.HienThiComboBox(this.cmbMonHoc, lop, Utilities.TTNguoiDungDangNhap.GiaoVien);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.cmbHocKy.SelectedIndex != -1) && (this.lvDSLopHoc.SelectedItems.Count > 0))
            {
                PhanLopInfo phanLop = new PhanLopController().LayTuMa(((DataRow)((object[])this.lvDSLopHoc.SelectedItems[0].Tag)[1])["MaHocSinhLop"].ToString());
                MonHocInfo monHoc = new MonHocController().LayTuMa(((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString());
                HocKyInfo hocKy = new HocKyController().LayTuMa(((DataRowView)this.cmbHocKy.SelectedItem).Row.ItemArray[0].ToString());
                this.DiemController.HienThiDS(this.dgvDSDiem, this.bnDSDiem, phanLop, monHoc, hocKy);
            }
            else
            {
                this.DiemController.Data.DataService.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThem_Click(object sender, EventArgs e)
        {
            if (this.lvDSLopHoc.SelectedItems.Count > 0)
            {
                DataRow row = this.DiemController.Data.DataService.NewRow();
                row["ID"] = this.PhatSinhMa();
                row["MaHocSinhLop"] = ((DataRow)((object[])this.lvDSLopHoc.SelectedItems[0].Tag)[1])["MaHocSinhLop"].ToString();
                row["MaMonHoc"] = ((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString();
                row["MaHocKy"] = ((DataRowView)this.cmbHocKy.SelectedItem).Row.ItemArray[0].ToString();
                row["MaLoai"] = ((DataRowView)this.cmbLoaiDiem.SelectedItem).Row.ItemArray[0].ToString();
                row["Diem"] = this.numDiem.Value;

                this.DiemController.Data.DataService.Rows.Add(row);

                /*this.DiemController.Update();

                this.TinhDiemTBHKMH(this.DiemController.Data.DataService.Copy());*/
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (this.dgvDSDiem.Rows.Count > 0)
            {
                DataRow row = this.DiemController.Data.DataService.Rows[this.bnDSDiem.BindingSource.Position];
                row["MaLoai"] = ((DataRowView)this.cmbLoaiDiem.SelectedItem).Row.ItemArray[0].ToString();
                row["Diem"] = this.numDiem.Value;

                /*this.DiemController.Update();

                this.TinhDiemTBHKMH(this.DiemController.Data.DataService.Copy());*/
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không?", "Xóa điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.dgvDSDiem.SelectedCells.Count > 0)
                {
                    IEnumerator ie = this.dgvDSDiem.SelectedRows.GetEnumerator();
                    //Truong hop co nhieu dong duoc chon
                    if (ie.MoveNext())
                    {
                        DataGridViewRow row = (DataGridViewRow)ie.Current;
                        this.dgvDSDiem.Rows.Remove(row);
                        while (ie.MoveNext())
                        {
                            row = (DataGridViewRow)ie.Current;
                            this.dgvDSDiem.Rows.Remove(row);
                        }
                    }
                    else    //Chi chon mot dong
                    {
                        this.bnDSDiem.BindingSource.RemoveCurrent();
                    }

                    /*if (this.DiemController.Update())
                    {
                        MessageBox.Show("Đã xóa!", "Xóa Điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.TinhDiemTBHKMH(this.DiemController.Data.DataService.Copy());
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!", "Xóa Dân điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Khong the xoa, load lai danh sach
                        this.DiemController.Data.LayDS();
                    }*/
                }
            }
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
        private void lvDSLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.cmbHocKy.SelectedIndex != -1) && (this.lvDSLopHoc.SelectedItems.Count > 0) && (this.cmbMonHoc.SelectedIndex != -1))
            {
                PhanLopInfo phanLop = new PhanLopController().LayTuMa(((DataRow)((object[])this.lvDSLopHoc.SelectedItems[0].Tag)[1])["MaHocSinhLop"].ToString());
                MonHocInfo monHoc = new MonHocController().LayTuMa(((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString());
                HocKyInfo hocKy = new HocKyController().LayTuMa(((DataRowView)this.cmbHocKy.SelectedItem).Row.ItemArray[0].ToString());
                this.DiemController.HienThiDS(this.dgvDSDiem, this.bnDSDiem, phanLop, monHoc, hocKy);

                foreach (ListViewItem item in this.lvDSLopHoc.Items)
                {
                    item.BackColor = Color.White;
                }
                this.lvDSLopHoc.SelectedItems[0].BackColor = Color.LightBlue;
            }
            else
            {
                this.DiemController.Data.DataService.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.cmbHocKy.SelectedIndex != -1) && (this.lvDSLopHoc.SelectedItems.Count != -1) && (this.cmbMonHoc.SelectedIndex != -1))
            {
                if (this.lvDSLopHoc.SelectedItems.Count > 0)
                {
                    PhanLopInfo phanLop = new PhanLopController().LayTuMa(((DataRow)((object[])this.lvDSLopHoc.SelectedItems[0].Tag)[1])["MaHocSinhLop"].ToString());
                    MonHocInfo monHoc = new MonHocController().LayTuMa(((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString());
                    HocKyInfo hocKy = new HocKyController().LayTuMa(((DataRowView)this.cmbHocKy.SelectedItem).Row.ItemArray[0].ToString());
                    this.DiemController.HienThiDS(this.dgvDSDiem, this.bnDSDiem, phanLop, monHoc, hocKy);
                }
            }
            else
            {
                this.DiemController.Data.DataService.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblDiem"></param>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        /// <param name="maHocKy"></param>
        public void TinhDiemTBMonHocKy(DataTable tblDiem, string maHocSinhLop, string maMonHoc, string maHocKy)
        {
            /* Tinh diem va them hoac cap nhat vo ket qua (v10.1) */
            LoaiDiemController loaiDiemCtrl = new LoaiDiemController();
            int tongHeSo = 0;
            float tongDiem = 0;
            foreach (DataRow rDiem in tblDiem.Rows)
            {
                int heSo = loaiDiemCtrl.LayTuMa(rDiem["MaLoai"].ToString()).HeSo;
                float diemNhanHeSo = float.Parse(rDiem["Diem"].ToString()) * heSo;
                tongHeSo += heSo;
                tongDiem += diemNhanHeSo;
            }
            /* Them hoac update vo table KQ_HOC_KY_MON_HOC */
            QLDiemSoHocSinhTHPT.Data.KQHocKyMonHocData kqHKMHData = new QLDiemSoHocSinhTHPT.Data.KQHocKyMonHocData();
            DataTable tblKQHKMH = kqHKMHData.LayTuMa(maHocSinhLop, maMonHoc, maHocKy);
            if (tblKQHKMH.Rows.Count == 0)
            {
                DataRow rKQ = tblKQHKMH.NewRow();
                rKQ["MaHocSinhLop"] = maHocSinhLop;
                rKQ["MaMonHoc"] = maMonHoc;
                rKQ["MaHocKy"] = maHocKy;
                rKQ["DTBMonHocKy"] = ((tongHeSo != 0) ? (tongDiem / tongHeSo) : 0);
                tblKQHKMH.Rows.Add(rKQ);
            }
            else
            {
                tblKQHKMH.Rows[0]["DTBMonHocKy"] = ((tongHeSo != 0) ? (tongDiem / tongHeSo) : 0);
            }
            kqHKMHData.Update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLuu_Click(object sender, EventArgs e)
        {
            this.DiemController.Update();

            string maHocSinhLop = ((DataRow)((object[])this.lvDSLopHoc.SelectedItems[0].Tag)[1])["MaHocSinhLop"].ToString();
            string maMonHoc = ((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString();
            string maHocKy = ((DataRowView)this.cmbHocKy.SelectedItem).Row.ItemArray[0].ToString();

            this.TinhDiemTBMonHocKy(this.DiemController.Data.DataService.Copy(), maHocSinhLop, maMonHoc, maHocKy);
            //float DTBMonCaNam = QLDiemSoHocSinhTHPT.Controller.KQCaNamMonHocController.TinhDTBMonCaNam(maHocSinhLop, maMonHoc);
            //MessageBox.Show(DTBMonCaNam.ToString());
        }
    }
}
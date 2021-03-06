using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QLDiemSoHocSinhTHPT.BusinessObject;
using QLDiemSoHocSinhTHPT.Controller;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmPhanCong : Form
    {
        #region NamHocContorller
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

        #region LopMonHocController
        private LopMonHocController m_LopMonHocController;

        public LopMonHocController LopMonHocController
        {
            get { return m_LopMonHocController; }
            set { m_LopMonHocController = value; }
        }
	
        #endregion

        #region GiaoVienController
        private GiaoVienController m_GiaoVienController;

        public GiaoVienController GiaoVienController
        {
            get { return m_GiaoVienController; }
            set { m_GiaoVienController = value; }
        }
	
        #endregion

        #region PhanCongController
        private PhanCongController m_PhanCongController;

        public PhanCongController PhanCongController
        {
            get { return m_PhanCongController; }
            set { m_PhanCongController = value; }
        }

        #endregion

        public frmPhanCong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
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
            if (this.LopMonHocController == null)
            {
                this.LopMonHocController = new LopMonHocController();
            }
            if (this.GiaoVienController == null)
            {
                this.GiaoVienController = new GiaoVienController();
            }
            if (this.PhanCongController == null)
            {
                this.PhanCongController = new PhanCongController();
            }

            this.lbNamHoc.Font = new Font(this.lbNamHoc.Font, FontStyle.Bold);
            this.lbNamHoc.Tag = this.NamHocController.LayTuMa(this.NamHocController.LayMaCuoi());
            this.lbNamHoc.Text = "Năm Học " + ((NamHocInfo)this.lbNamHoc.Tag).TenNamHoc;
            
            this.LopMonHocController.HienThiComboBox(this.cmbMonHoc);
            new LopMonHocController().HienThiDataGridViewComboBoxColumn(this.colMonHoc);
            this.GiaoVienController.HienThiComboBox(this.cmbGiaoVien);
            new GiaoVienController().HienThiDataGridComboBoxColumn(this.colGiaoVien);

            this.PhanCongController.HienThiDS(this.dgvDS, this.bnDS, this.cmbMonHoc, this.cmbGiaoVien);

            this.KhoiLopController.HienThiCombobox(this.cmbKhoiLop);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoiLop.SelectedIndex != -1)
            {
                this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((NamHocInfo)this.lbNamHoc.Tag).MaNamHoc);
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
                LopInfo lopInfo = new LopInfo();
                lopInfo.MaLop = ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString();
                this.PhanCongController.Data.LayDS(lopInfo);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            frmThemPhanCong frm_PhanCong = new frmThemPhanCong(((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString(), this.PhanCongController);
            frm_PhanCong.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không?", "Xóa Giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                if (this.PhanCongController.Update())
                {
                    MessageBox.Show("Đã xóa!", "Xóa Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Xóa Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.PhanCongController = new PhanCongController();
                    //Khong the xoa, load lai danh sach
                    this.PhanCongController.Data.LayDS();
                    //GiaoVienController.this.Controller.HienThiDS(this.dgvList, this.bn);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDS_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không?", "Xóa Giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //Neu chon No, cancel thao tac xoa
                e.Cancel = true;
            }
            else
            {
                /*
                 * Vi thao tac xoa chi co tac dung tren DataGridView nen ta cancel di
                 * Sau co xoa theo cach cua ta
                 * */
                e.Cancel = true;
                IEnumerator ie = this.dgvDS.SelectedRows.GetEnumerator();
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
                else
                {
                    this.bnDS.BindingSource.RemoveCurrent();
                }

                if (this.PhanCongController.Update())
                {
                    MessageBox.Show("Đã xóa!", "Xóa Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Xóa giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.PhanCongController = new PhanCongController();
                    this.PhanCongController.Data.LayDS();
                    //this.Controller.DisplayList(this.dgvList, this.bn);
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
        private void btChinhSua_Click(object sender, EventArgs e)
        {
            PhanCongInfo phanCong = new PhanCongInfo();
            DataRowView r = (DataRowView)this.bnDS.BindingSource.Current;
            phanCong = new PhanCongController().LayTuMa(int.Parse(r["MaPhanCong"].ToString()));

            frmCapNhatPhanCong frm = new frmCapNhatPhanCong(phanCong);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                phanCong = frm.PhanCong;
                DataRow row = this.PhanCongController.Data.DataService.Rows[this.bnDS.BindingSource.Position];
                row["MaGiaoVien"] = phanCong.GiaoVien.MaGiaoVien;
                this.PhanCongController.Update();
            }
        }
    }
}
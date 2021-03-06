using System;
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
    public partial class frmThemPhanCong : Form
    {
        private string m_MaLop;

        public string MaLop
        {
            get { return m_MaLop; }
            set { m_MaLop = value; }
        }

        private PhanCongController m_PhanCongController;

        public PhanCongController PhanCongController
        {
            get { return m_PhanCongController; }
            set { m_PhanCongController = value; }
        }

        private LopMonHocController mLopMonHocController;

        public LopMonHocController LopMonHocController
        {
            get { return mLopMonHocController; }
            set { mLopMonHocController = value; }
        }

        private GiaoVienController m_GiaoVienController;

        public GiaoVienController GiaoVienController
        {
            get { return m_GiaoVienController; }
            set { m_GiaoVienController = value; }
        }

        private bool m_IsAdd;

        public bool IsAdd
        {
            get { return m_IsAdd; }
            set { m_IsAdd = value; }
        }
	

        /// <summary>
        /// 
        /// </summary>
        public frmThemPhanCong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khoi tao form them
        /// </summary>
        /// <param name="maLop"></param>
        /// <param name="phanCongCtrl"></param>
        public frmThemPhanCong(String maLop, PhanCongController phanCongCtrl)
        {
            InitializeComponent();
            this.MaLop = maLop;
            this.PhanCongController = phanCongCtrl;
            this.LopMonHocController = new LopMonHocController();
            this.GiaoVienController = new GiaoVienController();
            this.IsAdd = true;
        }

        /// <summary>
        /// Khoi tao form cap nhat
        /// </summary>
        /// <param name="maLop"></param>
        /// <param name="phanCongCtrl"></param>
        /// <param name="index"></param>
        public frmThemPhanCong(String maLop, PhanCongController phanCongCtrl, int index)
        {
            InitializeComponent();
            this.MaLop = maLop;
            this.PhanCongController = phanCongCtrl;
            this.LopMonHocController = new LopMonHocController();
            this.GiaoVienController = new GiaoVienController();
            this.IsAdd = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmThemPhanCong_Load(object sender, EventArgs e)
        {
            this.LopMonHocController.HienThiComboBoxDSChuaPhanCong(this.cmbMonHoc, this.MaLop);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMonHoc.SelectedIndex != -1)
            {
                MonHocInfo info = new MonHocInfo();
                info.MaMonHoc = ((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString();
                this.GiaoVienController.HienThiComboBox(this.cmbGiaoVien, info);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThem_Click(object sender, EventArgs e)
        {
            DataRow row = this.PhanCongController.Data.DataService.NewRow();
            row["MaLopMonHoc"] = int.Parse(this.cmbMonHoc.SelectedValue.ToString());
            row["MaGiaoVien"] = this.cmbGiaoVien.SelectedValue.ToString();
            this.PhanCongController.Data.DataService.Rows.Add(row);

            this.PhanCongController.Update();

            this.LopMonHocController.HienThiComboBoxDSChuaPhanCong(this.cmbMonHoc, this.MaLop);
            if (this.cmbMonHoc.Items.Count > 0)
            {
                MonHocInfo infoMonHoc = new MonHocInfo();
                infoMonHoc.MaMonHoc = ((DataRowView)this.cmbMonHoc.SelectedItem).Row.ItemArray[2].ToString();
                this.GiaoVienController.HienThiComboBox(this.cmbGiaoVien, infoMonHoc);
            }
        }
    }
}
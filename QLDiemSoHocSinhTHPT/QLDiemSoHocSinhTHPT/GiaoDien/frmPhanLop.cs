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
    public partial class frmPhanLop : Form
    {
        #region HocSinhControllerCu
        private HocSinhController m_HocSinhControllerCu;

        public HocSinhController HocSinhControllerCu
        {
            get { return m_HocSinhControllerCu; }
            set { m_HocSinhControllerCu = value; }
        }
	
        #endregion

        #region KhoiLopControllerCu
        private KhoiLopController m_KhoiLopControllerCu;

        public KhoiLopController KhoiLopControllerCu
        {
            get { return m_KhoiLopControllerCu; }
            set { m_KhoiLopControllerCu = value; }
        }

        #endregion

        #region LopControllerCu
        private LopController m_LopControllerCu;

        public LopController LopControllerCu
        {
            get { return m_LopControllerCu; }
            set { m_LopControllerCu = value; }
        }
	
        #endregion

        #region PhanLopCu
        private PhanLopController m_PhanLopConrollerCu;

        public PhanLopController PhanLopControllerCu
        {
            get { return m_PhanLopConrollerCu; }
            set { m_PhanLopConrollerCu = value; }
        }

        #endregion

        #region HocSinhControllerMoi
        private HocSinhController m_HocSinhControllerMoi;

        public HocSinhController HocSinhControllerMoi
        {
            get { return m_HocSinhControllerMoi; }
            set { m_HocSinhControllerMoi = value; }
        }

        #endregion

        #region KhoiLopControllerMoi
        private KhoiLopController m_KhoiLopControllerMoi;

        public KhoiLopController KhoiLopControllerMoi
        {
            get { return m_KhoiLopControllerMoi; }
            set { m_KhoiLopControllerMoi = value; }
        }

        #endregion

        #region LopControllerMoi
        private LopController m_LopControllerMoi;

        public LopController LopControllerMoi
        {
            get { return m_LopControllerMoi; }
            set { m_LopControllerMoi = value; }
        }

        #endregion

        #region PhanLopControllerMoi
        private PhanLopController m_PhanLopControllerMoi;

        public PhanLopController PhanLopControllerMoi
        {
            get { return m_PhanLopControllerMoi; }
            set { m_PhanLopControllerMoi = value; }
        }

        #endregion

        #region NamHocController
        private NamHocController m_NamHocController;

        public NamHocController NamHocController
        {
            get { return m_NamHocController; }
            set { m_NamHocController = value; }
        }

        #endregion

        public frmPhanLop()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            if (this.KhoiLopControllerCu == null)
            {
                this.KhoiLopControllerCu = new KhoiLopController();
            }
            if (this.LopControllerCu == null)
            {
                this.LopControllerCu = new LopController();
            }
            if (this.HocSinhControllerCu == null)
            {
                this.HocSinhControllerCu = new HocSinhController();
            }
            if (this.PhanLopControllerCu == null)
            {
                this.PhanLopControllerCu = new PhanLopController();
            }

            if (this.NamHocController == null)
            {
                this.NamHocController = new NamHocController();
            }
            if (this.KhoiLopControllerMoi == null)
            {
                this.KhoiLopControllerMoi = new KhoiLopController();
            }
            if (this.LopControllerMoi == null)
            {
                this.LopControllerMoi = new LopController();
            }
            if (this.HocSinhControllerMoi == null)
            {
                this.HocSinhControllerMoi = new HocSinhController();
            }
            if (this.PhanLopControllerMoi == null)
            {
                this.PhanLopControllerMoi = new PhanLopController();
            }

            string maNamHocMoi = this.NamHocController.LayMaCuoi();
            string maNamHocCu = this.NamHocController.LayMaTruoc(maNamHocMoi);
            NamHocInfo infoNamHocMoi = this.NamHocController.LayTuMa(maNamHocMoi);
            NamHocInfo infoNamHocCu = this.NamHocController.LayTuMa(maNamHocCu);

            this.gbNamHocCu.Text = "Năm Học " + infoNamHocCu.TenNamHoc;
            this.gbNamHocCu.Tag = maNamHocCu;
            this.gbNamHocMoi.Text = "Năm Học " + infoNamHocMoi.TenNamHoc;
            this.gbNamHocMoi.Tag = maNamHocMoi;

            this.KhoiLopControllerMoi.HienThiCombobox(this.cmbKhoiLopMoi);
            this.KhoiLopControllerCu.HienThiCombobox(this.cmbKhoiLopCu);

            this.cmbKhoiLopMoi.SelectedIndex = 0;
            this.cmbKhoiLopCu.SelectedIndex = 0;
            if (this.cmbLopMoi.Items.Count > 0)
            {
                this.cmbLopMoi.SelectedIndex = 0;
            }
            if (this.cmbLopCu.Items.Count > 0)
            {
                this.cmbLopCu.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhoiLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoiLopMoi.SelectedIndex != -1)
            {
                this.LopControllerMoi.HienThiCombobox(this.cmbLopMoi, ((DataRowView)this.cmbKhoiLopMoi.SelectedItem).Row.ItemArray[0].ToString(), this.gbNamHocMoi.Tag.ToString());
                this.cmbLopMoi.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLopMoi.SelectedIndex != -1)
            {
                this.PhanLopControllerMoi.HienThiDS(this.lvDSLopMoi, ((DataRowView)this.cmbLopMoi.SelectedItem).Row.ItemArray[0].ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhoiLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoiLopCu.SelectedIndex != -1)
            {
                this.LopControllerCu.HienThiCombobox(this.cmbLopCu, ((DataRowView)this.cmbKhoiLopCu.SelectedItem).Row.ItemArray[0].ToString(), this.gbNamHocCu.Tag.ToString());
                this.cmbLopCu.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLopCu.SelectedIndex != -1)
            {
                this.PhanLopControllerCu.HienThiDS(this.lvDSLopCu, ((DataRowView)this.cmbLopCu.SelectedItem).Row.ItemArray[0].ToString(), this.gbNamHocMoi.Tag.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThemTatCa_Click(object sender, EventArgs e)
        {
            this.cmbKhoiLopMoi.Enabled = false;
            this.cmbLopMoi.Enabled = false;
            this.cmbKhoiLopCu.Enabled = false;
            this.cmbLopCu.Enabled = false;
            this.btXoa.Enabled = false;
            this.btXoaHet.Enabled = false;
            IEnumerator ie = this.lvDSLopCu.Items.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.lvDSLopCu.Items.Remove(item);
                this.lvDSLopMoi.Items.Add(item);
                DataRow row = this.PhanLopControllerMoi.Data.DataService.NewRow();
                string maHocSinhLop = this.PhatSinhMa();
                row["MaHocSinhLop"] = maHocSinhLop;
                row["MaLop"] = ((DataRowView)this.cmbLopMoi.SelectedItem).Row.ItemArray[0].ToString();
                row["MaHocSinh"] = item.Text;
                this.PhanLopControllerMoi.Data.DataService.Rows.Add(row);
                object[] tag = (object[])item.Tag;
                tag[1] = row;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThem_Click(object sender, EventArgs e)
        {
            this.cmbKhoiLopMoi.Enabled = false;
            this.cmbLopMoi.Enabled = false;
            this.cmbKhoiLopCu.Enabled = false;
            this.cmbLopCu.Enabled = false;
            this.btXoa.Enabled = false;
            this.btXoaHet.Enabled = false;
            IEnumerator ie = this.lvDSLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.lvDSLopCu.Items.Remove(item);
                this.lvDSLopMoi.Items.Add(item);
                DataRow row = this.PhanLopControllerMoi.Data.DataService.NewRow();
                string maHocSinhLop = this.PhatSinhMa();
                row["MaHocSinhLop"] = maHocSinhLop;
                row["MaLop"] = ((DataRowView)this.cmbLopMoi.SelectedItem).Row.ItemArray[0].ToString();
                row["MaHocSinh"] = item.Text;
                this.PhanLopControllerMoi.Data.DataService.Rows.Add(row);
                object[] tag = (object[])item.Tag;
                tag[1] = row;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoa_Click(object sender, EventArgs e)
        {
            IEnumerator ie = this.lvDSLopMoi.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                object[] tag = (object[])item.Tag;
                DataRow row = ((DataRow)((object[])item.Tag)[1]);
                this.PhanLopControllerMoi.Data.DataService.Rows[this.PhanLopControllerMoi.Data.DataService.Rows.IndexOf(row)].Delete();
                this.lvDSLopMoi.Items.Remove(item);
            }
            if (this.PhanLopControllerMoi.Luu())
            {
                MessageBox.Show("Đã xóa");
                if (this.cmbLopCu.SelectedIndex != -1)
                {
                    this.PhanLopControllerCu.HienThiDS(this.lvDSLopCu, ((DataRowView)this.cmbLopCu.SelectedItem).Row.ItemArray[0].ToString(), this.gbNamHocMoi.Tag.ToString());
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLuu_Click(object sender, EventArgs e)
        {
            this.cmbKhoiLopMoi.Enabled = true;
            this.cmbLopMoi.Enabled = true;
            this.cmbKhoiLopCu.Enabled = true;
            this.cmbLopCu.Enabled = true;
            this.btXoa.Enabled = true;
            this.btXoaHet.Enabled = true;

            bool b = this.PhanLopControllerMoi.Luu();
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
        /// <returns></returns>
        public String PhatSinhMa()
        {
            PhanLopController phanLopCtrl = new PhanLopController();
            string lastID = "";
            int numOfLastID;
            string id = "H";
            string maLop = ((DataRowView)this.cmbLopCu.SelectedItem).Row.ItemArray[0].ToString();

            if (this.PhanLopControllerMoi.Data.DataService.Rows.Count > 0)
            {
                lastID = this.PhanLopControllerMoi.Data.DataService.Rows[this.PhanLopControllerMoi.Data.DataService.Rows.Count - 1]["MaHocSinhLop"].ToString();
            }
            else
            {
                lastID = this.PhanLopControllerMoi.LayMaCuoi(maLop);
            }

            if (lastID == "")
            {
                numOfLastID = 1;
                id = id + maLop.Substring(1, maLop.Length - 1);
                int n = 13 - id.Length - 2;
                for (int i = 0; i < n; i++)
                {
                    id += "0";
                }
                id = id + (100 + numOfLastID).ToString().Substring(1, 2);
                return id;
            }
            else
            {
                numOfLastID = int.Parse(lastID.Substring(11, 2));
                numOfLastID++;
                id = id + maLop.Substring(1, maLop.Length - 1);
                int n = lastID.Length - id.Length - 2;
                for (int i = 0; i < n; i++)
                {
                    id += "0";
                }
                id = id + (100 + numOfLastID).ToString().Substring(1, 2);
                return id;
            }
        }

        /// <summary>
        /// Phát sinh một lỗi là những học sinh mới được tiếp nhận cũng bị xóa và không có khả năng phục hồi được
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoaHet_Click(object sender, EventArgs e)
        {
            IEnumerator ie = this.lvDSLopMoi.Items.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                object[] tag = (object[])item.Tag;
                DataRow row = ((DataRow)((object[])item.Tag)[1]);
                this.PhanLopControllerMoi.Data.DataService.Rows[this.PhanLopControllerMoi.Data.DataService.Rows.IndexOf(row)].Delete();
                this.lvDSLopMoi.Items.Remove(item);
            }
            if (this.PhanLopControllerMoi.Luu())
            {
                MessageBox.Show("Đã xóa");
                if (this.cmbLopCu.SelectedIndex != -1)
                {
                    this.PhanLopControllerCu.HienThiDS(this.lvDSLopCu, ((DataRowView)this.cmbLopCu.SelectedItem).Row.ItemArray[0].ToString(), this.gbNamHocMoi.Tag.ToString());
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBoQua_Click(object sender, EventArgs e)
        {
            if (this.cmbLopMoi.SelectedIndex != -1)
            {
                this.PhanLopControllerMoi.HienThiDS(this.lvDSLopMoi, ((DataRowView)this.cmbLopMoi.SelectedItem).Row.ItemArray[0].ToString());
            }
            if (this.cmbLopCu.SelectedIndex != -1)
            {
                this.PhanLopControllerCu.HienThiDS(this.lvDSLopCu, ((DataRowView)this.cmbLopCu.SelectedItem).Row.ItemArray[0].ToString(), this.gbNamHocMoi.Tag.ToString());
            }
            this.cmbKhoiLopMoi.Enabled = true;
            this.cmbLopMoi.Enabled = true;
            this.cmbKhoiLopCu.Enabled = true;
            this.cmbLopCu.Enabled = true;
            this.btXoa.Enabled = true;
            this.btXoaHet.Enabled = true;
        }
    }
}
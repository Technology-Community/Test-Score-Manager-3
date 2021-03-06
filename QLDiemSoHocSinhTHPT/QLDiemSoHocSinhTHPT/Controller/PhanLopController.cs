using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;


namespace QLDiemSoHocSinhTHPT.Controller
{
    public class PhanLopController
    {
        #region Data
        private PhanLopData m_Data;

        public PhanLopData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	

        #endregion

        public PhanLopController()
        {
            this.Data = new PhanLopData();
        }

        /// <summary>
        /// Hien thi danh sach phan lop trong ListView theo ma lop
        /// </summary>
        /// <param name="lvDS"></param>
        /// <param name="maLop"></param>
        public void HienThiDS(ListView lvDS, string maLop)
        {
            if (this.Data == null)
            {
                this.Data = new PhanLopData();
            }
            DataTable table = this.Data.LayDSTuMaLop(maLop);
            int n = table.Rows.Count;
            lvDS.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                
                String maHocSinh = table.Rows[i]["MaHocSinh"].ToString();
                HocSinhController HSController = new HocSinhController();
                HocSinhInfo info = HSController.LayTuMa(maHocSinh);

                // v10.1
                ListViewItem item = new ListViewItem();
                //item.Text = info.MaHocSinh;
                item.Text = table.Rows[i]["MaHocSinhLop"].ToString();
                item.SubItems.Add(info.HoTen);
                if (info.GioiTinh == true)
                {
                    item.SubItems.Add("Nam");
                }
                else
                {
                    item.SubItems.Add("Nữ");
                }
                item.SubItems.Add(info.NgaySinh.ToShortDateString());
                item.SubItems.Add(info.NoiSinh);
                item.SubItems.Add(info.DiaChi);

                object[] tag = new object[2];
                tag[0] = info;
                tag[1] = table.Rows[i];
                item.Tag = tag;

                lvDS.Items.Add(item);
            }
        }

        /// <summary>
        /// Hien thi danh sach phan lop trong ListView theo ma lop cu va ma lop moi
        /// sao cho cac hoc sinh trong lop cu k xuat hien trong lop moi
        /// </summary>
        /// <param name="lvDS"></param>
        /// <param name="maLopCu"></param>
        /// <param name="maLopMoi"></param>
        public void HienThiDS(ListView lvDS, string maLopCu, string maNamHocMoi)
        {
            if (this.Data == null)
            {
                this.Data = new PhanLopData();
            }
            DataTable table = this.Data.LayDSLopCu(maLopCu, maNamHocMoi);
            int n = table.Rows.Count;
            lvDS.Items.Clear();
            for (int i = 0; i < n; i++)
            {
               
                String maHocSinh = table.Rows[i]["MaHocSinh"].ToString();
                HocSinhController HSController = new HocSinhController();
                HocSinhInfo info = HSController.LayTuMa(maHocSinh);

                ListViewItem item = new ListViewItem();
                item.Text = info.MaHocSinh;
                item.SubItems.Add(info.HoTen);
                if (info.GioiTinh == true)
                {
                    item.SubItems.Add("Nam");
                }
                else
                {
                    item.SubItems.Add("Nữ");
                }
                item.SubItems.Add(info.NgaySinh.ToShortDateString());
                item.SubItems.Add(info.NoiSinh);
                item.SubItems.Add(info.DiaChi);

                object[] tag = new object[2];
                tag[0] = info;
                tag[1] = table.Rows[i];
                item.Tag = tag;

                lvDS.Items.Add(item);
            }
        }

        public void HienThiDanhSach(DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new PhanLopData();
            }

        }

        /// <summary>
        /// Lay danh sach phan lop
        /// </summary>
        /// <returns></returns>
        public IList<PhanLopInfo> LayDS()
        {
            return new List<PhanLopInfo>();
        }

        /// <summary>
        /// Lay mot doi tuong phan lop tu ma lop
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <returns></returns>
        public PhanLopInfo LayTuMa(String maHocSinhLop)
        {
            if (this.Data == null)
            {
                this.Data = new PhanLopData();
            }
            DataTable table = this.Data.LayTuMa(maHocSinhLop);
            if (table.Rows.Count > 0)
            {
                PhanLopInfo info = new PhanLopInfo();
                info.MaHocSinhLop = table.Rows[0]["MaHocSinhLop"].ToString();
                info.MaHocSinh = table.Rows[0]["MaHocSinh"].ToString();
                info.MaLop = table.Rows[0]["MaLop"].ToString();

                return info;
            }
            return null;
        }

        /// <summary>
        /// Lay danh sach phan lop theo ma lop
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public IList<PhanLopInfo> LayTuMaLop(String maLop)
        {
            return new List<PhanLopInfo>();
        }

        /// <summary>
        /// Lay danh sach phan lop theo ma hoc sinh
        /// </summary>
        /// <param name="maHocSinh"></param>
        /// <returns></returns>
        public IList<PhanLopInfo> LayTuMaHocSinh(String maHocSinh)
        {
            return new List<PhanLopInfo>();
        }

        /// <summary>
        /// Lay ma cua record cuoi cung trong bang phan lop
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public string LayMaCuoi(string maLop)
        {
            if (this.Data == null)
            {
                this.Data = new PhanLopData();
            }
            return Convert.ToString(this.Data.LayMaCuoi(maLop));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static String PhatSinhMa(string maLop)
        {
            PhanLopController phanLopCtrl = new PhanLopController();
            string lastID = "";
            int numOfLastID;
            string id = "H";

            lastID = phanLopCtrl.LayMaCuoi(maLop);
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
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ThemPhanLop(PhanLopInfo info)
        {
            PhanLopData phanLopData = new PhanLopData();
            return phanLopData.ThemPhanLop(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Luu()
        {
            return this.Data.Update();
        }
    }
}

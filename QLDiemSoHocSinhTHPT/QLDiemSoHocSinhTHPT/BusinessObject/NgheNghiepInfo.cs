using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class NgheNghiepInfo
    {
        /// <summary>
        /// Mã nghề nghiệp
        /// </summary>
        #region MaNgheNghiep
        private string m_MaNgheNghiep;

        public string MaNgheNghiep
        {
            get { return m_MaNgheNghiep; }
            set { m_MaNgheNghiep = value; }
        }
        #endregion

        /// <summary>
        /// Tên nghề nghiệp
        /// </summary>
        #region TenNgheNghiep
        private string m_TenNgheNghiep;

        public string TenNgheNghiep
        {
            get { return m_TenNgheNghiep; }
            set { m_TenNgheNghiep = value; }
        }
        #endregion
    }
}

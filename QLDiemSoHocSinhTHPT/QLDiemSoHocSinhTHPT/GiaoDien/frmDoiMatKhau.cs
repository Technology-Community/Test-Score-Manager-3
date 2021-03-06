using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT;
using QLDiemSoHocSinhTHPT.Controller;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmDoiMatKhau : Form
    {

        #region NguoiDungInfo
        private NguoiDungInfo m_InfoNguoiDung;

        public NguoiDungInfo InfoNguoiDung
        {
            get { return m_InfoNguoiDung; }
            set { m_InfoNguoiDung = value; }
        }
        
        #endregion


        #region NguoiDungController
        private NguoiDungController m_CtrlNguoiDung;

        public NguoiDungController CtrlNguoiDung
        {
            get { return m_CtrlNguoiDung; }
            set { m_CtrlNguoiDung = value; }
        }

        #endregion

       
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.txtMatKhauCu.Text = "";
            this.txtMatKhauMoi.Text = "";
            this.txtNhapLaiMatKhauMoi.Text = "";
            this.txtMatKhauCu.Focus();
        }

        private void txtMatKhauCu_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Select(0, txt.Text.Length);
        }

        private void txtMatKhauMoi_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Select(0, txt.Text.Length);
        }

        private void txtNhapLaiMatKhauMoi_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Select(0, txt.Text.Length);
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            if (this.CheckValid())
            {
                if (Utilities.TTNguoiDungDangNhap.MatKhau != this.txtMatKhauCu.Text)
                {
                    MessageBox.Show("Bạn nhập sai mật khẩu cũ! \nYêu cầu nhập lại mật khẩu cũ!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMatKhauCu.Focus();
                }
                else if (this.txtMatKhauMoi.Text != this.txtNhapLaiMatKhauMoi.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu sai! \nYêu cầu nhập lại mật khẩu mới và xác nhận!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNhapLaiMatKhauMoi.Text = "";
                    this.txtMatKhauMoi.Text = "";
                    this.txtMatKhauMoi.Focus();
                }
                else
                {
                    if (this.CtrlNguoiDung == null)
                    {
                        this.CtrlNguoiDung = new NguoiDungController();
                    }
                    if (this.CtrlNguoiDung.Update(Utilities.TTNguoiDungDangNhap, this.txtMatKhauMoi.Text))
                    {
                        Utilities.TTNguoiDungDangNhap.MatKhau = this.txtMatKhauMoi.Text;
                        MessageBox.Show("Mật khẩu đã được cập nhật!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
        }

        public bool CheckValid()
        {
            if (this.txtMatKhauCu.Text == "" || this.txtMatKhauCu.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMatKhauCu.Focus();
                return false;
            }
            if (this.txtMatKhauMoi.Text == "" || this.txtMatKhauMoi.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMatKhauMoi.Focus();
                return false;
            }
            if (this.txtNhapLaiMatKhauMoi.Text == "" || this.txtNhapLaiMatKhauMoi.Text == null)
            {
                MessageBox.Show("Bạn chưa xác nhận lại mật khẩu mới!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNhapLaiMatKhauMoi.Focus();
                return false;
            }
            return true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        private string loginacc;
        public frmProfile(string acc)
        {

            InitializeComponent();
            loginacc = acc;
            ChangeAcc(loginacc);
        }

        void ChangeAcc(string acc)
        {
            txtUserNameProfile.Text = loginacc;
        }
        void UpdateAcc()
        {
            string username = txtUserNameProfile.Text;
            string passwork = txtPassworkProfile.Text;
            string newpass = txtNewPassProfile.Text;
            string repass = txtRePassworkProfile.Text;
            if (!newpass.Equals(repass))
                MessageBox.Show("Nhập lại mật khẩu không đúng", "Thông báo");
            else
            {
                if (AccountBUS.Instance.ChangeInfoAcc(username, passwork, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập không đúng", "Thông báo");
                    //if (MessageBox.Show("Mật khẩu nhập không đúng", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                    //{

                    //}
                }
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAcc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

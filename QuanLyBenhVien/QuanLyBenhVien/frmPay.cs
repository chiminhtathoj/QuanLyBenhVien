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
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }

        private void btnSearchPay_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtSearchPay.Text, out id);
            dtgvBill.DataSource = BillBUS.Instance.SearchBillNotPayByIDPatient(id);
            dtgvBill.Columns[0].HeaderText = "Mã hóa đơn";
            dtgvBill.Columns[1].HeaderText = "Mã bệnh nhân";
            dtgvBill.Columns[2].HeaderText = "Ngày lập";
            dtgvBill.Columns[3].HeaderText = "Tình trạng";
            dtgvBill.Columns[4].HeaderText = "Tổng tiền";
            foreach (DataGridViewColumn col in dtgvBill.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }

        private void txtSearchPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnInsertTest_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtSearchPay.Text, out id);
            if (BillBUS.Instance.UpdateBillPaid(id))
            {
                dtgvBill.DataSource = BillBUS.Instance.SearchBillNotPayByIDPatient(id);
                MessageBox.Show("Thanh toán thành công");
            }
            else
                MessageBox.Show("Thanh toán thất bại ");
        }
    }
}

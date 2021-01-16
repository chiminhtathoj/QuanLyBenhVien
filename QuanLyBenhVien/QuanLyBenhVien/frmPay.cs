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
            if (string.IsNullOrEmpty(id.ToString()))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân!");
                return;
            }
            if (id > PatientBUS.Instance.GetMaxIDPatient() || id < 1)
            {
                MessageBox.Show("Mã bệnh nhân không đúng!");
                return;
            }
            
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
            if (BillBUS.Instance.GetTypeInsuranceByIDMedicalBill(id) == 0)
            {
                MessageBox.Show("Bệnh nhân không có bảo hiểm y tế");
                txtSumMoney.Text = BillBUS.Instance.CalSumMoney(id).ToString();
            }
            else
            {
                MessageBox.Show("Bệnh nhân có bảo hiểm y tế");
                txtSumMoney.Text = (BillBUS.Instance.CalSumMoney(id) / 2).ToString();
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
            if (string.IsNullOrEmpty(id.ToString()))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân!");
                return;

            }
            if (id>PatientBUS.Instance.GetMaxIDPatient() || id < 1)
            {
                MessageBox.Show("Mã bệnh nhân không đúng!");
                return;

            }
            if (BillBUS.Instance.UpdateBillPaid(id))
            {
                dtgvBill.DataSource = BillBUS.Instance.SearchBillNotPayByIDPatient(id);
                MessageBox.Show("Thanh toán thành công");
            }
            else
                MessageBox.Show("Thanh toán thất bại ");
            txtSumMoney.Clear();
        }
    }
}

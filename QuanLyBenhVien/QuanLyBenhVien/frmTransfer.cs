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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void btnSearchTransfer_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDPatient.Text, out id);
            PatientBUS.Instance.LoadPatientByID(id, dtgvPatient);
        }

        private void btnInsertTransfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDPatient.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
            }
            if (string.IsNullOrEmpty(rtbStatusPre.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng của bệnh nhân!");
            }
            if (string.IsNullOrEmpty(rtbReason.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do chuyển viện!");
            }

            int id = 0;
            int.TryParse(txtIDPatient.Text, out id);
            if (TransferBUS.Instance.InsertTransfer(id,rtbReason.Text,rtbStatusPre.Text))
            {
                MessageBox.Show("Tạo giấy chuyển viện thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo giấy chuyển viện thất bại!");
            }
        }
    }
}

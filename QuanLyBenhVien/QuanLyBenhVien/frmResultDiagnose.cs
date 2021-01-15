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
    public partial class frmResultDiagnose : Form
    {
        public frmResultDiagnose()
        {
            InitializeComponent();
        }

        private void btnSearchTestByTestID_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDTest.Text, out id);
            TestBUS.Instance.GetTestByTestID(id, dtgvTest);
        }

        private void btnInsertTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDTest.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu xét nghiệm!");
                return;
            }
            if (string.IsNullOrEmpty(rtbResultDiagnose.Text))
            {
                MessageBox.Show("Vui lòng điền kết quả!");
                return;
            }
            if (string.IsNullOrEmpty(cbbDOT.Text))
            {
                MessageBox.Show("Vui lòng chọn hướng điều trị!");
                return;
            }
            if (string.IsNullOrEmpty(dtpkDateResult.Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn ngày!");
                return;
            }
            int idTest = 0;
            int.TryParse(txtIDTest.Text, out idTest);
            ResultDiagnoseBUS.Instance.InsertResultDiagnose(idTest, dtpkDateResult.Value, rtbResultDiagnose.Text, cbbDOT.Text);
            if (string.Equals(cbbDOT.Text,"Ngoại trú"))
            {
                this.Close();
                frmPrescription f = new frmPrescription();
                f.ShowDialog();
            }
        }

        private void cbbDOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbDOT.Text)
            {
                case "Không có bệnh":
                    btnInsertTest.Text = "Lập phiếu kết quả";
                    break;
                case "Ngoại trú":
                    btnInsertTest.Text = "Lập đơn thuốc";
                    break;
                case "Nhập viện":
                    btnInsertTest.Text = "Lập giấy nhập viện";
                    break;
                case "Chuyển viện":
                    btnInsertTest.Text = "Lập giấy chuyển viện";
                    break;
                default:
                    break;
            }
        }
    }
}

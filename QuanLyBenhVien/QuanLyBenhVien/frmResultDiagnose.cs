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
            txtIDTest.Text = TestBUS.Instance.GetMaxIDTest().ToString();
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
            if (int.Parse(txtIDTest.Text) > TestBUS.Instance.GetMaxIDTest() || int.Parse(txtIDTest.Text) < 1)
            {
                MessageBox.Show("Vui lòng chọn phiếu xét nghiệm hợp lệ!");
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
            if (ResultDiagnoseBUS.Instance.isTestExist(int.Parse(txtIDTest.Text)))
            {
                MessageBox.Show("Bệnh nhân trong mã phiếu này đả có kết quả rồi!");
                return;
            }
            int idTest = 0;
            int.TryParse(txtIDTest.Text, out idTest);
            ResultDiagnoseBUS.Instance.InsertResultDiagnose(idTest, dtpkDateResult.Value, rtbResultDiagnose.Text, cbbDOT.Text);
            MessageBox.Show("Thêm phiếu kết quả thành công!");
            if (string.Equals(cbbDOT.Text,"Ngoại trú"))
            {
                this.Close();
                frmPrescription f = new frmPrescription();
                f.ShowDialog();
            }
            if (string.Equals(cbbDOT.Text, "Không có bệnh"))
            {
                this.Close();
            }
            if (string.Equals(cbbDOT.Text, "Nhập viện"))
            {
                this.Close();
                frmMedicalRecord f = new frmMedicalRecord();
                f.ShowDialog();
            }
            if (string.Equals(cbbDOT.Text, "Chuyển viện"))
            {
                this.Close();
                frmTransfer f = new frmTransfer();
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

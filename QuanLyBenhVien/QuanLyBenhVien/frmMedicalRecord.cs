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
    public partial class frmMedicalRecord : Form
    {
        public frmMedicalRecord()
        {
            InitializeComponent();
           
        }

        private void btnSearchMedicalByIDMedicalBill_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDPatient.Text, out id);
            PatientBUS.Instance.LoadPatientByID(id, dtgvPatient);
        }

        private void btnInsertTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDPatient.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
            }
            if (string.IsNullOrEmpty(rtbStatusPre.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng của bệnh nhân!");
            }

            int id = 0;
            int.TryParse(txtIDPatient.Text, out id);
            if(MedicalRecordBUS.Instance.InsertMedicalRecord(id, rtbStatusPre.Text))
            {
                MessageBox.Show("Tạo hồ sơ bệnh án thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo hồ sơ bệnh án thất bại!");
            }
        }
    }
}

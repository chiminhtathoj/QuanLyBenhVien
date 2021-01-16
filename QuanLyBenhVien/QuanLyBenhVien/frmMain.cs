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
    public partial class frmMain : Form
    {
        string currentAcc;
        BindingSource PatientBinding = new BindingSource();
        BindingSource DoctorBinding = new BindingSource();
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string username)
        {
            InitializeComponent();
            this.currentAcc = username;

            ChangeAccount(AccountBUS.Instance.GetTypeAccByUserName(username));
            loadall();
        }
        void loadall()
        {
            PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
            AddPatientBinding();
            DoctorBUS.Instance.LoadDoctor(dtgvDoctor, DoctorBinding);
            AddDoctorBinding();
        }
        private void thôngTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(currentAcc);
            f.ShowDialog();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddPatientBinding()
        {
            txtIDMedicalBill.Text = (MedicalBillBUS.Instance.GetMaxIDMedicalBill() + 1).ToString();
            cbbTypeInsurance.Text = "0";//khi load loại bảo hiểm là 0
            dtpkDOBPatient.Format = DateTimePickerFormat.Custom;
            dtpkDOBPatient.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            txtIDCardPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "CMND", true, DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtNamePatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "HoTenBN", true, DataSourceUpdateMode.Never));
            txtIDPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "MaBN", true, DataSourceUpdateMode.Never));
            dtpkDOBPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "NgaySinhBN", true, DataSourceUpdateMode.Never));
            cbbSexPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "GioiTinhBN", true, DataSourceUpdateMode.Never));
            txtPhonePatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "DienThoaiBN", true, DataSourceUpdateMode.Never));
            txtAddressPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "DiaChiBN", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
        }
        void AddDoctorBinding()
        {
            dtpkDateMedicalExamination.Format = DateTimePickerFormat.Custom;
            dtpkDateMedicalExamination.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            txtIDDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "MaBS", true, DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtNameDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "HoTenBS", true, DataSourceUpdateMode.Never));
            cbbFaculty.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "TenKhoa", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
        }
        void ChangeAccount(string type)
        {

        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagement f = new frmManagement(currentAcc);
            f.ShowDialog();
            PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
            DoctorBUS.Instance.LoadDoctor(dtgvDoctor, DoctorBinding);
        }

        private void btnSearchPatientByName_Click(object sender, EventArgs e)
        {
            PatientBUS.Instance.SearchListPatientByName(txtNamePatient.Text, PatientBinding);
        }

        private void btnSearchPatientByIDCard_Click(object sender, EventArgs e)
        {
            PatientBUS.Instance.SearchListPatientByIDCard(txtIDCardPatient.Text, PatientBinding);

        }

        private void btnSearchDoctorByName_Click(object sender, EventArgs e)
        {
            DoctorBUS.Instance.SearchListDoctorByName(txtNameDoctor.Text, DoctorBinding);
        }

        private void cbbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoctorBUS.Instance.SearchListDoctorByFaculty(cbbFaculty.Text, DoctorBinding);
        }

        private void btnInsertMedicalBill_Click(object sender, EventArgs e)
        {
            int idDoctor = 0;
            int.TryParse(txtIDDoctor.Text, out idDoctor);
            int idPatient = 0;
            int.TryParse(txtIDPatient.Text, out idPatient);
            int type = 0;
            int.TryParse(cbbTypeInsurance.Text, out type);
            DateTime date = dtpkDateMedicalExamination.Value;
            string symptom = txtSymptom.Text;
            if (MedicalBillBUS.Instance.InsertMedicalBill(idDoctor, idPatient, date, symptom, type))//nếu thành công thì in ra phiếu khám bệnh
            {
                MessageBox.Show("Lập phiếu khám bệnh thành công");
                DGVPrinter printer = new DGVPrinter();
                MedicalBillBUS.Instance.GetMedicalBillByMedicalBillID(MedicalBillBUS.Instance.GetMaxIDMedicalBill(), dtgvMedicalBill);
                dtgvMedicalBill.Columns[0].HeaderText = "Mã Phiếu khám";
                dtgvMedicalBill.Columns[1].HeaderText = "Mã bác sĩ";
                dtgvMedicalBill.Columns[2].HeaderText = "Mã bệnh nhân";
                dtgvMedicalBill.Columns[3].HeaderText = "Ngày khám";
                dtgvMedicalBill.Columns[4].HeaderText = "Triệu chứng";
                foreach (DataGridViewColumn col in dtgvMedicalBill.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
                }
                printer.Title = " \r\n\r\r Phiếu khám bệnh\r\n\r\n  ";
                printer.SubTitle = "Tên bệnh nhân: " + txtNamePatient.Text.ToString() + "   Mã phiếu khám:  " + MedicalBillBUS.Instance.GetMaxIDMedicalBill();
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dtgvMedicalBill);
            }
            else
            {
                MessageBox.Show("Lập phiếu khám bệnh thất bại");
            }
        }

        private void cbIsInsurance_CheckedChanged(object sender, EventArgs e)//nếu check thì cho nhập loại bảo hiểm
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                cbbTypeInsurance.Text = "1";
            }
            else
            {
                cbbTypeInsurance.Text = "0";
            }
        }



        private void khamBênhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExamination f = new frmExamination();
            f.ShowDialog();

        }

        private void kêtQuaChânĐoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResultDiagnose f = new frmResultDiagnose();
            f.ShowDialog();
        }
    }
}

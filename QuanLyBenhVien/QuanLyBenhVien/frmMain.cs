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
            AddCustomerBinding();
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
        void AddCustomerBinding()
        {
            dtpkDOBPatient.Format = DateTimePickerFormat.Custom;
            dtpkDOBPatient.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            txtIDCardPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "CMND", true, DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtNamePatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "HoTenBN", true, DataSourceUpdateMode.Never));
            dtpkDOBPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "NgaySinhBN", true, DataSourceUpdateMode.Never));
            cbbSexPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "GioiTinhBN", true, DataSourceUpdateMode.Never));
            txtPhonePatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "DienThoaiBN", true, DataSourceUpdateMode.Never));
            txtAddressPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "DiaChiBN", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
        }
        void ChangeAccount(string type)
        {
           
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagement f = new frmManagement(currentAcc);
            f.ShowDialog();
            PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
        }

        private void btnSearchPatientByName_Click(object sender, EventArgs e)
        {
            PatientBUS.Instance.SearchListPatientByName(txtNamePatient.Text, PatientBinding);
        }

        private void btnSearchPatientByIDCard_Click(object sender, EventArgs e)
        {
            PatientBUS.Instance.SearchListPatientByIDCard(txtIDCardPatient.Text, PatientBinding);

        }
    }
}

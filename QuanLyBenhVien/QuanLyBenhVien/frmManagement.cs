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
    public partial class frmManagement : Form
    {
        BindingSource AccountBinding = new BindingSource();
        BindingSource PatientBinding = new BindingSource();
        BindingSource DoctorBinding = new BindingSource();
        BindingSource ServiceBinding = new BindingSource();
        string currentAcc;
        public frmManagement(string acc)
        {
            InitializeComponent();
            currentAcc = acc;
            authorization(currentAcc);
            LoadAll();
        }
        void LoadAll()
        {
            LoadAccount();
            AddAccountBinding();
            PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
            AddPatientBinding();
            DoctorBUS.Instance.LoadDoctor(dtgvDoctor, DoctorBinding);
            AddDoctorBinding();
            ServiceBUS.Instance.LoadService(dtgvService, ServiceBinding);
            AddServiceBinding();
        }
        void authorization(string acc)// phần quyền người dùng trong form quản lý
        {
            string type = AccountBUS.Instance.GetTypeAccByUserName(acc);
            switch (type)
            {
                case "Bác sĩ":
                    tcManagement.TabPages.Remove(tpAccount);
                    break;
                default:
                    break;
            }
        }
        private void tcManagement_SelectedIndexChanged(object sender, EventArgs e)//chọn accept button cho mỗi tag
        {
            if (tcManagement.SelectedTab == tcManagement.TabPages["tpAccount"])
            {
                this.AcceptButton = btnSearchUser;
                txtSearchUser.Focus(); //focus textbox
            }
            if (tcManagement.SelectedTab == tcManagement.TabPages["tpPatient"])
            {
                this.AcceptButton = btnSearchPatient;
                txtSearchPatient.Focus(); //focus textbox
            }
            if (tcManagement.SelectedTab == tcManagement.TabPages["tpDoctor"])
            {
                this.AcceptButton = btnSearchDoctor;
                txtSearchDoctor.Focus(); //focus textbox
            }
        }
        #region Account
        void LoadAccount()
        {
            dtgvAccount.DataSource = AccountBinding;
            AccountBinding.DataSource = AccountBUS.Instance.GetListAccount();
            dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvAccount.Columns[1].HeaderText = "Quyền hạn";
            foreach (DataGridViewColumn col in dtgvAccount.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }

        }
        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("text", dtgvAccount.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            cbbUserType.DataBindings.Add(new Binding("text", dtgvAccount.DataSource, "Loai", true, DataSourceUpdateMode.Never));

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string type = cbbUserType.Text;
            if (string.IsNullOrWhiteSpace(username)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng điền tên", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Vui lòng chọn loại người dùng", "thông báo");
                return;
            }
            if (AccountBUS.Instance.InsertAcc(username, type))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadAccount();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            if (string.IsNullOrWhiteSpace(username)) // phải chọn người xóa
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa", "thông báo");
                return;
            }
            if (currentAcc.Equals(username))
            {
                MessageBox.Show("Không thể tự hủy bản thân mình được!!!", "Thông báo");
                return;
            }
            if (AccountBUS.Instance.DeleteAcc(username))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadAccount();
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string type = cbbUserType.Text;
            if (string.IsNullOrWhiteSpace(username)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Vui lòng chọn loại người dùng cần sửa", "thông báo");
                return;
            }
            if (AccountBUS.Instance.UpdateAcc(username, type))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadAccount();
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            AccountBinding.DataSource = AccountBUS.Instance.SearchAccByUserName(txtSearchUser.Text);
        }

        private void btnResetAccPW_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            if (AccountBUS.Instance.ResetAcc(username))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                LoadAccount();
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        #endregion
        #region Patient

        void AddPatientBinding()
        {
            dtpkDOBPatient.Format = DateTimePickerFormat.Custom;
            dtpkDOBPatient.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            txtIDPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "MaBN", true, DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtIDCardPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtNamePatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "HoTenBN", true, DataSourceUpdateMode.Never));
            dtpkDOBPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "NgaySinhBN", true, DataSourceUpdateMode.Never));
            cbbSexPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "GioiTinhBN", true, DataSourceUpdateMode.Never));
            txtPhonePatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "DienThoaiBN", true, DataSourceUpdateMode.Never));
            txtAddressPatient.DataBindings.Add(new Binding("text", dtgvPatient.DataSource, "DiaChiBN", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string name = txtNamePatient.Text;
            string phone = txtPhonePatient.Text;
            string idCard = txtIDCardPatient.Text;
            DateTime DOB = dtpkDOBPatient.Value;
            string sex = cbbSexPatient.Text;
            string address = txtAddressPatient.Text;
            if (string.IsNullOrWhiteSpace(name)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập tên", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(phone)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(idCard)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập chứng minh nhân dân", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(DOB.ToString())) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(sex)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui chọn giới tính", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(address)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "thông báo");
                return;
            }
            if (PatientBUS.Instance.isExist(idCard))
            {
                MessageBox.Show("Bệnh nhân đả có trong danh sách,vui lòng kiểm tra lại!", "thông báo");
                return;
            }
            if (PatientBUS.Instance.InsertPatient(idCard, name, DOB, sex, phone, address))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDPatient.Text, out id);
            string name = txtNamePatient.Text;
            string phone = txtPhonePatient.Text;
            string idCard = txtIDCardPatient.Text;
            DateTime DOB = dtpkDOBPatient.Value;
            string sex = cbbSexPatient.Text;
            string address = txtAddressPatient.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(DOB.ToString()) ||
                string.IsNullOrWhiteSpace(phone.ToString()) || string.IsNullOrWhiteSpace(sex.ToString()) || string.IsNullOrWhiteSpace(idCard.ToString())
                || string.IsNullOrWhiteSpace(address.ToString())) // check các textbox phải điền đầy đủ mới cho sửa 
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa", "thông báo");
                return;
            }
            if (PatientBUS.Instance.isExist(idCard))
            {
                MessageBox.Show("Bệnh nhân đả có trong danh sách,vui lòng kiểm tra lại!", "thông báo");
                return;
            }
            if (PatientBUS.Instance.UpdatePatient(id, idCard, name, DOB, sex, phone, address))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btnLoadPatient_Click(object sender, EventArgs e)
        {
            PatientBUS.Instance.LoadPatient(dtgvPatient, PatientBinding);
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            PatientBUS.Instance.SearchListPatientByName(txtSearchPatient.Text, PatientBinding);
        }
        private void txtNamePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar));
        }



        private void txtPhonePatient_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhonePatient_Leave(object sender, EventArgs e)
        {
            if (txtPhonePatient.Text.Length != 10)
            {
                txtPhonePatient.Clear();
                MessageBox.Show("Vui lòng nhập 10 số");
            }
        }
        private void txtIDCardPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion
        #region Doctor
        void AddDoctorBinding()
        {

            dtpkDOBDoctor.Format = DateTimePickerFormat.Custom;
            dtpkDOBDoctor.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            txtIDDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "MaBS", true, DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtIDCardDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtNameDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "HoTenBS", true, DataSourceUpdateMode.Never));
            dtpkDOBDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "NgaySinhBS", true, DataSourceUpdateMode.Never));
            cbbSexDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "GioiTinhBS", true, DataSourceUpdateMode.Never));
            txtPhoneDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "DienThoaiBS", true, DataSourceUpdateMode.Never));
            txtAddressDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "DiaChiBS", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
            cbbFacultyDoctor.DataBindings.Add(new Binding("text", dtgvDoctor.DataSource, "TenKhoa", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            string name = txtNameDoctor.Text;
            string phone = txtPhoneDoctor.Text;
            string idCard = txtIDCardDoctor.Text;
            DateTime DOB = dtpkDOBDoctor.Value;
            string sex = cbbSexDoctor.Text;
            string address = txtAddressDoctor.Text;
            string faculty = cbbFacultyDoctor.Text;
            int idFaculty = 0;
            if (string.IsNullOrWhiteSpace(name)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập tên", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(phone)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(idCard)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập chứng minh nhân dân", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(DOB.ToString())) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(sex)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui chọn giới tính", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(address)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(faculty)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng chọn khoa", "thông báo");
                return;
            }
            else
            {
                switch (faculty)
                {
                    case "Khoa ngoại":
                        idFaculty = 1;
                        break;
                    case "Khoa nội":
                        idFaculty = 2;
                        break;
                    case "Khoa phụ sản":
                        idFaculty = 3;
                        break;
                    case "Khoa nhi":
                        idFaculty = 4;
                        break;
                    case "Khoa cấp cứu":
                        idFaculty = 5;
                        break;
                    case "Khoa hồi sức":
                        idFaculty = 6;
                        break;
                    case "Khoa ung bướu":
                        idFaculty = 7;
                        break;
                    default:
                        break;
                }
            }
            if (DoctorBUS.Instance.InsertDoctor(idCard, name, DOB, sex, phone, address, idFaculty))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                DoctorBUS.Instance.LoadDoctor(dtgvDoctor, DoctorBinding);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDDoctor.Text, out id);
            string name = txtNameDoctor.Text;
            string phone = txtPhoneDoctor.Text;
            string idCard = txtIDCardDoctor.Text;
            DateTime DOB = dtpkDOBDoctor.Value;
            string sex = cbbSexDoctor.Text;
            string address = txtIDCardDoctor.Text;
            string faculty = cbbFacultyDoctor.Text;
            int idFaculty = 0;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(DOB.ToString()) ||
                string.IsNullOrWhiteSpace(phone.ToString()) || string.IsNullOrWhiteSpace(sex.ToString()) || string.IsNullOrWhiteSpace(idCard.ToString())
                || string.IsNullOrWhiteSpace(address.ToString()) || string.IsNullOrWhiteSpace(faculty.ToString())) // check các textbox phải điền đầy đủ mới cho sửa 
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa", "thông báo");
                return;
            }

            switch (faculty)
            {
                case "Khoa ngoại":
                    idFaculty = 1;
                    break;
                case "Khoa nội":
                    idFaculty = 2;
                    break;
                case "Khoa phụ sản":
                    idFaculty = 3;
                    break;
                case "Khoa nhi":
                    idFaculty = 4;
                    break;
                case "Khoa cấp cứu":
                    idFaculty = 5;
                    break;
                case "Khoa hồi sức":
                    idFaculty = 6;
                    break;
                case "Khoa ung bướu":
                    idFaculty = 7;
                    break;
                default:
                    break;
            }
            if (DoctorBUS.Instance.UpdateDoctor(id, idCard, name, DOB, sex, phone, address, idFaculty))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                DoctorBUS.Instance.LoadDoctor(dtgvDoctor, DoctorBinding);
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btnLoadDoctor_Click(object sender, EventArgs e)
        {
            DoctorBUS.Instance.LoadDoctor(dtgvPatient, PatientBinding);
        }
        private void txtPhoneDoctor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhoneDoctor_Leave(object sender, EventArgs e)
        {
            if (txtPhoneDoctor.Text.Length != 10)
            {
                txtPhoneDoctor.Clear();
                MessageBox.Show("Vui lòng nhập 10 số");
            }
        }

        private void txtNameDoctor_KeyPress(object sender, KeyPressEventArgs e) //không cho viết số vào tên
        {
            e.Handled = (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar));
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            DoctorBUS.Instance.SearchListDoctorByName(txtSearchDoctor.Text, DoctorBinding);
        }

        private void txtIDCardDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }




        #endregion
        #region Service
        void AddServiceBinding()
        {
            txtIDService.DataBindings.Add(new Binding("text", dtgvService.DataSource, "MaDV", true, DataSourceUpdateMode.Never));
            txtNameService.DataBindings.Add(new Binding("text", dtgvService.DataSource, "TenDV", true, DataSourceUpdateMode.Never));
            txtPriceService.DataBindings.Add(new Binding("text", dtgvService.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            string nameservice = txtNameService.Text;
            double price = 0;
            double.TryParse(txtPriceService.Text, out price);
            if (string.IsNullOrWhiteSpace(nameservice)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng điền tên", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(price.ToString()))
            {
                MessageBox.Show("Vui lòng điền đơn giá", "thông báo");
                return;
            }
            if (ServiceBUS.Instance.InsertService(nameservice, price))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                ServiceBUS.Instance.LoadService(dtgvService, ServiceBinding);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDService.Text, out id);
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa", "thông báo");
                return;
            }
            if (ServiceBUS.Instance.DeleteService(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                ServiceBUS.Instance.LoadService(dtgvService, ServiceBinding);
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDService.Text, out id);
            string nameservice = txtNameService.Text;
            double price = 0;
            double.TryParse(txtPriceService.Text, out price);
            if (string.IsNullOrWhiteSpace(nameservice)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(id.ToString())) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(price.ToString()))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa", "thông báo");
                return;
            }
            if (ServiceBUS.Instance.UpdateService(id, nameservice, price))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                ServiceBUS.Instance.LoadService(dtgvService, ServiceBinding);
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btnLoadService_Click(object sender, EventArgs e)
        {
            ServiceBUS.Instance.LoadService(dtgvService, ServiceBinding);
        }

        private void btnSearchServiceByName_Click(object sender, EventArgs e)
        {
            ServiceBUS.Instance.SearchListServiceByName(txtSearchService.Text, ServiceBinding);
        }
        #endregion

    }
}

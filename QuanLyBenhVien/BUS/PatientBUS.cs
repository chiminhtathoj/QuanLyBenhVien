using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PatientBUS
    {

        private static PatientBUS instance;

        public static PatientBUS Instance
        {
            get { if (instance == null) instance = new PatientBUS(); return instance; }
            set => instance = value;
        }
        private PatientBUS() { }
        public List<PatientDTO> GetListPatient()
        {
            List<PatientDTO> listPatient = new List<PatientDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BENHNHAN");
            foreach (DataRow item in data.Rows)
            {
                PatientDTO patient = new PatientDTO(item);
                listPatient.Add(patient);
            }
            return listPatient;
        }
        public string GetNamePatientByMedicalBillID(int id)
        {
            string query = string.Format("Select HoTenBN from BENHNHAN bn join PHIEUKHAM pk on pk.MaBn=bn.MaBn where MaPK={0}", id);

            if (DataProvider.Instance.ExecuteScalar(query) != DBNull.Value)
            {
                return (string)DataProvider.Instance.ExecuteScalar(query);
            }
            return "";
        }
        public List<PatientDTO> GetPatientByID(int id)
        {
            List<PatientDTO> listPatient = new List<PatientDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BENHNHAN where MaBN="+ id);
            foreach (DataRow item in data.Rows)
            {
                PatientDTO patient = new PatientDTO(item);
                listPatient.Add(patient);
            }
            return listPatient;
        }

        public int GetIDPatientByMedicalBillID(int id)
        {
            string query = string.Format("Select MaBN from PHIEUKHAM where MaPK={0}", id);

            if (DataProvider.Instance.ExecuteScalar(query) != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            return -1;
        }
        public void LoadPatient(DataGridView dtgvPatient, BindingSource PatientBinding)
        {
            PatientBinding.DataSource = GetListPatient(); // dùng custombiding để khi load lại không bị lỗi
            dtgvPatient.DataSource = PatientBinding;
            //dtgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgvPatient.Columns[dtgvPatient.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgvPatient.Columns[0].HeaderText = "Mã Bệnh nhân";
            dtgvPatient.Columns[1].HeaderText = "Chứng minh nhân dân";
            dtgvPatient.Columns[2].HeaderText = "Họ và tên";
            dtgvPatient.Columns[3].HeaderText = "Ngày sinh";
            dtgvPatient.Columns[4].HeaderText = "Giới tính";
            dtgvPatient.Columns[5].HeaderText = "Số điện thoại";
            dtgvPatient.Columns[6].HeaderText = "Địa chỉ";
            dtgvPatient.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; // chỉnh format hiển thị ngày thành dd/mm
            foreach (DataGridViewColumn col in dtgvPatient.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        public void LoadPatientByID(int id, DataGridView dgtv)
        {
            string query = string.Format("select MaBN,HoTenBN from BENHNHAN where MaBN={0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dgtv.DataSource = data;
            dgtv.Columns[0].HeaderText = "Mã bệnh nhân";
            dgtv.Columns[1].HeaderText = "Tên bệnh nhân";
            foreach (DataGridViewColumn col in dgtv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }

        #region CRUD

        public bool InsertPatient(string idCard, string name, DateTime DOB, string sex, string phone, string address)
        {
            string query = string.Format("insert into BENHNHAN (CMND,HoTenBN,NgaySinhBN,GioiTinhBN,DienThoaiBN,DiaChiBN )VALUES ( N'{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}')", idCard, name, DOB, sex, phone, address);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePatient(int id, string idCard, string name, DateTime DOB, string sex, string phone, string address)
        {
            string query = string.Format("update BENHNHAN set CMND = N'{0}', HoTenBN= N'{1}', NgaySinhBN=N'{2}', GioiTinhBN=N'{3}', DienThoaiBN=N'{4}', DiaChiBN=N'{5}' where MaBN={6}", idCard, name, DOB, sex, phone, address, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePatient(int id)
        {
            string query = string.Format("delete from BENHNHAN where MaBN={0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void SearchListPatientByName(string name, BindingSource PatientBinding)
        {
            List<PatientDTO> listPatient = new List<PatientDTO>();
            string query = string.Format("select * from BENHNHAN where dbo.GetUnsignString(HoTenBN) like '%' + dbo.GetUnsignString(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PatientDTO patient = new PatientDTO(item);
                listPatient.Add(patient);
            }
            PatientBinding.DataSource = listPatient;
        }
        public void SearchListPatientByIDCard(string id, BindingSource PatientBinding)
        {
            List<PatientDTO> listPatient = new List<PatientDTO>();
            string query = string.Format("select * from BENHNHAN where dbo.GetUnsignString(CMND) like '%' + dbo.GetUnsignString(N'{0}')+'%'", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PatientDTO patient = new PatientDTO(item);
                listPatient.Add(patient);
            }
            PatientBinding.DataSource = listPatient;
        }
        #endregion
        public bool isExist(string idCard)
        {
            string query = string.Format("select * from benhnhan where CMND= N'{0}'", idCard);
            int? result = (int?)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;

        }
        public int GetMaxIDPatient()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaBN) from Benhnhan") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaBN) from Benhnhan");
            }
            return 0;
        }

    }
}

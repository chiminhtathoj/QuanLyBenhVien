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
    public class DoctorBUS
    {
        private static DoctorBUS instance;

        public static DoctorBUS Instance
        {
            get { if (instance == null) instance = new DoctorBUS(); return instance; }
            set => instance = value;
        }
        private DoctorBUS() { }
        public List<DoctorDTO> GetListDoctor()
        {
            List<DoctorDTO> listDoctor = new List<DoctorDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BACSI bs join KHOA k on bs.MaKhoa=k.MaKhoa");
            foreach (DataRow item in data.Rows)
            {
                DoctorDTO patient = new DoctorDTO(item);
                listDoctor.Add(patient);
            }
            return listDoctor;
        }
        
        public void LoadDoctor(DataGridView dtgvDoctor, BindingSource Doctorbinding)
        {
            Doctorbinding.DataSource = GetListDoctor(); // dùng custombiding để khi load lại không bị lỗi
            dtgvDoctor.DataSource = Doctorbinding;
            //dtgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgvPatient.Columns[dtgvPatient.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgvDoctor.Columns[0].HeaderText = "Mã bác sĩ";
            dtgvDoctor.Columns[1].HeaderText = "Chứng minh nhân dân";
            dtgvDoctor.Columns[2].HeaderText = "Họ và tên";
            dtgvDoctor.Columns[3].HeaderText = "Ngày sinh";
            dtgvDoctor.Columns[4].HeaderText = "Giới tính";
            dtgvDoctor.Columns[5].HeaderText = "Số điện thoại";
            dtgvDoctor.Columns[6].HeaderText = "Địa chỉ";
            dtgvDoctor.Columns[7].HeaderText = "Mã khoa";
            dtgvDoctor.Columns[8].HeaderText = "Tên khoa";
            dtgvDoctor.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; // chỉnh format hiển thị ngày thành dd/mm
            foreach (DataGridViewColumn col in dtgvDoctor.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        public int GetIDDoctorByMedicalBillID(int id)
        {
            string query = string.Format("Select MaBS from PHIEUKHAM where MaPK={0}", id);

            if (DataProvider.Instance.ExecuteScalar(query) != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            return -1;
        }

        #region CRUD
        public bool InsertDoctor(string idCard, string name, DateTime DOB, string sex, string phone, string address,int makhoa)
        {
            string query = string.Format("insert into BACSI (CMND,HoTenBS,NgaySinhBS,GioiTinhBS,DienThoaiBS,DiaChiBS,MaKhoa )VALUES ( N'{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', N'{6}')", idCard, name, DOB, sex, phone, address,makhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDoctor(int id, string idCard, string name, DateTime DOB, string sex, string phone, string address,int makhoa)
        {
            string query = string.Format("update BACSI set CMND = N'{0}', HoTenBS= N'{1}', NgaySinhBS=N'{2}', GioiTinhBS=N'{3}', DienThoaiBS=N'{4}', DiaChiBS=N'{5}', MaKhoa={6} where MaBS={7}", idCard, name, DOB, sex, phone, address, makhoa, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void SearchListDoctorByName(string name,BindingSource DoctorBinding)
        {
            List<DoctorDTO> listDoctor = new List<DoctorDTO>();
            string query = string.Format("select * from BACSI bs join KHOA k on bs.MaKhoa=k.MaKhoa where dbo.GetUnsignString(HoTenBS) like '%' + dbo.GetUnsignString(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DoctorDTO patient = new DoctorDTO(item);
                listDoctor.Add(patient);
            }
            DoctorBinding.DataSource= listDoctor;
        }
        public void SearchListDoctorByFaculty(string name, BindingSource DoctorBinding)
        {
            List<DoctorDTO> listDoctor = new List<DoctorDTO>();
            string query = string.Format("select * from BACSI bs join KHOA k on bs.MaKhoa=k.MaKhoa where dbo.GetUnsignString(k.TenKhoa) like '%' + dbo.GetUnsignString(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DoctorDTO patient = new DoctorDTO(item);
                listDoctor.Add(patient);
            }
            DoctorBinding.DataSource = listDoctor;
        }
        #endregion

    }
}


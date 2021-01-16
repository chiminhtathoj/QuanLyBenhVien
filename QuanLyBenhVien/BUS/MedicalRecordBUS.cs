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
    public class MedicalRecordBUS
    {
        private static MedicalRecordBUS instance;

        public static MedicalRecordBUS Instance
        {
            get { if (instance == null) instance = new MedicalRecordBUS(); return instance; }
            private set => instance = value;
        }
        private MedicalRecordBUS()
        {

        }
        public List<MedicalRecordDTO> GetListMedicineRecord()
        {
            List<MedicalRecordDTO> list = new List<MedicalRecordDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BENHAN");
            foreach (DataRow item in data.Rows)
            {
                MedicalRecordDTO ITEM_DTO = new MedicalRecordDTO(item);
                list.Add(ITEM_DTO);
            }
            return list;
        }
        public void LoadMedicineRecord(DataGridView dtgv, BindingSource binding)
        {
            binding.DataSource = GetListMedicineRecord(); // dùng custombiding để khi load lại không bị lỗi
            dtgv.DataSource = binding;
            //dtgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgvPatient.Columns[dtgvPatient.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgv.Columns[0].HeaderText = "Mã bệnh án";
            dtgv.Columns[1].HeaderText = "Mã bệnh nhân";
            dtgv.Columns[2].HeaderText = "Tình trạng trước khi nhập viện";
            dtgv.Columns[3].HeaderText = "Tình trạng sau khi nhập viện";
            foreach (DataGridViewColumn col in dtgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        public bool UpdateMedicalRecord(int id,string statusPre, string statusAfter)
        {
            string query = string.Format("update BENHAN set TINHTRANGTRUOCNHAPVIEN = N'{0}', TINHTRANGSAUNHAPVIEN= N'{1}' where MABA={2}", statusPre, statusAfter, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertMedicalRecord(int idPatient,string statusPre, string statusAfter)
        {
            string query = string.Format("insert into BENHAN (MaBN,TinhTrangTruocNhapVien,TinhTrangSauNhapVien)VALUES ( N'{0}', N'{1}', N'{2}')", idPatient, statusPre, statusAfter);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertMedicalRecord(int idPatient, string statusPre)
        {
            string query = string.Format("insert into BENHAN (MaBN,TinhTrangTruocNhapVien,TinhTrangSauNhapVien)VALUES ( N'{0}', N'{1}', N'{2}')", idPatient, statusPre, DBNull.Value);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

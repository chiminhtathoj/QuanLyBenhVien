using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

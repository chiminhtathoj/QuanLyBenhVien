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
    public class MedicalBillBUS
    {

        private static MedicalBillBUS instance;

        public static MedicalBillBUS Instance
        {
            get { if (instance == null) instance = new MedicalBillBUS(); return instance; }
            set => instance = value;
        }
        private MedicalBillBUS() { }
        public void GetMedicalBillByMedicalBillID(int id,DataGridView dtgvMedicalBill)
        {
            List<MedicalBillDTO> ListMedicalBill = new List<MedicalBillDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHIEUKHAM where MaPK=" + id);
            foreach (DataRow item in data.Rows)
            {
                MedicalBillDTO medicalBill = new MedicalBillDTO(item);
                ListMedicalBill.Add(medicalBill);
            }
            dtgvMedicalBill.DataSource= ListMedicalBill;
        }
        public bool InsertMedicalBill(int idDoctor,int idPatient,DateTime dateexamination,string sympton,int insurance)
        {
            string query = string.Format("insert into PHIEUKHAM (MaBS,MaBN,NgayKham,TrieuChung,BHYT) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", idDoctor, idPatient, dateexamination, sympton, insurance);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaxIDMedicalBill()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaPK) from PHIEUKHAM") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaPK) from PHIEUKHAM");
            }
            return 0;
        }
    }
}

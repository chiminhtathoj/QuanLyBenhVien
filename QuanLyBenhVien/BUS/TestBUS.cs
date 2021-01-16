using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TestBUS
    {
        private static TestBUS instance;

        public static TestBUS Instance
        {
            get { if (instance == null) instance = new TestBUS(); return instance; }
            private set => instance = value;
        }
        private TestBUS()
        {
            
        }
        public bool InsertTest(int idPatient,int idMedicalBill)
        {
            string query = string.Format("insert into XETNGHIEM (MaBN,MaPK)VALUES ( N'{0}',N'{1}')", idPatient, idMedicalBill);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaxIDTest()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaXN) from XETNGHIEM") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaXN) from XETNGHIEM");
            }
            return 0;
        }
        public void GetTestByTestID(int id, DataGridView dgtv)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("select xn.maxn,bn.HoTenBN from XETNGHIEM xn join BENHNHAN bn on xn.MaBN=bn.mabn where MaXN=" + id);
            dgtv.DataSource = data;
            dgtv.Columns[0].HeaderText = "Mã xét nghiệm";
            dgtv.Columns[1].HeaderText = "Tên bệnh nhân";
            foreach (DataGridViewColumn col in dgtv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        public bool isMedicalBillExist(int idMedicalBill)
        {
            string query = string.Format("select count(*) from XETNGHIEM where MAPK= N'{0}'", idMedicalBill);
            int check = (int)DataProvider.Instance.ExecuteScalar(query);
            if (check>0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}

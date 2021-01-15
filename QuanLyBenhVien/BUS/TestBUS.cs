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
        public bool InsertTest(int idPatient)
        {
            string query = string.Format("insert into XETNGHIEM (MaBN)VALUES ( N'{0}')",idPatient);
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

            DataTable data = DataProvider.Instance.ExecuteQuery("select xn.maxn,bn.HoTenBN from XETNGHIEM xn join BENHNHAN bn on xn.maxn=bn.mabn where MaXN=" + id);
            dgtv.DataSource = data;
            dgtv.Columns[0].HeaderText = "Mã xét nghiệm";
            dgtv.Columns[1].HeaderText = "Tên bệnh nhân";
            foreach (DataGridViewColumn col in dgtv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }

    }
}

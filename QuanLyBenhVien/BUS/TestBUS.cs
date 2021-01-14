using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

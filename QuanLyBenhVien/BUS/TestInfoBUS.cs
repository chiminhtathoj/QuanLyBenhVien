using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TestInfoBUS
    {
        private static TestInfoBUS instance;

        public static TestInfoBUS Instance
        {
            get { if (instance == null) instance = new TestInfoBUS(); return instance; }
            private set => instance = value;
        }
        private TestInfoBUS()
        {

        }
        public bool InsertTestInfo(int idTest, int idService, DateTime DateTest, string Request)
        {
            string query = string.Format("insert into CT_XETNGHIEM (maxn,madv,ngayxetnghiem,yeucauxetnghiem) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}')", idTest, idService, DateTest, Request);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

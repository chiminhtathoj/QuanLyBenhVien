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
        public void GetListTestInfoByTestID(int id, DataGridView dgtv)
        {
            List<TestInfoDTO> LIST = new List<TestInfoDTO>();
            string query = string.Format("select * from CT_XETNGHIEM where MaXN={0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TestInfoDTO ITEM1 = new TestInfoDTO(item);
                LIST.Add(ITEM1);
            }
            dgtv.DataSource = LIST;
        }
        public bool InsertTestInfo(int idTest, int? idService, DateTime DateTest, string Request)
        {
            string query = string.Format("insert into CT_XETNGHIEM (maxn,madv,ngayxetnghiem,yeucauxetnghiem) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}')", idTest, idService, DateTest, Request);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertTestInfo(int idTest, DateTime DateTest, string Request) // nếu không có dịch vụ thì gán nó bằng 0
        {
            string query = string.Format("insert into CT_XETNGHIEM (maxn,madv,ngayxetnghiem,yeucauxetnghiem) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}')", idTest, DBNull.Value, DateTest, Request);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertListTestInfofromLV(System.Windows.Forms.ListView lv,DateTime datetest,RichTextBox txt)
        {
            int idTest = TestBUS.Instance.GetMaxIDTest();
            if (lv.Items.Count != 0)
            {
                foreach (var item in ServiceBUS.Instance.listServiceGB)
                {
                    InsertTestInfo(idTest, item.MaDV, datetest, txt.Text);
                }
                return true;
            }
            else
            {
                InsertTestInfo(idTest, datetest, txt.Text);
                return true;
            }
        }
    }
}

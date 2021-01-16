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
    public class ResultDiagnoseBUS
    {
        private static ResultDiagnoseBUS instance;

        public static ResultDiagnoseBUS Instance
        {
            get { if (instance == null) instance = new ResultDiagnoseBUS(); return instance; }
            private set => instance = value;
        }
        private ResultDiagnoseBUS()
        {

        }
        public bool InsertResultDiagnose(int idTest, DateTime dateResult, string Content, string DOT)
        {
            string query = string.Format("insert into KETQUA (MAXN,NgayLAPKETQUA,NOIDUNG,HUONGDIEUTRI) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}')", idTest, dateResult, Content, DOT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaxIDResulDiagnose()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaKQ) from Ketqua") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaKQ) from Ketqua");
            }
            return 0;
        }
        public int GetIDPatientByResultID(int id)
        {
            string query = string.Format("select xn.MaBN from KETQUA kq join XETNGHIEM xn on kq.MaXN= xn.MaXN where makq={0}", id);

            if (DataProvider.Instance.ExecuteScalar(query) != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            return -1;
        }
        public bool isTestExist(int idTest)
        {
            string query = string.Format("select count(*) from KETQUA where MaXN= N'{0}'", idTest);
            int check = (int)DataProvider.Instance.ExecuteScalar(query);
            if (check > 0)
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

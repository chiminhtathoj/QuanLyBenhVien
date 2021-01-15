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

    }
}

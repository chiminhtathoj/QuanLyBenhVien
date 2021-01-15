using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TransferBUS
    {
        private static TransferBUS instance;

        public static TransferBUS Instance
        {
            get { if (instance == null) instance = new TransferBUS(); return instance; }
            private set => instance = value;
        }
        private TransferBUS()
        {

        }
        public bool InsertTransfer(int idPatient,string reason, string statusPre)
        {
            string query = string.Format("insert into CHUYENVIEN (MaBN,LYDOchuyenvien,tinhtrangtruockhichuyen)VALUES ( N'{0}', N'{1}', N'{2}')", idPatient, reason, statusPre);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

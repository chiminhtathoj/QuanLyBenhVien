using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public static BillInfoBUS Instance
        {
            get { if (instance == null) instance = new BillInfoBUS(); return instance; }
            set => instance = value;
        }
        private BillInfoBUS() { }
        public bool InsertBillInfo(int idBill,int idTest, int idPre)
        {
            string query = string.Format("insert into CT_HOADON (MAHD,MAXN,MADT)VALUES ( N'{0}', N'{1}', '{2}')", idBill, idTest, idPre);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertBillInfoWithoutPrescription(int idBill, int idTest)
        {
            string query = string.Format("insert into CT_HOADON (MAHD,MAXN)VALUES ( N'{0}', N'{1}')", idBill, idTest);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertBillInfoWithoutTest(int idBill, int idPrescrip)
        {
            string query = string.Format("insert into CT_HOADON (MAHD,MaDT)VALUES ( N'{0}', N'{1}')", idBill, idPrescrip);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaxIDBillInfo()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(macthd) from ct_HoaDon") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(macthd) from ct_HoaDon");
            }
            return 0;
        }
    }
}

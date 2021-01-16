using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return instance; }
            set => instance = value;
        }
        private BillBUS() { }
        public bool InsertBill(int idPatient,DateTime dategenerate,string status,double totalPrice)
        {
            string query = string.Format("insert into HOADON (MABN,NGAYLAP,TINHTRANG,TONGTIEN)VALUES ( N'{0}', N'{1}', N'{2}', N'{3}')", idPatient, dategenerate, status, totalPrice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable SearchBillNotPayByIDPatient(int id)
        {
            string query = string.Format("select * from HOADON where MaBN={0} and TINHTRANG=N'Chưa thanh toán'", id);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public double CalSumMoney(int id)
        {
            double sum = 0;
            List<BillDTO> list = new List<BillDTO>();
            string query = string.Format("select * from HOADON where MaBN={0} and TINHTRANG=N'Chưa thanh toán'", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillDTO ITEM_DTO = new BillDTO(item);
                list.Add(ITEM_DTO);
            }
            foreach (var item in list)
            {
                sum += item.TongTien;
            }
            return sum;
        }
        public int GetTypeInsuranceByIDMedicalBill(int id)
        {
            string query = string.Format("select BHYT from PHIEUKHAM where MaBN ={0}", id);

            if (DataProvider.Instance.ExecuteScalar(query) != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            return 0;
        }
        
        public bool UpdateBillPaid(int id)
        {
            string query = string.Format("update hoadon set TINHTRANG = N'Đã thanh toán' where MABN =N'{0}'", id);
            int result =DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
        public int GetMaxIDBill()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaHD) from HoaDon") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaHD) from HoaDon");
            }
            return 0;
        }
    }
}

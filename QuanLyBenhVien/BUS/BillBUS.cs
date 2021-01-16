﻿using DAO;
using System;
using System.Collections.Generic;
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

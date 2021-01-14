using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServiceDTO
    {
        public ServiceDTO(int madv,string tendv,double dongia)
        {
            this.MaDV = madv;
            this.TenDV = tendv;
            this.DonGia = dongia;
        }
        public ServiceDTO(DataRow row)
        {
            this.MaDV = (int)row["MaDV"];
            this.TenDV = row["TenDV"].ToString();
            this.DonGia = double.Parse((row["DonGia"].ToString()));
        }
        private int maDV;
        private string tenDV;
        private double donGia;

        public double DonGia { get => donGia; set => donGia = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public int MaDV { get => maDV; set => maDV = value; }
    }
}

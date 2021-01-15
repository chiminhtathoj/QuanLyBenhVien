using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MedicineDTO
    {
        public MedicineDTO(int maThuoc, string tenThuoc, string donVi, double donGia)/*int soluong,string huongdan*/
        {
            this.MaThuoc = maThuoc;
            this.DonVi = donVi;
            this.DonGia = donGia;
            this.TenThuoc = tenThuoc;
            //this.SoLuong = soLuong;
            //this.HuongDan = huongdan;
        }
        public MedicineDTO(DataRow row)
        {
            this.MaThuoc = (int)row["MaThuoc"];
            this.DonVi = row["DonVi"].ToString();
            this.DonGia = double.Parse((row["DonGia"].ToString()));
            this.TenThuoc = row["TenThuoc"].ToString();
        }
        int maThuoc;
        string tenThuoc;
        string donVi;
        double donGia;
        //int soLuong;
        //string huongDan;

        public int MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        //public int SoLuong { get => soLuong; set => soLuong = value; }
        //public string HuongDan { get => huongDan; set => huongDan = value; }
    }
}

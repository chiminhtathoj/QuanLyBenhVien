using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoctorDTO
    {
        public DoctorDTO(int maBN, string cMND, string hoTenBS, DateTime ngaySinhBS, string gioiTinhBS, string dienThoaiBS, string diaChiBS, int maKhoa,string tenKhoa)
        {
            this.MaBS = maBN;
            this.CMND = cMND;
            this.HoTenBS = hoTenBS;
            this.DienThoaiBS = dienThoaiBS;
            this.NgaySinhBS = ngaySinhBS;
            this.GioiTinhBS = gioiTinhBS;
            this.DiaChiBS = diaChiBS;
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
        }
        public DoctorDTO(DataRow row)
        {
            this.MaBS = (int)row["MaBS"];
            this.CMND = row["CMND"].ToString();
            this.HoTenBS = row["HoTenBS"].ToString();
            this.DienThoaiBS = row["DienThoaiBS"].ToString();
            this.NgaySinhBS = (row["NgaySinhBS"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgaySinhBS"]));
            this.GioiTinhBS = row["GioiTinhBS"].ToString();
            this.DiaChiBS = row["DiaChiBS"].ToString();
            this.MaKhoa = (int)row["MaKhoa"];
            this.TenKhoa = row["TenKhoa"].ToString();
        }
        private int maBS;
        private string cMND;
        private string hoTenBS;
        private DateTime ngaySinhBS;
        private string gioiTinhBS;
        private string dienThoaiBS;
        private string diaChiBS;
        private int maKhoa;
        private string tenKhoa;

        public int MaBS { get => maBS; set => maBS = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string HoTenBS { get => hoTenBS; set => hoTenBS = value; }
        public DateTime NgaySinhBS { get => ngaySinhBS; set => ngaySinhBS = value; }
        public string GioiTinhBS { get => gioiTinhBS; set => gioiTinhBS = value; }
        public string DienThoaiBS { get => dienThoaiBS; set => dienThoaiBS = value; }
        public string DiaChiBS { get => diaChiBS; set => diaChiBS = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
    }
}

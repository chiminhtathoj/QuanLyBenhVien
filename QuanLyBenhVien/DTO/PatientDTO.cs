using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientDTO
    {
        public PatientDTO(int maBN, string cMND, string hoTenBN, DateTime ngaySinhBN, string gioiTinhBN, string dienThoaiBN, string diaChiBN)
        {
            this.MaBN = maBN;
            this.CMND = cMND;
            this.HoTenBN = hoTenBN;
            this.DienThoaiBN = dienThoaiBN;
            this.NgaySinhBN = ngaySinhBN;
            this.GioiTinhBN = gioiTinhBN;
            this.DiaChiBN = diaChiBN;
        }
        public PatientDTO(DataRow row)
        {
            this.MaBN = (int)row["MaBN"];
            this.CMND = row["CMND"].ToString();
            this.HoTenBN = row["HoTenBN"].ToString();
            this.DienThoaiBN = row["DienThoaiBN"].ToString();
            this.NgaySinhBN = (row["NgaySinhBN"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgaySinhBN"]));
            this.GioiTinhBN = row["GioiTinhBN"].ToString();
            this.DiaChiBN = row["DiaChiBN"].ToString();
        }
        private int maBN;
        private string cMND;
        private string hoTenBN;
        private DateTime ngaySinhBN;
        private string gioiTinhBN;
        private string dienThoaiBN;
        private string diaChiBN;

        public int MaBN { get => maBN; set => maBN = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string HoTenBN { get => hoTenBN; set => hoTenBN = value; }
        public DateTime NgaySinhBN { get => ngaySinhBN; set => ngaySinhBN = value; }
        public string GioiTinhBN { get => gioiTinhBN; set => gioiTinhBN = value; }
        public string DienThoaiBN { get => dienThoaiBN; set => dienThoaiBN = value; }
        public string DiaChiBN { get => diaChiBN; set => diaChiBN = value; }
    }
}

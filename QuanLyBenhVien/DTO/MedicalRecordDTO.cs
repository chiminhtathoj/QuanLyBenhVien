using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MedicalRecordDTO
    {
        public MedicalRecordDTO(int maBA, int maBN, string tinhTrangTruocNhapVien, string tinhTrangSauNhapVien)
        {
            this.MaBA = maBA;
            this.MaBN = maBN;
            this.TinhTrangTruocNhapVien = tinhTrangTruocNhapVien;
            this.TinhTrangSauNhapVien = tinhTrangSauNhapVien;
        }
        public MedicalRecordDTO(DataRow row)
        {
            this.MaBA = (int)row["MaBA"];
            this.MaBN = (int)row["MaBN"];
            this.TinhTrangTruocNhapVien = row["TinhTrangTruocNhapVien"].ToString();
            this.TinhTrangSauNhapVien = row["TinhTrangSauNhapVien"].ToString();
        }
        int maBA;
        int maBN;
        string tinhTrangTruocNhapVien;
        string tinhTrangSauNhapVien;

        public int MaBA { get => maBA; set => maBA = value; }
        public int MaBN { get => maBN; set => maBN = value; }
        public string TinhTrangTruocNhapVien { get => tinhTrangTruocNhapVien; set => tinhTrangTruocNhapVien = value; }
        public string TinhTrangSauNhapVien { get => tinhTrangSauNhapVien; set => tinhTrangSauNhapVien = value; }
    }
}

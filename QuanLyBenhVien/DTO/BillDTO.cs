using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {

        private int maHD;
        private int maBN;
        private DateTime ngayLap;
        private string tinhTrang;
        private double tongTien;

        public BillDTO(int maHD, int maBN, DateTime ngayLap, string tinhTrang, double tongTien)
        {
            this.MaHD = maHD;
            this.MaBN = maBN;
            this.NgayLap = ngayLap;
            this.TinhTrang = tinhTrang;
            this.TongTien = tongTien;
        }
        public BillDTO(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.MaBN = (int)row["MaBN"];
            this.NgayLap = (row["NgaySinhBS"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayLap"]));
            this.TinhTrang = row["TinhTrang"].ToString();
            this.TongTien = double.Parse((row["TongTien"].ToString()));
        }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaBN { get => maBN; set => maBN = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}

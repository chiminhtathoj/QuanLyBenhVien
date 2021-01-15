using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResultDiagnoseDTO
    {
        public ResultDiagnoseDTO(int maKQ, int maXN, DateTime ngayLapKetQua, string noiDung, string huongDieuTri)
        {
            this.MaKQ = maKQ;
            this.MaXN = maXN;
            this.NgayLapKetQua = ngayLapKetQua;
            this.NoiDung = noiDung;
            this.HuongDieuTri = huongDieuTri;
        }
        public ResultDiagnoseDTO(DataRow row)
        {
            this.MaKQ = (int)row["MaKQ"];
            this.MaXN = (int)row["MaXN"];
            this.NgayLapKetQua = (row["NgayLapKetQua"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayLapKetQua"]));
            this.NoiDung = row["NoiDung"].ToString();
            this.HuongDieuTri = row["HuongDieuTri"].ToString();
        }
        private int maKQ;
        private int maXN;
        DateTime ngayLapKetQua;
        string noiDung;
        string huongDieuTri;

        public int MaKQ { get => maKQ; set => maKQ = value; }
        public int MaXN { get => maXN; set => maXN = value; }
        public DateTime NgayLapKetQua { get => ngayLapKetQua; set => ngayLapKetQua = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string HuongDieuTri { get => huongDieuTri; set => huongDieuTri = value; }
    }
}

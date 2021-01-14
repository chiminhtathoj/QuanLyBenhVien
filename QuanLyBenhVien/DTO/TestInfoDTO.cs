using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TestInfoDTO
    {
        public TestInfoDTO(int maCTXN, int maXN, int maDV, DateTime ngayXetNghiem, string yeuCauXetNghiem)
        {
            this.MaCTXN = maCTXN;
            this.MaXN = maXN;
            this.MaDV = maDV;
            this.NgayXetNghiem = ngayXetNghiem;
            this.YeuCauXetNghiem = yeuCauXetNghiem;
        }
        public TestInfoDTO(DataRow row)
        {
            this.MaCTXN = (int)row["MaCTXN"];
            this.MaXN = (int)row["MaXN"];
            this.MaDV = (int)row["MaDV"];
            this.NgayXetNghiem = (row["NgayXetNghiem"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayXetNghiem"]));
            this.YeuCauXetNghiem = row["YeuCauXetNghiem"].ToString();
        }
        private int maCTXN;
        private int maXN;
        private int maDV;
        private DateTime ngayXetNghiem;
        private string yeuCauXetNghiem;

        public int MaCTXN { get => maCTXN; set => maCTXN = value; }
        public int MaXN { get => maXN; set => maXN = value; }
        public int MaDV { get => maDV; set => maDV = value; }
        public DateTime NgayXetNghiem { get => ngayXetNghiem; set => ngayXetNghiem = value; }
        public string YeuCauXetNghiem { get => yeuCauXetNghiem; set => yeuCauXetNghiem = value; }
    }
}

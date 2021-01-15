using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PrintTestDTO
    {
        public PrintTestDTO(int maXN ,DateTime ngayXetNghiem, string yeuCauXetNghiem,string tenDV)
        {
            this.MaXN = maXN;
            this.NgayXetNghiem = ngayXetNghiem;
            this.YeuCauXetNghiem = yeuCauXetNghiem;
            this.TenDV = tenDV;
        }
        public PrintTestDTO(DataRow row)
        {
            this.MaXN = (int)row["MaXN"];
            this.NgayXetNghiem = (row["NgayXetNghiem"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayXetNghiem"]));
            this.YeuCauXetNghiem = row["YeuCauXetNghiem"].ToString();
            this.TenDV = row["TenDV"].ToString();
        }
        private int maXN;
        private DateTime ngayXetNghiem;
        private string yeuCauXetNghiem;
        private string tenDV;

        public int MaXN { get => maXN; set => maXN = value; }
        public DateTime NgayXetNghiem { get => ngayXetNghiem; set => ngayXetNghiem = value; }
        public string YeuCauXetNghiem { get => yeuCauXetNghiem; set => yeuCauXetNghiem = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
    }
}

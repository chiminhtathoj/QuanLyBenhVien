using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfoDTO
    {
        public BillInfoDTO(int maCTHD, int maHD, int maXN, int maDT)
        {
            this.MaCTHD = maCTHD;
            this.MaHD = maHD;
            this.MaXN = maXN;
            this.MaDT = maDT;
        }
        public BillInfoDTO(DataRow row)
        {
            this.MaCTHD = (int)row["MaCTHD"];
            this.MaHD = (int)row["MaHD"];
            this.MaXN = (int)row["MaXN"];
            this.MaDT = (int)row["MaDT"];
        }
        private int maCTHD;
        private int maHD;
        private int maXN;
        private int maDT;

        public int MaCTHD { get => maCTHD; set => maCTHD = value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaXN { get => maXN; set => maXN = value; }
        public int MaDT { get => maDT; set => maDT = value; }
    }
}

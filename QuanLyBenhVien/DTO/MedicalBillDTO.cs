using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MedicalBillDTO
    {
        public MedicalBillDTO(int maPK, int maBN, int maBS, DateTime ngayKham, string trieuChung, int bHYT)
        {
            this.MaPK = maPK;
            this.MaBN = maBN;
            this.MaBS = maBS;
            this.NgayKham = ngayKham;
            this.TrieuChung = trieuChung;
            this.BHYT = bHYT;
        }
        public MedicalBillDTO(DataRow row)
        {
            this.MaPK= (int)row["MaPK"];
            this.MaBN = (int)row["MaBN"];
            this.MaBS = (int)row["MaBS"];
            this.NgayKham = (row["NgayKham"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayKham"]));
            this.TrieuChung = row["TrieuChung"].ToString();
            this.BHYT = (int)row["BHYT"];
        }
        private int maPK;
        private int maBN;
        private int maBS;
        private DateTime ngayKham;
        private string trieuChung;
        private int bHYT;

        public int MaPK { get => maPK; set => maPK = value; }
        public int MaBN { get => maBN; set => maBN = value; }
        public int MaBS { get => maBS; set => maBS = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public int BHYT { get => bHYT; set => bHYT = value; }
    }
}

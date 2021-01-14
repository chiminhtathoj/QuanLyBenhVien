using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TestDTO
    {
        private int maXN;
        private int maBN;

        public TestDTO(int maXN,int maBN)
        {
            this.MaXN = maXN;
            this.MaBN = maBN;
        }
        public TestDTO(DataRow row)
        {
            this.MaXN = (int)row["MaXN"];
            this.MaBN = (int)row["MaBN"];
        }
        public int MaXN { get => maXN; set => maXN = value; }
        public int MaBN { get => maBN; set => maBN = value; }
    }
}

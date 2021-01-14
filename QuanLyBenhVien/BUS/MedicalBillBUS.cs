using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MedicalBillBUS
    {

        private static MedicalBillBUS instance;

        public static MedicalBillBUS Instance
        {
            get { if (instance == null) instance = new MedicalBillBUS(); return instance; }
            set => instance = value;
        }
        private MedicalBillBUS() { }
      
    }
}

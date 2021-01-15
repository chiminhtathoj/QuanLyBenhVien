using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PrintTestBUS
    {

        private static PrintTestBUS instance;

        public static PrintTestBUS Instance
        {
            get { if (instance == null) instance = new PrintTestBUS(); return instance; }
            private set => instance = value;
        }
        private PrintTestBUS()
        {

        }
    }
}

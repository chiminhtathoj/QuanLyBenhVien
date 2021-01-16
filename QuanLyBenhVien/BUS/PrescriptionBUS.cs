using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PrescriptionBUS
    {
        private static PrescriptionBUS instance;

        public static PrescriptionBUS Instance
        {
            get { if (instance == null) instance = new PrescriptionBUS(); return instance; }
            private set => instance = value;
        }
        private PrescriptionBUS()
        {

        }
        public void GetPatientByIDresult(int id, DataGridView dgtv)
        {
            string query = string.Format("select bn.MaBN,bn.hotenbn,bs.hotenbs from KETQUA kq join XETNGHIEM xn on kq.MaXN = xn.MaXN join BENHNHAN bn on bn.MaBN=xn.MaBN join PHIEUKHAM pk on pk.MaPK=xn.mapk join BACSI bs on pk.MaBS=bs.MaBS where kq.makq={0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dgtv.DataSource = data;
            dgtv.Columns[0].HeaderText = "Mã bệnh nhân";
            dgtv.Columns[1].HeaderText = "Tên bệnh nhân";
            dgtv.Columns[2].HeaderText = "Tên bác sĩ";
            foreach (DataGridViewColumn col in dgtv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
      
        public bool InsertPrescription(int idResult, DateTime generateDay)
        {
            string query = string.Format("insert into DONTHUOC (MaKQ,NGAYTAO)VALUES ( N'{0}',N'{1}')", idResult, generateDay);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
        public int GetMaxIDPrescription()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaDT) from Donthuoc") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaDT) from Donthuoc ");
            }
            return 0;
        }
        
        
        public bool isResultExist(int id)
        {
            string query = string.Format("select count(*) from DONTHUOC where MaKQ= N'{0}'", id);
            int check = (int)DataProvider.Instance.ExecuteScalar(query);
            if (check > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

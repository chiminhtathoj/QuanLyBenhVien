using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace BUS
{
    public class PrescriptionInfoBUS
    {
        private static PrescriptionInfoBUS instance;

        public static PrescriptionInfoBUS Instance
        {
            get { if (instance == null) instance = new PrescriptionInfoBUS(); return instance; }
            private set => instance = value;
        }
        private PrescriptionInfoBUS()
        {

        }
        public bool InsertPrescriptionInfo(int idMedicine,int idPrescription ,int count,string guide)
        {
            string query = string.Format("insert into CT_DONTHUOC (MaThuoc,MaDT,SoLuong,HuongDan)VALUES ( N'{0}',N'{1}',N'{2}',N'{3}')", idMedicine, idPrescription ,count, guide);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //public bool InsertListPrescriptionInfofromLV(System.Windows.Forms.ListView lv, TextBox txtAmount, RichTextBox txt)
        //{
        //    int amount = 0;
        //    int.TryParse(txtAmount.Text, out amount);
        //    int idPrescription = PrescriptionBUS.Instance.GetMaxIDPrescription();
        //    if (lv.Items.Count != 0)
        //    {
        //        foreach (var item in MedicineBUS.Instance.listMedicineGB)
        //        {
        //            InsertPrescriptionInfo(item.MaThuoc, idPrescription, amount, txt.Text);
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public void GetListPreInfoByPreID(int id, DataGridView dgtv)
        {
            string query = string.Format("select bn.HoTenBN,dt.MaDT,dt.NgayTao,t.TenThuoc,ct.SoLuong,ct.HuongDan from DONTHUOC dt join CT_DONTHUOC ct on dt.MaDT=ct.MADT join KETQUA kq on dt.MAKQ=kq.MaKQ join XETNGHIEM xn on xn.MaXN=kq.MaKQ join BENHNHAN bn on bn.MaBN=xn.MaBN join THUOC t on t.MaThuoc=ct.MaThuoc where ct.mactdt={0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dgtv.DataSource = data;
            dgtv.Columns[0].HeaderText = "Tên bệnh nhân";
            dgtv.Columns[1].HeaderText = "Mã đơn thuốc";
            dgtv.Columns[2].HeaderText = "Ngày tạo";
            dgtv.Columns[3].HeaderText = "Tên thuốc";
            dgtv.Columns[4].HeaderText = "Số lượng";
            dgtv.Columns[5].HeaderText = "Hướng dẫn";
            foreach (DataGridViewColumn col in dgtv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
    }
}

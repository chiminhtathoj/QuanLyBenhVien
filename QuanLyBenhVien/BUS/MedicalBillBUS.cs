using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<MedicalBillDTO> GetListMedicine()
        {
            List<MedicalBillDTO> list = new List<MedicalBillDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHIEUKHAM");
            foreach (DataRow item in data.Rows)
            {
                MedicalBillDTO ITEM_DTO = new MedicalBillDTO(item);
                list.Add(ITEM_DTO);
            }
            return list;
        }
        public void LoadMedicineBill(DataGridView dtgv, BindingSource binding)
        {
            binding.DataSource = GetListMedicine(); // dùng custombiding để khi load lại không bị lỗi
            dtgv.DataSource = binding;
            //dtgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgvPatient.Columns[dtgvPatient.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgv.Columns[0].HeaderText = "Mã phiếu khám";
            dtgv.Columns[1].HeaderText = "Mã bác sĩ";
            dtgv.Columns[2].HeaderText = "Mã bệnh nhân";
            dtgv.Columns[3].HeaderText = "Ngày khám";
            dtgv.Columns[4].HeaderText = "Triệu chứng";
            dtgv.Columns[5].HeaderText = "BHYT";
            foreach (DataGridViewColumn col in dtgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        public void GetMedicalBillByMedicalBillID(int id,DataGridView dtgvMedicalBill)
        {
            List<MedicalBillDTO> ListMedicalBill = new List<MedicalBillDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHIEUKHAM where MaPK=" + id);
            foreach (DataRow item in data.Rows)
            {
                MedicalBillDTO medicalBill = new MedicalBillDTO(item);
                ListMedicalBill.Add(medicalBill);
            }
            dtgvMedicalBill.DataSource= ListMedicalBill;
        }
        public bool InsertMedicalBill(int idDoctor,int idPatient,DateTime dateexamination,string sympton,int insurance)
        {
            string query = string.Format("insert into PHIEUKHAM (MaBS,MaBN,NgayKham,TrieuChung,BHYT) VALUES ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", idDoctor, idPatient, dateexamination, sympton, insurance);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateMedicalRecord(int id,DateTime dateexamination, string symton,int insurance)
        {
            string query = string.Format("update PHIEUKHAM set NGAYKHAM = N'{0}',TRIEUCHUNG= N'{1}',BHYT= N'{2}' where MAPK={3}", dateexamination, symton, insurance, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void SearchListMedicineBillByID(int ID, BindingSource binding)
        {
            List<MedicalBillDTO> list = new List<MedicalBillDTO>();
            string query = string.Format("select * from PHIEUKHAM where dbo.GetUnsignString(MAPK) like '%' + dbo.GetUnsignString(N'{0}')+'%'", ID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MedicalBillDTO ITEM_DTO = new MedicalBillDTO(item);
                list.Add(ITEM_DTO);
            }
            binding.DataSource = list;
        }
        public int GetMaxIDMedicalBill()
        {

            if (DataProvider.Instance.ExecuteScalar("select max(MaPK) from PHIEUKHAM") != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaPK) from PHIEUKHAM");
            }
            return 0;
        }
    }
}

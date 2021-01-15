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
    public class MedicineBUS
    {
        public List<MedicineDTO> listMedicineGB = new List<MedicineDTO>();
        private static MedicineBUS instance;

        public static MedicineBUS Instance
        {
            get { if (instance == null) instance = new MedicineBUS(); return instance; }
            private set => instance = value;
        }
        private MedicineBUS()
        {

        }
        public List<MedicineDTO> GetListMedicine()
        {
            List<MedicineDTO> list = new List<MedicineDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from THUOC");
            foreach (DataRow item in data.Rows)
            {
                MedicineDTO ITEM_DTO = new MedicineDTO(item);
                list.Add(ITEM_DTO);
            }
            return list;
        }
        public void LoadMedicine(DataGridView dtgv, BindingSource binding)
        {
            binding.DataSource = GetListMedicine(); // dùng custombiding để khi load lại không bị lỗi
            dtgv.DataSource = binding;
            //dtgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgvPatient.Columns[dtgvPatient.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgv.Columns[0].HeaderText = "Mã thuốc";
            dtgv.Columns[1].HeaderText = "Tên thuốc";
            dtgv.Columns[2].HeaderText = "Đơn vị";
            dtgv.Columns[3].HeaderText = "Đơn giá";
            foreach (DataGridViewColumn col in dtgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        public bool InsertMedicine(string namemedicine, string unit, double price)
        {
            string query = string.Format("insert into THUOC (TENTHUOC,DONVI,DONGIA)VALUES ( N'{0}', N'{1}', N'{2}')", namemedicine, unit, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateMedicine(int id, string namemedicine, string unit, double price)
        {
            string query = string.Format("update THUOC set TENTHUOC = N'{0}', DONVI= N'{1}', DONGIA=N'{2}' where MATHUOC={3}", namemedicine, unit, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteMedicine(int id)
        {
            string query = string.Format("delete from THUOC where MATHUOC={0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<MedicineDTO> GetMedicineByID(int id)
        {
            List<MedicineDTO> list = new List<MedicineDTO>();
            string query = string.Format("select * from thuoc where mathuoc=N'{0}'", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MedicineDTO ITEM_DTO = new MedicineDTO(item);
                list.Add(ITEM_DTO);
            }
            return list;
        }
        public void AddMedicineToListView(int id, System.Windows.Forms.ListView lv,TextBox txtAmong, RichTextBox rtbGuide)
        {
            List<MedicineDTO> list = GetMedicineByID(id);
            foreach (MedicineDTO item in list)
            {
                bool found = false;
                foreach (ListViewItem item1 in lv.Items) // nếu phòng đả có trong danh sách thì cho người dùng nhập lại
                {
                    if (item1.Text == item.MaThuoc.ToString())
                    {
                        found = true;
                        MessageBox.Show("Thuốc đả có trong dach sách!");
                        break;
                    }
                }
                if (!found)
                {
                    ListViewItem lvItem = new ListViewItem(item.MaThuoc.ToString());
                    lvItem.SubItems.Add(item.TenThuoc.ToString());
                    lvItem.SubItems.Add(item.DonVi.ToString());
                    lvItem.SubItems.Add(item.DonGia.ToString());
                    lvItem.SubItems.Add(txtAmong.Text);
                    lvItem.SubItems.Add(rtbGuide.Text);
                    lv.Items.Add(lvItem);
                    listMedicineGB.AddRange(list); // thêm vào GB
                }
            }
        }
        public void DeleteServiceFromLV(System.Windows.Forms.ListView lv)
        {
            for (int i = lv.Items.Count - 1; i >= 0; i--)
            {
                if (lv.Items[i].Selected)
                {
                    lv.Items[i].Remove();
                    listMedicineGB.RemoveAt(i); // xóa luôn trong listServiceGB
                }
            }
        }
        public void SearchListMedicineByName(string name, BindingSource binding)
        {
            List<MedicineDTO> list = new List<MedicineDTO>();
            string query = string.Format("select * from THUOC where dbo.GetUnsignString(TENTHUOC) like '%' + dbo.GetUnsignString(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MedicineDTO ITEM_DTO = new MedicineDTO(item);
                list.Add(ITEM_DTO);
            }
            binding.DataSource = list;
        }

    }
}

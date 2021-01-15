using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BUS
{
    public class ServiceBUS
    {

        private static ServiceBUS instance;

        public static ServiceBUS Instance
        {
            get { if (instance == null) instance = new ServiceBUS(); return instance; }
            set => instance = value;
        }
        public List<ServiceDTO> listServiceGB =new List<ServiceDTO>();
        public void LoadService(DataGridView dtgv, BindingSource binding)
        {
            binding.DataSource = GetListService(); // dùng custombiding để khi load lại không bị lỗi
            dtgv.DataSource = binding;
            //dtgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgvPatient.Columns[dtgvPatient.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgv.Columns[0].HeaderText = "Đơn giá";
            dtgv.Columns[1].HeaderText = "Tên dịch vụ";
            dtgv.Columns[2].HeaderText = "Mã Dịch Vụ";
            
            foreach (DataGridViewColumn col in dtgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        private ServiceBUS() { }
        public List<ServiceDTO> GetListService()
        {
            List<ServiceDTO> List = new List<ServiceDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DICHVU");
            foreach (DataRow item in data.Rows)
            {
                ServiceDTO ITEM = new ServiceDTO(item);
                List.Add(ITEM);
            }
            return List;
        }
        public bool InsertService(string nameservice, double price)
        {
            string query = string.Format("insert into dichvu (TenDV,DonGia)VALUES ( N'{0}', N'{1}')",nameservice,price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateService(int id, string nameservice, double price)
        {
            string query = string.Format("update dichvu set tendv = N'{0}', dongia= N'{1}'where madv={2}",nameservice,price,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteService(int id)
        {
            string query = string.Format("delete from dichvu where madv={0}",id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void SearchListServiceByName(string name, BindingSource binding)
        {
            List<ServiceDTO> LIST = new List<ServiceDTO>();
            string query = string.Format("select * from dichvu where dbo.GetUnsignString(name) like '%' + dbo.GetUnsignString(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ServiceDTO ITEM1 = new ServiceDTO(item);
                LIST.Add(ITEM1);
            }
            binding.DataSource = LIST;
        }
        public void LoadAllServiceToCBB(ComboBox cbb) // lấy toàn bộ tên dịch vụ lưu vào trong combobox
        {
            string query = string.Format("select TenDV from dichvu");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbb.Items.Add(item["TenDV"].ToString());
            }
        }
        public int GetIDServiceByName(string name)
        {
            string query = string.Format("select MaDV from DICHVU where TenDV=N'{0}'",name);
            if (DataProvider.Instance.ExecuteScalar(query) != DBNull.Value)
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            return -1;
        }
        public List<ServiceDTO> GetServiceByName(string name)
        {
            List<ServiceDTO> list = new List<ServiceDTO>();
            string query = string.Format("select * from DICHVU where TenDV=N'{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ServiceDTO ITEM_DTO = new ServiceDTO(item);
                list.Add(ITEM_DTO);
            }
            return list;
        }
        public void AddServiceToListView(string name, System.Windows.Forms.ListView lv)
        {
            List<ServiceDTO> listService = GetServiceByName(name);
            foreach (ServiceDTO item in listService)
            {
                bool found = false;
                foreach (ListViewItem item1 in lv.Items) // nếu phòng đả có trong danh sách thì cho người dùng nhập lại
                {
                    if (item1.Text == item.MaDV.ToString())
                    {
                        found = true;
                        MessageBox.Show("Dịch vụ đả có trong dach sách!");
                        break;
                    }
                }
                if (!found)
                {
                    ListViewItem lvItem = new ListViewItem(item.MaDV.ToString());
                    lvItem.SubItems.Add(item.TenDV.ToString());
                    lvItem.SubItems.Add(item.DonGia.ToString());
                    lv.Items.Add(lvItem);
                    listServiceGB.AddRange(listService); // thêm vào GB
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
                    listServiceGB.RemoveAt(i); // xóa luôn trong listServiceGB
                }
            }
        }
        
    }
}

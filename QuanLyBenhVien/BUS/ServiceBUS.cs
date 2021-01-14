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
    public class ServiceBUS
    {

        private static ServiceBUS instance;

        public static ServiceBUS Instance
        {
            get { if (instance == null) instance = new ServiceBUS(); return instance; }
            set => instance = value;
        }
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

    }
}

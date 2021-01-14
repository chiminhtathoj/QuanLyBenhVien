using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class frmExamination : Form
    {
        public frmExamination()
        {
            InitializeComponent();
            LoadAll();
        }
        void LoadAll()
        {
            ServiceBUS.Instance.LoadAllServiceToCBB(cbbNameService);
        }
        private void btnSearchMedicalByIDMedicalBill_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDMedicalBill.Text, out id);
            MedicalBillBUS.Instance.GetMedicalBillByMedicalBillID(id,dtgvExamination);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            ServiceBUS.Instance.AddServiceToListView(cbbNameService.Text, lvService);
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            ServiceBUS.Instance.DeleteServiceFromLV(lvService);
        }

        private void btnInsertTest_Click(object sender, EventArgs e)
        {

        }
    }
}

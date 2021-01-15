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
            MedicalBillBUS.Instance.GetMedicalBillByMedicalBillID(id, dtgvExamination);
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
            if (string.IsNullOrEmpty(txtIDMedicalBill.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu khám");
                return;
            }
            if(int.Parse(txtIDMedicalBill.Text)> MedicalBillBUS.Instance.GetMaxIDMedicalBill())
            {
                MessageBox.Show("Vui lòng chọn đúng mã phiếu khám");
                return;
            }
            int idMedicalBill = 0;
            int.TryParse(txtIDMedicalBill.Text, out idMedicalBill);
            int id =PatientBUS.Instance.GetIDPatientByMedicalBillID(idMedicalBill);
            if (TestBUS.Instance.InsertTest(id,DoctorBUS.Instance.GetIDDoctorByMedicalBillID(idMedicalBill))) // thêm phiếu xét nghiệm
            {
               if(TestInfoBUS.Instance.InsertListTestInfofromLV(lvService, dtpkDateMedicalExamination.Value, rtbResquestTest))//thêm list chi tiết phiếu xét nghiệm
                {
                    MessageBox.Show("Thêm phiếu xét nghiệm thành công");
                    //lập phiếu xét nghiệm
                    DGVPrinter printer = new DGVPrinter();
                    TestInfoBUS.Instance.GetListTestInfoByTestID(TestBUS.Instance.GetMaxIDTest(), dtgvPrintTest);
                    dtgvPrintTest.Columns[0].HeaderText = "Mã chi tiết xét nghiệm";
                    dtgvPrintTest.Columns[1].HeaderText = "Mã phiếu khám";
                    dtgvPrintTest.Columns[2].HeaderText = "Mã dịch vụ";
                    dtgvPrintTest.Columns[3].HeaderText = "Ngày xét nghiệm";
                    dtgvPrintTest.Columns[4].HeaderText = "yêu cầu xét nghiệm";
                    foreach (DataGridViewColumn col in dtgvPrintTest.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
                    }
                    printer.Title = " \r\n\r\r Phiếu xét nghiệm\r\n\r\n  ";
                    printer.SubTitle = "Tên bệnh nhân: " + PatientBUS.Instance.GetNamePatientByMedicalBillID(idMedicalBill) + "   Mã phiếu khám:  " + TestBUS.Instance.GetMaxIDTest();
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.PrintDataGridView(dtgvPrintTest);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}

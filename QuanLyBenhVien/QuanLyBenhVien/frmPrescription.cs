using System;
using BUS;
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
    public partial class frmPrescription : Form
    {
        BindingSource MedicineBinding = new BindingSource();
        public frmPrescription()
        {
            InitializeComponent();
            LoadAll();


        }
        void LoadAll()
        {
            int id = ResultDiagnoseBUS.Instance.GetMaxIDResulDiagnose();
            txtIDResult.Text = id.ToString();
            PrescriptionBUS.Instance.GetResultByIDPatient(id, dtgvPrescription);
            MedicineBUS.Instance.LoadMedicine(dtgvMedicine, MedicineBinding);
            AddMedicineBinding();
        }
        void AddMedicineBinding()
        {
            txtIDMedicine.DataBindings.Add(new Binding("text", dtgvMedicine.DataSource, "MATHUOC", true, DataSourceUpdateMode.Never));
            txtNameMedicine.DataBindings.Add(new Binding("text", dtgvMedicine.DataSource, "tenthuoc", true, DataSourceUpdateMode.Never));
            cbbUnitMedicine.DataBindings.Add(new Binding("text", dtgvMedicine.DataSource, "DonVi", true, DataSourceUpdateMode.Never));
            txtPriceMedicine.DataBindings.Add(new Binding("text", dtgvMedicine.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }
        private void btnSearchPaient_Click(object sender, EventArgs e)
        {


        }

        private void btnSearchMedicineByName_Click(object sender, EventArgs e)
        {
            MedicineBUS.Instance.SearchListMedicineByName(txtSearchMedicine.Text, MedicineBinding);
        }

        private void btnAddMedicine_Click(object sender, EventArgs e) //thêm thuốc vào danh sách
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng thuốc!");
                return;
            }
            if (string.IsNullOrEmpty(rtbGuide.Text))
            {
                MessageBox.Show("Vui lòng nhập hướng dẫn thuốc!");
                return;
            }
            int id = 0;
            int.TryParse(txtIDMedicine.Text, out id);
            MedicineBUS.Instance.AddMedicineToListView(id, lvMedicinePicked, txtAmount, rtbGuide);
        }

        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            MedicineBUS.Instance.DeleteServiceFromLV(lvMedicinePicked);
        }

        private void btnInsertTest_Click(object sender, EventArgs e)
        {
            if (lvMedicinePicked.Items.Count != 0)
            // nếu không có thuốc trong listview thì bảo người dùng nhập lại
            {
                int idResult = 0;
                int.TryParse(txtIDResult.Text, out idResult);
                DateTime Dategenerate = dtpkDateGenerate.Value;
                int Among = 0;
                int.TryParse(txtAmount.Text, out Among);
                int idMedicine = 0;

                if (PrescriptionBUS.Instance.InsertPrescription(idResult, Dategenerate))// thêm đơn thuốc
                {
                    for (int i = 0; i < lvMedicinePicked.Items.Count; i++)
                    {
                        int.TryParse( lvMedicinePicked.Items[i].SubItems[0].Text,out idMedicine);
                        int.TryParse(lvMedicinePicked.Items[i].SubItems[4].Text, out Among);
                        rtbGuide.Text = lvMedicinePicked.Items[i].SubItems[5].Text;
                        PrescriptionInfoBUS.Instance.InsertPrescriptionInfo(idMedicine,PrescriptionBUS.Instance.GetMaxIDPrescription(), Among, rtbGuide.Text);
                    }
                    //if (PrescriptionInfoBUS.Instance.InsertListPrescriptionInfofromLV(lvMedicinePicked, txtAmount, rtbGuide))//thêm list chi tiết phiếu xét nghiệm
                    //{

                    //    MessageBox.Show("Tạo hóa đơn thành công!");
                    //    //lập phiếu xét nghiệm
                    //    //DGVPrinter printer = new DGVPrinter();
                    //    //TestInfoBUS.Instance.GetListTestInfoByTestID(TestBUS.Instance.GetMaxIDTest(), dtgvPrintTest);
                    //    //dtgvPrintTest.Columns[0].HeaderText = "Mã chi tiết xét nghiệm";
                    //    //dtgvPrintTest.Columns[1].HeaderText = "Mã phiếu khám";
                    //    //dtgvPrintTest.Columns[2].HeaderText = "Mã dịch vụ";
                    //    //dtgvPrintTest.Columns[3].HeaderText = "Ngày xét nghiệm";
                    //    //dtgvPrintTest.Columns[4].HeaderText = "yêu cầu xét nghiệm";
                    //    //foreach (DataGridViewColumn col in dtgvPrintTest.Columns)
                    //    //{
                    //    //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
                    //    //}
                    //    //printer.Title = " \r\n\r\r Phiếu xét nghiệm\r\n\r\n  ";
                    //    //printer.SubTitle = "Tên bệnh nhân: " + PatientBUS.Instance.GetNamePatientByMedicalBillID(idResult) + "   Mã phiếu khám:  " + TestBUS.Instance.GetMaxIDTest();
                    //    //printer.PageNumbers = true;
                    //    //printer.PageNumberInHeader = false;
                    //    //printer.PorportionalColumns = true;
                    //    //printer.HeaderCellAlignment = StringAlignment.Near;
                    //    //printer.PrintDataGridView(dtgvPrintTest);
                    //    //this.Close();
                    //}
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuốc!");
            }

        }
    }
}


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
            PrescriptionBUS.Instance.GetPatientByIDresult(id, dtgvPrescription);
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
            if (string.IsNullOrEmpty(txtIDResult.Text))
            {
                MessageBox.Show("Vui lòng nhập mã kết quả!");
                return;
            }
            if (int.Parse(txtIDResult.Text)> ResultDiagnoseBUS.Instance.GetMaxIDResulDiagnose() || int.Parse(txtIDResult.Text)<1)
            {
                MessageBox.Show("Vui lòng nhập mã kết quả hợp lệ!");
                return;
            }
            if (PrescriptionBUS.Instance.isResultExist(int.Parse(txtIDResult.Text)))
            {
                MessageBox.Show("Bệnh nhân của mã kết quả này có đơn thuốc rồi!");
                return;
            }
            if (lvMedicinePicked.Items.Count != 0)
            // nếu không có thuốc trong listview thì bảo người dùng nhập lại
            {
                int idResult = 0;
                int.TryParse(txtIDResult.Text, out idResult);
                DateTime Dategenerate = dtpkDateGenerate.Value;
                int Among = 0;
                int.TryParse(txtAmount.Text, out Among);
                int idMedicine = 0;
                double sum = 0;
                double price = 0;

                if (PrescriptionBUS.Instance.InsertPrescription(idResult, Dategenerate))// thêm đơn thuốc
                {
                    for (int i = 0; i < lvMedicinePicked.Items.Count; i++) //duyệt vào từng phần tử trong lv rồi thêm chi tiết hóa đơn cho mỗi phần tử
                    {
                        sum += double.Parse(lvMedicinePicked.Items[i].SubItems[3].Text) * int.Parse(lvMedicinePicked.Items[i].SubItems[4].Text);
                    }

                    BillBUS.Instance.InsertBill(ResultDiagnoseBUS.Instance.GetIDPatientByResultID(idResult), Dategenerate, "Chưa thanh toán", sum);
                    for (int i = 0; i < lvMedicinePicked.Items.Count; i++) //duyệt vào từng phần tử trong lv rồi thêm chi tiết đơn thuốc cho mỗi phần tử
                    {
                        int.TryParse(lvMedicinePicked.Items[i].SubItems[0].Text, out idMedicine);
                        int.TryParse(lvMedicinePicked.Items[i].SubItems[4].Text, out Among);
                        rtbGuide.Text = lvMedicinePicked.Items[i].SubItems[5].Text;
                        PrescriptionInfoBUS.Instance.InsertPrescriptionInfo(idMedicine, PrescriptionBUS.Instance.GetMaxIDPrescription(), Among, rtbGuide.Text);
                        BillInfoBUS.Instance.InsertBillInfoWithoutTest(BillBUS.Instance.GetMaxIDBill(), PrescriptionBUS.Instance.GetMaxIDPrescription());
                    }
                    MessageBox.Show("Tạo đơn thuốc thành công!");
                    //In đơn thuốc
                    DGVPrinter printer = new DGVPrinter();
                    PrescriptionInfoBUS.Instance.GetListPreInfoByPreID(PrescriptionBUS.Instance.GetMaxIDPrescription(), dtgvPrintMedicine);
                    printer.Title = " \r\n\r\r Đơn thuốc\r\n\r\n  ";
                    //printer.SubTitle = "Tên bệnh nhân: " + PatientBUS.Instance.GetNamePatientByMedicalBillID(idResult) + "   Mã phiếu khám:  " + TestBUS.Instance.GetMaxIDTest();
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.PrintDataGridView(dtgvPrintMedicine);
                    this.Close();
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

        private void btnSearchPrescription_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDResult.Text, out id);
            PrescriptionBUS.Instance.GetPatientByIDresult(id, dtgvPrescription);
        }
    }
}


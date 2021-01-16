
namespace QuanLyBenhVien
{
    partial class frmPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDResult = new System.Windows.Forms.TextBox();
            this.dtgvPrescription = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbUnitMedicine = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtIDMedicine = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPriceMedicine = new System.Windows.Forms.TextBox();
            this.txtNameMedicine = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnSearchMedicineByName = new System.Windows.Forms.Button();
            this.txtSearchMedicine = new System.Windows.Forms.TextBox();
            this.dtgvMedicine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMedicinePicked = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.dtpkDateGenerate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsertTest = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbGuide = new System.Windows.Forms.RichTextBox();
            this.dtgvPrintMedicine = new System.Windows.Forms.DataGridView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchPrescription = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrescription)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrintMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Đơn thuốc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchPrescription);
            this.groupBox1.Controls.Add(this.txtIDResult);
            this.groupBox1.Controls.Add(this.dtgvPrescription);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(-5, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // txtIDResult
            // 
            this.txtIDResult.Location = new System.Drawing.Point(108, 19);
            this.txtIDResult.Name = "txtIDResult";
            this.txtIDResult.Size = new System.Drawing.Size(48, 20);
            this.txtIDResult.TabIndex = 15;
            // 
            // dtgvPrescription
            // 
            this.dtgvPrescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrescription.Location = new System.Drawing.Point(6, 45);
            this.dtgvPrescription.MultiSelect = false;
            this.dtgvPrescription.Name = "dtgvPrescription";
            this.dtgvPrescription.ReadOnly = true;
            this.dtgvPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPrescription.Size = new System.Drawing.Size(781, 57);
            this.dtgvPrescription.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mã kết quả:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvPrintMedicine);
            this.groupBox2.Controls.Add(this.rtbGuide);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.btnInsertTest);
            this.groupBox2.Controls.Add(this.dtpkDateGenerate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnDeleteMedicine);
            this.groupBox2.Controls.Add(this.lvMedicinePicked);
            this.groupBox2.Controls.Add(this.btnAddMedicine);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbUnitMedicine);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.txtIDMedicine);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtPriceMedicine);
            this.groupBox2.Controls.Add(this.txtNameMedicine);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.btnSearchMedicineByName);
            this.groupBox2.Controls.Add(this.txtSearchMedicine);
            this.groupBox2.Controls.Add(this.dtgvMedicine);
            this.groupBox2.Location = new System.Drawing.Point(1, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 424);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuốc";
            // 
            // cbbUnitMedicine
            // 
            this.cbbUnitMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnitMedicine.FormattingEnabled = true;
            this.cbbUnitMedicine.Items.AddRange(new object[] {
            "Chai",
            "Hộp",
            "Viên"});
            this.cbbUnitMedicine.Location = new System.Drawing.Point(191, 174);
            this.cbbUnitMedicine.Name = "cbbUnitMedicine";
            this.cbbUnitMedicine.Size = new System.Drawing.Size(174, 21);
            this.cbbUnitMedicine.TabIndex = 41;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(52, 177);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 19);
            this.label29.TabIndex = 40;
            this.label29.Text = "Đơn vị:";
            // 
            // txtIDMedicine
            // 
            this.txtIDMedicine.Location = new System.Drawing.Point(191, 72);
            this.txtIDMedicine.Name = "txtIDMedicine";
            this.txtIDMedicine.ReadOnly = true;
            this.txtIDMedicine.Size = new System.Drawing.Size(174, 20);
            this.txtIDMedicine.TabIndex = 39;
            this.txtIDMedicine.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(32, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 19);
            this.label25.TabIndex = 38;
            this.label25.Text = "Mã thuốc:";
            // 
            // txtPriceMedicine
            // 
            this.txtPriceMedicine.Location = new System.Drawing.Point(191, 138);
            this.txtPriceMedicine.Name = "txtPriceMedicine";
            this.txtPriceMedicine.ReadOnly = true;
            this.txtPriceMedicine.Size = new System.Drawing.Size(174, 20);
            this.txtPriceMedicine.TabIndex = 37;
            // 
            // txtNameMedicine
            // 
            this.txtNameMedicine.Location = new System.Drawing.Point(191, 107);
            this.txtNameMedicine.Name = "txtNameMedicine";
            this.txtNameMedicine.ReadOnly = true;
            this.txtNameMedicine.Size = new System.Drawing.Size(174, 20);
            this.txtNameMedicine.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(42, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 19);
            this.label26.TabIndex = 36;
            this.label26.Text = "Đơn giá:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 106);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 19);
            this.label27.TabIndex = 35;
            this.label27.Text = "Tên thuốc:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(101, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(170, 24);
            this.label28.TabIndex = 34;
            this.label28.Text = "Thông tin thuốc";
            // 
            // btnSearchMedicineByName
            // 
            this.btnSearchMedicineByName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMedicineByName.Location = new System.Drawing.Point(276, 19);
            this.btnSearchMedicineByName.Name = "btnSearchMedicineByName";
            this.btnSearchMedicineByName.Size = new System.Drawing.Size(89, 23);
            this.btnSearchMedicineByName.TabIndex = 32;
            this.btnSearchMedicineByName.Text = "Tìm kiếm";
            this.btnSearchMedicineByName.UseVisualStyleBackColor = true;
            this.btnSearchMedicineByName.Click += new System.EventHandler(this.btnSearchMedicineByName_Click);
            // 
            // txtSearchMedicine
            // 
            this.txtSearchMedicine.Location = new System.Drawing.Point(3, 20);
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.Size = new System.Drawing.Size(267, 20);
            this.txtSearchMedicine.TabIndex = 31;
            // 
            // dtgvMedicine
            // 
            this.dtgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicine.Location = new System.Drawing.Point(371, 20);
            this.dtgvMedicine.MultiSelect = false;
            this.dtgvMedicine.Name = "dtgvMedicine";
            this.dtgvMedicine.ReadOnly = true;
            this.dtgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMedicine.Size = new System.Drawing.Size(410, 176);
            this.dtgvMedicine.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Danh sách thuốc đả chọn";
            // 
            // lvMedicinePicked
            // 
            this.lvMedicinePicked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMedicinePicked.FullRowSelect = true;
            this.lvMedicinePicked.GridLines = true;
            this.lvMedicinePicked.HideSelection = false;
            this.lvMedicinePicked.Location = new System.Drawing.Point(0, 230);
            this.lvMedicinePicked.Name = "lvMedicinePicked";
            this.lvMedicinePicked.Size = new System.Drawing.Size(427, 194);
            this.lvMedicinePicked.TabIndex = 44;
            this.lvMedicinePicked.TabStop = false;
            this.lvMedicinePicked.UseCompatibleStateImageBehavior = false;
            this.lvMedicinePicked.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thuốc";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thuốc";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn giá";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn vị";
            // 
            // btnDeleteMedicine
            // 
            this.btnDeleteMedicine.Location = new System.Drawing.Point(593, 239);
            this.btnDeleteMedicine.Name = "btnDeleteMedicine";
            this.btnDeleteMedicine.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteMedicine.TabIndex = 46;
            this.btnDeleteMedicine.Text = "Xóa thuốc đả chọn";
            this.btnDeleteMedicine.UseVisualStyleBackColor = true;
            this.btnDeleteMedicine.Click += new System.EventHandler(this.btnDeleteMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(432, 239);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(129, 23);
            this.btnAddMedicine.TabIndex = 45;
            this.btnAddMedicine.Text = "Thêm thuốc vào danh sách";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // dtpkDateGenerate
            // 
            this.dtpkDateGenerate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateGenerate.Location = new System.Drawing.Point(547, 282);
            this.dtpkDateGenerate.Name = "dtpkDateGenerate";
            this.dtpkDateGenerate.Size = new System.Drawing.Size(88, 20);
            this.dtpkDateGenerate.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Ngày Lập đơn thuốc:";
            // 
            // btnInsertTest
            // 
            this.btnInsertTest.Location = new System.Drawing.Point(697, 362);
            this.btnInsertTest.Name = "btnInsertTest";
            this.btnInsertTest.Size = new System.Drawing.Size(90, 54);
            this.btnInsertTest.TabIndex = 49;
            this.btnInsertTest.Text = "Lập đơn thuốc";
            this.btnInsertTest.UseVisualStyleBackColor = true;
            this.btnInsertTest.Click += new System.EventHandler(this.btnInsertTest_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(547, 308);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(88, 20);
            this.txtAmount.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Số lượng thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Hướng dẫn uống:";
            // 
            // rtbGuide
            // 
            this.rtbGuide.Location = new System.Drawing.Point(548, 339);
            this.rtbGuide.Name = "rtbGuide";
            this.rtbGuide.Size = new System.Drawing.Size(143, 79);
            this.rtbGuide.TabIndex = 54;
            this.rtbGuide.Text = "";
            // 
            // dtgvPrintMedicine
            // 
            this.dtgvPrintMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrintMedicine.Location = new System.Drawing.Point(462, 377);
            this.dtgvPrintMedicine.Name = "dtgvPrintMedicine";
            this.dtgvPrintMedicine.Size = new System.Drawing.Size(50, 39);
            this.dtgvPrintMedicine.TabIndex = 55;
            this.dtgvPrintMedicine.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hướng dẫn";
            this.columnHeader5.Width = 77;
            // 
            // btnSearchPrescription
            // 
            this.btnSearchPrescription.Location = new System.Drawing.Point(162, 16);
            this.btnSearchPrescription.Name = "btnSearchPrescription";
            this.btnSearchPrescription.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPrescription.TabIndex = 17;
            this.btnSearchPrescription.Text = "Tìm kiếm";
            this.btnSearchPrescription.UseVisualStyleBackColor = true;
            this.btnSearchPrescription.Click += new System.EventHandler(this.btnSearchPrescription_Click);
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "frmPrescription";
            this.Text = "Đơn thuốc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrescription)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrintMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDResult;
        private System.Windows.Forms.DataGridView dtgvPrescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbUnitMedicine;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtIDMedicine;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPriceMedicine;
        private System.Windows.Forms.TextBox txtNameMedicine;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnSearchMedicineByName;
        private System.Windows.Forms.TextBox txtSearchMedicine;
        private System.Windows.Forms.DataGridView dtgvMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMedicinePicked;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDeleteMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DateTimePicker dtpkDateGenerate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInsertTest;
        private System.Windows.Forms.RichTextBox rtbGuide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dtgvPrintMedicine;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSearchPrescription;
    }
}
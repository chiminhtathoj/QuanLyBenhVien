﻿
namespace QuanLyBenhVien
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khamBênhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kêtQuaChânĐoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchPatientByName = new System.Windows.Forms.Button();
            this.btnSearchPatientByIDCard = new System.Windows.Forms.Button();
            this.txtIDMedicalBill = new System.Windows.Forms.TextBox();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDCardPatient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhonePatient = new System.Windows.Forms.TextBox();
            this.cbbSexPatient = new System.Windows.Forms.ComboBox();
            this.txtAddressPatient = new System.Windows.Forms.TextBox();
            this.txtNamePatient = new System.Windows.Forms.TextBox();
            this.dtpkDOBPatient = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpkDateMedicalExamination = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbTypeInsurance = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIsInsurance = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchDoctorByName = new System.Windows.Forms.Button();
            this.dtgvDoctor = new System.Windows.Forms.DataGridView();
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIDDoctor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNameDoctor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInsertMedicalBill = new System.Windows.Forms.Button();
            this.dtgvMedicalBill = new System.Windows.Forms.DataGridView();
            this.khamBênhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.khamBênhToolStripMenuItem1,
            this.kêtQuaChânĐoanToolStripMenuItem,
            this.thanhToanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTaiKhoanToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.taiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTaiKhoanToolStripMenuItem_Click);
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuâtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.adminToolStripMenuItem.Text = "Quản Lý";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // khamBênhToolStripMenuItem1
            // 
            this.khamBênhToolStripMenuItem1.Name = "khamBênhToolStripMenuItem1";
            this.khamBênhToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.khamBênhToolStripMenuItem1.Text = "Khám bệnh";
            this.khamBênhToolStripMenuItem1.Click += new System.EventHandler(this.khamBênhToolStripMenuItem1_Click);
            // 
            // kêtQuaChânĐoanToolStripMenuItem
            // 
            this.kêtQuaChânĐoanToolStripMenuItem.Name = "kêtQuaChânĐoanToolStripMenuItem";
            this.kêtQuaChânĐoanToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.kêtQuaChânĐoanToolStripMenuItem.Text = "Kết quả chẩn đoán";
            this.kêtQuaChânĐoanToolStripMenuItem.Click += new System.EventHandler(this.kêtQuaChânĐoanToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(269, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Đăng ký khám chữa bệnh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDPatient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchPatientByName);
            this.groupBox1.Controls.Add(this.btnSearchPatientByIDCard);
            this.groupBox1.Controls.Add(this.txtIDMedicalBill);
            this.groupBox1.Controls.Add(this.dtgvPatient);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtIDCardPatient);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPhonePatient);
            this.groupBox1.Controls.Add(this.cbbSexPatient);
            this.groupBox1.Controls.Add(this.txtAddressPatient);
            this.groupBox1.Controls.Add(this.txtNamePatient);
            this.groupBox1.Controls.Add(this.dtpkDOBPatient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // txtIDPatient
            // 
            this.txtIDPatient.Location = new System.Drawing.Point(104, 18);
            this.txtIDPatient.Name = "txtIDPatient";
            this.txtIDPatient.ReadOnly = true;
            this.txtIDPatient.Size = new System.Drawing.Size(48, 20);
            this.txtIDPatient.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã bệnh nhân:";
            // 
            // btnSearchPatientByName
            // 
            this.btnSearchPatientByName.Location = new System.Drawing.Point(542, 18);
            this.btnSearchPatientByName.Name = "btnSearchPatientByName";
            this.btnSearchPatientByName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatientByName.TabIndex = 18;
            this.btnSearchPatientByName.Text = "Tìm kiếm";
            this.btnSearchPatientByName.UseVisualStyleBackColor = true;
            this.btnSearchPatientByName.Click += new System.EventHandler(this.btnSearchPatientByName_Click);
            // 
            // btnSearchPatientByIDCard
            // 
            this.btnSearchPatientByIDCard.Location = new System.Drawing.Point(542, 44);
            this.btnSearchPatientByIDCard.Name = "btnSearchPatientByIDCard";
            this.btnSearchPatientByIDCard.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatientByIDCard.TabIndex = 17;
            this.btnSearchPatientByIDCard.Text = "Tìm kiếm";
            this.btnSearchPatientByIDCard.UseVisualStyleBackColor = true;
            this.btnSearchPatientByIDCard.Click += new System.EventHandler(this.btnSearchPatientByIDCard_Click);
            // 
            // txtIDMedicalBill
            // 
            this.txtIDMedicalBill.Location = new System.Drawing.Point(104, 41);
            this.txtIDMedicalBill.Name = "txtIDMedicalBill";
            this.txtIDMedicalBill.ReadOnly = true;
            this.txtIDMedicalBill.Size = new System.Drawing.Size(48, 20);
            this.txtIDMedicalBill.TabIndex = 15;
            // 
            // dtgvPatient
            // 
            this.dtgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPatient.Location = new System.Drawing.Point(6, 131);
            this.dtgvPatient.MultiSelect = false;
            this.dtgvPatient.Name = "dtgvPatient";
            this.dtgvPatient.ReadOnly = true;
            this.dtgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPatient.Size = new System.Drawing.Size(840, 110);
            this.dtgvPatient.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mã phiếu khám:";
            // 
            // txtIDCardPatient
            // 
            this.txtIDCardPatient.Location = new System.Drawing.Point(405, 46);
            this.txtIDCardPatient.Name = "txtIDCardPatient";
            this.txtIDCardPatient.Size = new System.Drawing.Size(131, 20);
            this.txtIDCardPatient.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Chứng minh nhân dân:";
            // 
            // txtPhonePatient
            // 
            this.txtPhonePatient.Location = new System.Drawing.Point(405, 107);
            this.txtPhonePatient.Name = "txtPhonePatient";
            this.txtPhonePatient.Size = new System.Drawing.Size(131, 20);
            this.txtPhonePatient.TabIndex = 11;
            // 
            // cbbSexPatient
            // 
            this.cbbSexPatient.FormattingEnabled = true;
            this.cbbSexPatient.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSexPatient.Location = new System.Drawing.Point(104, 100);
            this.cbbSexPatient.Name = "cbbSexPatient";
            this.cbbSexPatient.Size = new System.Drawing.Size(48, 21);
            this.cbbSexPatient.TabIndex = 10;
            // 
            // txtAddressPatient
            // 
            this.txtAddressPatient.Location = new System.Drawing.Point(405, 77);
            this.txtAddressPatient.Name = "txtAddressPatient";
            this.txtAddressPatient.Size = new System.Drawing.Size(350, 20);
            this.txtAddressPatient.TabIndex = 9;
            // 
            // txtNamePatient
            // 
            this.txtNamePatient.Location = new System.Drawing.Point(405, 20);
            this.txtNamePatient.Name = "txtNamePatient";
            this.txtNamePatient.Size = new System.Drawing.Size(131, 20);
            this.txtNamePatient.TabIndex = 8;
            // 
            // dtpkDOBPatient
            // 
            this.dtpkDOBPatient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDOBPatient.Location = new System.Drawing.Point(104, 67);
            this.dtpkDOBPatient.Name = "dtpkDOBPatient";
            this.dtpkDOBPatient.Size = new System.Drawing.Size(88, 20);
            this.dtpkDOBPatient.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSymptom);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpkDateMedicalExamination);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbTypeInsurance);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbIsInsurance);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khám bệnh";
            // 
            // txtSymptom
            // 
            this.txtSymptom.Location = new System.Drawing.Point(405, 47);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.Size = new System.Drawing.Size(350, 20);
            this.txtSymptom.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Triệu chứng:";
            // 
            // dtpkDateMedicalExamination
            // 
            this.dtpkDateMedicalExamination.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateMedicalExamination.Location = new System.Drawing.Point(405, 16);
            this.dtpkDateMedicalExamination.Name = "dtpkDateMedicalExamination";
            this.dtpkDateMedicalExamination.Size = new System.Drawing.Size(88, 20);
            this.dtpkDateMedicalExamination.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ngày khám:";
            // 
            // cbbTypeInsurance
            // 
            this.cbbTypeInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeInsurance.Enabled = false;
            this.cbbTypeInsurance.FormattingEnabled = true;
            this.cbbTypeInsurance.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbTypeInsurance.Location = new System.Drawing.Point(107, 47);
            this.cbbTypeInsurance.Name = "cbbTypeInsurance";
            this.cbbTypeInsurance.Size = new System.Drawing.Size(48, 21);
            this.cbbTypeInsurance.TabIndex = 11;
            this.cbbTypeInsurance.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Loại bảo hiểm y tế:";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thẻ bảo hiểm y tế:";
            // 
            // cbIsInsurance
            // 
            this.cbIsInsurance.AutoSize = true;
            this.cbIsInsurance.Location = new System.Drawing.Point(107, 22);
            this.cbIsInsurance.Name = "cbIsInsurance";
            this.cbIsInsurance.Size = new System.Drawing.Size(39, 17);
            this.cbIsInsurance.TabIndex = 0;
            this.cbIsInsurance.Text = "Có";
            this.cbIsInsurance.UseVisualStyleBackColor = true;
            this.cbIsInsurance.CheckedChanged += new System.EventHandler(this.cbIsInsurance_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchDoctorByName);
            this.groupBox3.Controls.Add(this.dtgvDoctor);
            this.groupBox3.Controls.Add(this.cbbFaculty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtIDDoctor);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtNameDoctor);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 153);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bác sĩ khám bệnh";
            // 
            // btnSearchDoctorByName
            // 
            this.btnSearchDoctorByName.Location = new System.Drawing.Point(190, 15);
            this.btnSearchDoctorByName.Name = "btnSearchDoctorByName";
            this.btnSearchDoctorByName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDoctorByName.TabIndex = 18;
            this.btnSearchDoctorByName.Text = "Tìm kiếm";
            this.btnSearchDoctorByName.UseVisualStyleBackColor = true;
            this.btnSearchDoctorByName.Click += new System.EventHandler(this.btnSearchDoctorByName_Click);
            // 
            // dtgvDoctor
            // 
            this.dtgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoctor.Location = new System.Drawing.Point(6, 38);
            this.dtgvDoctor.MultiSelect = false;
            this.dtgvDoctor.Name = "dtgvDoctor";
            this.dtgvDoctor.ReadOnly = true;
            this.dtgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDoctor.Size = new System.Drawing.Size(840, 110);
            this.dtgvDoctor.TabIndex = 17;
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Items.AddRange(new object[] {
            "Khoa ngoại",
            "Khoa nội",
            "Khoa phụ sản",
            "Khoa nhi",
            "Khoa cấp cứu",
            "Khoa hồi sức",
            "Khoa ung bướu"});
            this.cbbFaculty.Location = new System.Drawing.Point(722, 14);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(96, 21);
            this.cbbFaculty.TabIndex = 16;
            this.cbbFaculty.SelectedIndexChanged += new System.EventHandler(this.cbbFaculty_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(681, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Khoa:";
            // 
            // txtIDDoctor
            // 
            this.txtIDDoctor.Location = new System.Drawing.Point(405, 15);
            this.txtIDDoctor.Name = "txtIDDoctor";
            this.txtIDDoctor.ReadOnly = true;
            this.txtIDDoctor.Size = new System.Drawing.Size(48, 20);
            this.txtIDDoctor.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Mã bác sĩ:";
            // 
            // txtNameDoctor
            // 
            this.txtNameDoctor.Location = new System.Drawing.Point(53, 17);
            this.txtNameDoctor.Name = "txtNameDoctor";
            this.txtNameDoctor.Size = new System.Drawing.Size(131, 20);
            this.txtNameDoctor.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Họ tên:";
            // 
            // btnInsertMedicalBill
            // 
            this.btnInsertMedicalBill.Location = new System.Drawing.Point(778, 548);
            this.btnInsertMedicalBill.Name = "btnInsertMedicalBill";
            this.btnInsertMedicalBill.Size = new System.Drawing.Size(86, 54);
            this.btnInsertMedicalBill.TabIndex = 12;
            this.btnInsertMedicalBill.Text = "Lập phiếu";
            this.btnInsertMedicalBill.UseVisualStyleBackColor = true;
            this.btnInsertMedicalBill.Click += new System.EventHandler(this.btnInsertMedicalBill_Click);
            // 
            // dtgvMedicalBill
            // 
            this.dtgvMedicalBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicalBill.Location = new System.Drawing.Point(629, 24);
            this.dtgvMedicalBill.Name = "dtgvMedicalBill";
            this.dtgvMedicalBill.Size = new System.Drawing.Size(98, 24);
            this.dtgvMedicalBill.TabIndex = 13;
            this.dtgvMedicalBill.Visible = false;
            // 
            // khamBênhToolStripMenuItem
            // 
            this.khamBênhToolStripMenuItem.Name = "khamBênhToolStripMenuItem";
            this.khamBênhToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.khamBênhToolStripMenuItem.Text = "Khám bệnh";
            // 
            // thanhToanToolStripMenuItem
            // 
            this.thanhToanToolStripMenuItem.Name = "thanhToanToolStripMenuItem";
            this.thanhToanToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.thanhToanToolStripMenuItem.Text = "Thanh toán";
            this.thanhToanToolStripMenuItem.Click += new System.EventHandler(this.thanhToanToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 608);
            this.Controls.Add(this.dtgvMedicalBill);
            this.Controls.Add(this.btnInsertMedicalBill);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bệnh viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCardPatient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhonePatient;
        private System.Windows.Forms.ComboBox cbbSexPatient;
        private System.Windows.Forms.TextBox txtAddressPatient;
        private System.Windows.Forms.TextBox txtNamePatient;
        private System.Windows.Forms.DateTimePicker dtpkDOBPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpkDateMedicalExamination;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTypeInsurance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbIsInsurance;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIDDoctor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNameDoctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIDMedicalBill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnInsertMedicalBill;
        private System.Windows.Forms.Button btnSearchPatientByName;
        private System.Windows.Forms.Button btnSearchPatientByIDCard;
        private System.Windows.Forms.DataGridView dtgvPatient;
        private System.Windows.Forms.Button btnSearchDoctorByName;
        private System.Windows.Forms.DataGridView dtgvDoctor;
        private System.Windows.Forms.TextBox txtIDPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvMedicalBill;
        private System.Windows.Forms.ToolStripMenuItem khamBênhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem khamBênhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kêtQuaChânĐoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToanToolStripMenuItem;
    }
}
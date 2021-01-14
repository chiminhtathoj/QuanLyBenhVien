﻿
namespace QuanLyBenhVien
{
    partial class frmManagement
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
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.btnLoadUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetAccPW = new System.Windows.Forms.Button();
            this.cbbUserType = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.btnLoadPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNamePatient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddressPatient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbSexPatient = new System.Windows.Forms.ComboBox();
            this.dtpkDOBPatient = new System.Windows.Forms.DateTimePicker();
            this.txtIDPatient = new System.Windows.Forms.TextBox();
            this.txtIDCardPatient = new System.Windows.Forms.TextBox();
            this.txtPhonePatient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.tbDoctor = new System.Windows.Forms.TabPage();
            this.btnLoadDoctor = new System.Windows.Forms.Button();
            this.btnEditDoctor = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbFacultyDoctor = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNameDoctor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddressDoctor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbSexDoctor = new System.Windows.Forms.ComboBox();
            this.dtpkDOBDoctor = new System.Windows.Forms.DateTimePicker();
            this.txtIDDoctor = new System.Windows.Forms.TextBox();
            this.txtIDCardDoctor = new System.Windows.Forms.TextBox();
            this.txtPhoneDoctor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearchDoctor = new System.Windows.Forms.Button();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.dtgvDoctor = new System.Windows.Forms.DataGridView();
            this.patientBUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcManagement.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpPatient.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            this.tbDoctor.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.tpAccount);
            this.tcManagement.Controls.Add(this.tpPatient);
            this.tcManagement.Controls.Add(this.tbDoctor);
            this.tcManagement.Location = new System.Drawing.Point(2, 1);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(1410, 656);
            this.tcManagement.TabIndex = 0;
            this.tcManagement.SelectedIndexChanged += new System.EventHandler(this.tcManagement_SelectedIndexChanged);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.btnLoadUser);
            this.tpAccount.Controls.Add(this.btnEditUser);
            this.tpAccount.Controls.Add(this.btnDeleteUser);
            this.tpAccount.Controls.Add(this.btnAddUser);
            this.tpAccount.Controls.Add(this.panel1);
            this.tpAccount.Controls.Add(this.dtgvAccount);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1402, 630);
            this.tpAccount.TabIndex = 0;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Location = new System.Drawing.Point(1272, 569);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(85, 40);
            this.btnLoadUser.TabIndex = 4;
            this.btnLoadUser.Text = "Xem";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            this.btnLoadUser.Click += new System.EventHandler(this.btnLoadUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(1080, 569);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(85, 40);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Sửa";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(1272, 503);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(1080, 503);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(85, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetAccPW);
            this.panel1.Controls.Add(this.cbbUserType);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnSearchUser);
            this.panel1.Controls.Add(this.txtSearchUser);
            this.panel1.Location = new System.Drawing.Point(1030, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 480);
            this.panel1.TabIndex = 0;
            // 
            // btnResetAccPW
            // 
            this.btnResetAccPW.Location = new System.Drawing.Point(255, 137);
            this.btnResetAccPW.Name = "btnResetAccPW";
            this.btnResetAccPW.Size = new System.Drawing.Size(110, 23);
            this.btnResetAccPW.TabIndex = 4;
            this.btnResetAccPW.Text = "Đặt lại mật khẩu";
            this.btnResetAccPW.UseVisualStyleBackColor = true;
            this.btnResetAccPW.Click += new System.EventHandler(this.btnResetAccPW_Click);
            // 
            // cbbUserType
            // 
            this.cbbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserType.FormattingEnabled = true;
            this.cbbUserType.Items.AddRange(new object[] {
            "Admin",
            "Bác sĩ",
            "Nhân viên",
            "Nghỉ việc"});
            this.cbbUserType.Location = new System.Drawing.Point(191, 100);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.Size = new System.Drawing.Size(174, 21);
            this.cbbUserType.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(191, 69);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Loại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên Đăng Nhập:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(80, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Thông tin người dùng";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(276, 2);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(89, 23);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Tìm kiếm";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(3, 3);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(267, 20);
            this.txtSearchUser.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(1021, 624);
            this.dtgvAccount.TabIndex = 0;
            this.dtgvAccount.TabStop = false;
            // 
            // tpPatient
            // 
            this.tpPatient.Controls.Add(this.btnLoadPatient);
            this.tpPatient.Controls.Add(this.btnUpdatePatient);
            this.tpPatient.Controls.Add(this.btnAddPatient);
            this.tpPatient.Controls.Add(this.panel2);
            this.tpPatient.Controls.Add(this.dtgvPatient);
            this.tpPatient.Location = new System.Drawing.Point(4, 22);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(1402, 630);
            this.tpPatient.TabIndex = 1;
            this.tpPatient.Text = "Bệnh nhân";
            this.tpPatient.UseVisualStyleBackColor = true;
            // 
            // btnLoadPatient
            // 
            this.btnLoadPatient.Location = new System.Drawing.Point(1178, 573);
            this.btnLoadPatient.Name = "btnLoadPatient";
            this.btnLoadPatient.Size = new System.Drawing.Size(85, 40);
            this.btnLoadPatient.TabIndex = 3;
            this.btnLoadPatient.Text = "Xem";
            this.btnLoadPatient.UseVisualStyleBackColor = true;
            this.btnLoadPatient.Click += new System.EventHandler(this.btnLoadPatient_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(1273, 507);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(85, 40);
            this.btnUpdatePatient.TabIndex = 2;
            this.btnUpdatePatient.Text = "Sửa";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(1081, 507);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(85, 40);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Thêm";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNamePatient);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtAddressPatient);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbbSexPatient);
            this.panel2.Controls.Add(this.dtpkDOBPatient);
            this.panel2.Controls.Add(this.txtIDPatient);
            this.panel2.Controls.Add(this.txtIDCardPatient);
            this.panel2.Controls.Add(this.txtPhonePatient);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSearchPatient);
            this.panel2.Controls.Add(this.txtSearchPatient);
            this.panel2.Location = new System.Drawing.Point(1030, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 480);
            this.panel2.TabIndex = 0;
            // 
            // txtNamePatient
            // 
            this.txtNamePatient.Location = new System.Drawing.Point(181, 171);
            this.txtNamePatient.Name = "txtNamePatient";
            this.txtNamePatient.Size = new System.Drawing.Size(174, 20);
            this.txtNamePatient.TabIndex = 3;
            this.txtNamePatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamePatient_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Họ và tên:";
            // 
            // txtAddressPatient
            // 
            this.txtAddressPatient.Location = new System.Drawing.Point(181, 393);
            this.txtAddressPatient.Name = "txtAddressPatient";
            this.txtAddressPatient.Size = new System.Drawing.Size(174, 20);
            this.txtAddressPatient.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Địa chỉ:";
            // 
            // cbbSexPatient
            // 
            this.cbbSexPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSexPatient.FormattingEnabled = true;
            this.cbbSexPatient.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSexPatient.Location = new System.Drawing.Point(181, 228);
            this.cbbSexPatient.Name = "cbbSexPatient";
            this.cbbSexPatient.Size = new System.Drawing.Size(174, 21);
            this.cbbSexPatient.TabIndex = 4;
            // 
            // dtpkDOBPatient
            // 
            this.dtpkDOBPatient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDOBPatient.Location = new System.Drawing.Point(181, 283);
            this.dtpkDOBPatient.Name = "dtpkDOBPatient";
            this.dtpkDOBPatient.Size = new System.Drawing.Size(174, 20);
            this.dtpkDOBPatient.TabIndex = 5;
            this.dtpkDOBPatient.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtIDPatient
            // 
            this.txtIDPatient.Location = new System.Drawing.Point(181, 67);
            this.txtIDPatient.Name = "txtIDPatient";
            this.txtIDPatient.ReadOnly = true;
            this.txtIDPatient.Size = new System.Drawing.Size(174, 20);
            this.txtIDPatient.TabIndex = 14;
            this.txtIDPatient.TabStop = false;
            // 
            // txtIDCardPatient
            // 
            this.txtIDCardPatient.Location = new System.Drawing.Point(181, 121);
            this.txtIDCardPatient.Name = "txtIDCardPatient";
            this.txtIDCardPatient.Size = new System.Drawing.Size(174, 20);
            this.txtIDCardPatient.TabIndex = 2;
            // 
            // txtPhonePatient
            // 
            this.txtPhonePatient.Location = new System.Drawing.Point(181, 336);
            this.txtPhonePatient.Name = "txtPhonePatient";
            this.txtPhonePatient.Size = new System.Drawing.Size(174, 20);
            this.txtPhonePatient.TabIndex = 6;
            this.txtPhonePatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhonePatient_KeyPress);
            this.txtPhonePatient.Leave += new System.EventHandler(this.txtPhonePatient_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin người bệnh";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.Location = new System.Drawing.Point(276, 2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(89, 23);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Tìm kiếm";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(3, 3);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(267, 20);
            this.txtSearchPatient.TabIndex = 0;
            // 
            // dtgvPatient
            // 
            this.dtgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPatient.Location = new System.Drawing.Point(3, 3);
            this.dtgvPatient.Name = "dtgvPatient";
            this.dtgvPatient.ReadOnly = true;
            this.dtgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPatient.Size = new System.Drawing.Size(1021, 624);
            this.dtgvPatient.TabIndex = 1;
            this.dtgvPatient.TabStop = false;
            // 
            // tbDoctor
            // 
            this.tbDoctor.Controls.Add(this.btnLoadDoctor);
            this.tbDoctor.Controls.Add(this.btnEditDoctor);
            this.tbDoctor.Controls.Add(this.btnAddDoctor);
            this.tbDoctor.Controls.Add(this.panel3);
            this.tbDoctor.Controls.Add(this.dtgvDoctor);
            this.tbDoctor.Location = new System.Drawing.Point(4, 22);
            this.tbDoctor.Name = "tbDoctor";
            this.tbDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tbDoctor.Size = new System.Drawing.Size(1402, 630);
            this.tbDoctor.TabIndex = 2;
            this.tbDoctor.Text = "Bác sĩ";
            this.tbDoctor.UseVisualStyleBackColor = true;
            // 
            // btnLoadDoctor
            // 
            this.btnLoadDoctor.Location = new System.Drawing.Point(1182, 564);
            this.btnLoadDoctor.Name = "btnLoadDoctor";
            this.btnLoadDoctor.Size = new System.Drawing.Size(85, 40);
            this.btnLoadDoctor.TabIndex = 13;
            this.btnLoadDoctor.Text = "Xem";
            this.btnLoadDoctor.UseVisualStyleBackColor = true;
            this.btnLoadDoctor.Click += new System.EventHandler(this.btnLoadDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.Location = new System.Drawing.Point(1273, 508);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(85, 40);
            this.btnEditDoctor.TabIndex = 12;
            this.btnEditDoctor.Text = "Sửa";
            this.btnEditDoctor.UseVisualStyleBackColor = true;
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(1081, 508);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(85, 40);
            this.btnAddDoctor.TabIndex = 10;
            this.btnAddDoctor.Text = "Thêm";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbFacultyDoctor);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtNameDoctor);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtAddressDoctor);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cbbSexDoctor);
            this.panel3.Controls.Add(this.dtpkDOBDoctor);
            this.panel3.Controls.Add(this.txtIDDoctor);
            this.panel3.Controls.Add(this.txtIDCardDoctor);
            this.panel3.Controls.Add(this.txtPhoneDoctor);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.btnSearchDoctor);
            this.panel3.Controls.Add(this.txtSearchDoctor);
            this.panel3.Location = new System.Drawing.Point(1027, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 480);
            this.panel3.TabIndex = 6;
            // 
            // cbbFacultyDoctor
            // 
            this.cbbFacultyDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFacultyDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFacultyDoctor.FormattingEnabled = true;
            this.cbbFacultyDoctor.Items.AddRange(new object[] {
            "Khoa ngoại",
            "Khoa nội",
            "Khoa phụ sản",
            "Khoa nhi",
            "Khoa cấp cứu",
            "Khoa hồi sức",
            "Khoa ung bướu"});
            this.cbbFacultyDoctor.Location = new System.Drawing.Point(181, 443);
            this.cbbFacultyDoctor.Name = "cbbFacultyDoctor";
            this.cbbFacultyDoctor.Size = new System.Drawing.Size(174, 21);
            this.cbbFacultyDoctor.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 442);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 19);
            this.label20.TabIndex = 23;
            this.label20.Text = "Khoa:";
            // 
            // txtNameDoctor
            // 
            this.txtNameDoctor.Location = new System.Drawing.Point(181, 171);
            this.txtNameDoctor.Name = "txtNameDoctor";
            this.txtNameDoctor.Size = new System.Drawing.Size(174, 20);
            this.txtNameDoctor.TabIndex = 20;
            this.txtNameDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameDoctor_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Họ và tên:";
            // 
            // txtAddressDoctor
            // 
            this.txtAddressDoctor.Location = new System.Drawing.Point(181, 393);
            this.txtAddressDoctor.Name = "txtAddressDoctor";
            this.txtAddressDoctor.Size = new System.Drawing.Size(174, 20);
            this.txtAddressDoctor.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "Địa chỉ:";
            // 
            // cbbSexDoctor
            // 
            this.cbbSexDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSexDoctor.FormattingEnabled = true;
            this.cbbSexDoctor.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSexDoctor.Location = new System.Drawing.Point(181, 228);
            this.cbbSexDoctor.Name = "cbbSexDoctor";
            this.cbbSexDoctor.Size = new System.Drawing.Size(174, 21);
            this.cbbSexDoctor.TabIndex = 9;
            // 
            // dtpkDOBDoctor
            // 
            this.dtpkDOBDoctor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDOBDoctor.Location = new System.Drawing.Point(181, 283);
            this.dtpkDOBDoctor.Name = "dtpkDOBDoctor";
            this.dtpkDOBDoctor.Size = new System.Drawing.Size(174, 20);
            this.dtpkDOBDoctor.TabIndex = 10;
            this.dtpkDOBDoctor.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtIDDoctor
            // 
            this.txtIDDoctor.Location = new System.Drawing.Point(181, 67);
            this.txtIDDoctor.Name = "txtIDDoctor";
            this.txtIDDoctor.ReadOnly = true;
            this.txtIDDoctor.Size = new System.Drawing.Size(174, 20);
            this.txtIDDoctor.TabIndex = 14;
            this.txtIDDoctor.TabStop = false;
            // 
            // txtIDCardDoctor
            // 
            this.txtIDCardDoctor.Location = new System.Drawing.Point(181, 121);
            this.txtIDCardDoctor.Name = "txtIDCardDoctor";
            this.txtIDCardDoctor.Size = new System.Drawing.Size(174, 20);
            this.txtIDCardDoctor.TabIndex = 8;
            // 
            // txtPhoneDoctor
            // 
            this.txtPhoneDoctor.Location = new System.Drawing.Point(181, 336);
            this.txtPhoneDoctor.Name = "txtPhoneDoctor";
            this.txtPhoneDoctor.Size = new System.Drawing.Size(174, 20);
            this.txtPhoneDoctor.TabIndex = 12;
            this.txtPhoneDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneDoctor_KeyPress);
            this.txtPhoneDoctor.Leave += new System.EventHandler(this.txtPhoneDoctor_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Số Điện Thoại:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 19);
            this.label15.TabIndex = 16;
            this.label15.Text = "Giới Tính:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 19);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ngày Sinh:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 13;
            this.label17.Text = "CMND:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 19);
            this.label18.TabIndex = 11;
            this.label18.Text = "Mã bác sĩ:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(100, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 24);
            this.label19.TabIndex = 7;
            this.label19.Text = "Thông tin bác sĩ";
            // 
            // btnSearchDoctor
            // 
            this.btnSearchDoctor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDoctor.Location = new System.Drawing.Point(276, 2);
            this.btnSearchDoctor.Name = "btnSearchDoctor";
            this.btnSearchDoctor.Size = new System.Drawing.Size(89, 23);
            this.btnSearchDoctor.TabIndex = 1;
            this.btnSearchDoctor.Text = "Tìm kiếm";
            this.btnSearchDoctor.UseVisualStyleBackColor = true;
            this.btnSearchDoctor.Click += new System.EventHandler(this.btnSearchDoctor_Click);
            // 
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Location = new System.Drawing.Point(3, 3);
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(267, 20);
            this.txtSearchDoctor.TabIndex = 0;
            // 
            // dtgvDoctor
            // 
            this.dtgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoctor.Location = new System.Drawing.Point(3, 3);
            this.dtgvDoctor.Name = "dtgvDoctor";
            this.dtgvDoctor.ReadOnly = true;
            this.dtgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDoctor.Size = new System.Drawing.Size(1021, 624);
            this.dtgvDoctor.TabIndex = 2;
            this.dtgvDoctor.TabStop = false;
            // 
            // patientBUSBindingSource
            // 
            this.patientBUSBindingSource.DataSource = typeof(BUS.PatientBUS);
            // 
            // frmManagement
            // 
            this.AcceptButton = this.btnSearchUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 657);
            this.Controls.Add(this.tcManagement);
            this.Name = "frmManagement";
            this.Text = "frmAdmin";
            this.tcManagement.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpPatient.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            this.tbDoctor.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBUSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManagement;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.Button btnLoadUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetAccPW;
        private System.Windows.Forms.ComboBox cbbUserType;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnLoadPatient;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAddressPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbSexPatient;
        private System.Windows.Forms.DateTimePicker dtpkDOBPatient;
        private System.Windows.Forms.TextBox txtIDPatient;
        private System.Windows.Forms.TextBox txtIDCardPatient;
        private System.Windows.Forms.TextBox txtPhonePatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.DataGridView dtgvPatient;
        private System.Windows.Forms.TextBox txtNamePatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tbDoctor;
        private System.Windows.Forms.Button btnLoadDoctor;
        private System.Windows.Forms.Button btnEditDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbFacultyDoctor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNameDoctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddressDoctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbSexDoctor;
        private System.Windows.Forms.DateTimePicker dtpkDOBDoctor;
        private System.Windows.Forms.TextBox txtIDDoctor;
        private System.Windows.Forms.TextBox txtIDCardDoctor;
        private System.Windows.Forms.TextBox txtPhoneDoctor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSearchDoctor;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.DataGridView dtgvDoctor;
        private System.Windows.Forms.BindingSource patientBUSBindingSource;
    }
}
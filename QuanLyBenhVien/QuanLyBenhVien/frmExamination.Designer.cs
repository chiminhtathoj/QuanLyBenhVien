
namespace QuanLyBenhVien
{
    partial class frmExamination
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchMedicalByIDMedicalBill = new System.Windows.Forms.Button();
            this.txtIDMedicalBill = new System.Windows.Forms.TextBox();
            this.dtgvExamination = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkDateMedicalExamination = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.lvService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbNameService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamination)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchMedicalByIDMedicalBill);
            this.groupBox1.Controls.Add(this.txtIDMedicalBill);
            this.groupBox1.Controls.Add(this.dtgvExamination);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(5, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // btnSearchMedicalByIDMedicalBill
            // 
            this.btnSearchMedicalByIDMedicalBill.Location = new System.Drawing.Point(162, 17);
            this.btnSearchMedicalByIDMedicalBill.Name = "btnSearchMedicalByIDMedicalBill";
            this.btnSearchMedicalByIDMedicalBill.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMedicalByIDMedicalBill.TabIndex = 17;
            this.btnSearchMedicalByIDMedicalBill.Text = "Tìm kiếm";
            this.btnSearchMedicalByIDMedicalBill.UseVisualStyleBackColor = true;
            this.btnSearchMedicalByIDMedicalBill.Click += new System.EventHandler(this.btnSearchMedicalByIDMedicalBill_Click);
            // 
            // txtIDMedicalBill
            // 
            this.txtIDMedicalBill.Location = new System.Drawing.Point(108, 19);
            this.txtIDMedicalBill.Name = "txtIDMedicalBill";
            this.txtIDMedicalBill.Size = new System.Drawing.Size(48, 20);
            this.txtIDMedicalBill.TabIndex = 15;
            // 
            // dtgvExamination
            // 
            this.dtgvExamination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExamination.Location = new System.Drawing.Point(6, 45);
            this.dtgvExamination.MultiSelect = false;
            this.dtgvExamination.Name = "dtgvExamination";
            this.dtgvExamination.ReadOnly = true;
            this.dtgvExamination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvExamination.Size = new System.Drawing.Size(847, 57);
            this.dtgvExamination.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mã phiếu khám:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Khám bệnh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpkDateMedicalExamination);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnDeleteService);
            this.groupBox2.Controls.Add(this.btnAddService);
            this.groupBox2.Controls.Add(this.lvService);
            this.groupBox2.Controls.Add(this.cbbNameService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(5, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 219);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xét nghiệm cần làm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 94);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Yêu cầu của bác sĩ:";
            // 
            // dtpkDateMedicalExamination
            // 
            this.dtpkDateMedicalExamination.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateMedicalExamination.Location = new System.Drawing.Point(107, 59);
            this.dtpkDateMedicalExamination.Name = "dtpkDateMedicalExamination";
            this.dtpkDateMedicalExamination.Size = new System.Drawing.Size(88, 20);
            this.dtpkDateMedicalExamination.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày xét nghiệm:";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(141, 189);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteService.TabIndex = 16;
            this.btnDeleteService.Text = "Xóa dịch vụ đả chọn";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(6, 189);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(129, 23);
            this.btnAddService.TabIndex = 15;
            this.btnAddService.Text = "Thêm dịch vụ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // lvService
            // 
            this.lvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6});
            this.lvService.FullRowSelect = true;
            this.lvService.GridLines = true;
            this.lvService.HideSelection = false;
            this.lvService.Location = new System.Drawing.Point(497, 10);
            this.lvService.Name = "lvService";
            this.lvService.Size = new System.Drawing.Size(363, 202);
            this.lvService.TabIndex = 14;
            this.lvService.TabStop = false;
            this.lvService.UseCompatibleStateImageBehavior = false;
            this.lvService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã dịch vụ";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên dịch vụ";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn giá";
            this.columnHeader6.Width = 302;
            // 
            // cbbNameService
            // 
            this.cbbNameService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNameService.FormattingEnabled = true;
            this.cbbNameService.Location = new System.Drawing.Point(107, 23);
            this.cbbNameService.Name = "cbbNameService";
            this.cbbNameService.Size = new System.Drawing.Size(130, 21);
            this.cbbNameService.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Loại bảo hiểm y tế:";
            // 
            // btnInsertTest
            // 
            this.btnInsertTest.Location = new System.Drawing.Point(775, 371);
            this.btnInsertTest.Name = "btnInsertTest";
            this.btnInsertTest.Size = new System.Drawing.Size(90, 54);
            this.btnInsertTest.TabIndex = 14;
            this.btnInsertTest.Text = "Lập phiếu xét nghiệm";
            this.btnInsertTest.UseVisualStyleBackColor = true;
            this.btnInsertTest.Click += new System.EventHandler(this.btnInsertTest_Click);
            // 
            // frmExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 429);
            this.Controls.Add(this.btnInsertTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExamination";
            this.Text = "Khám bệnh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamination)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDMedicalBill;
        private System.Windows.Forms.DataGridView dtgvExamination;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearchMedicalByIDMedicalBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cbbNameService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkDateMedicalExamination;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInsertTest;
    }
}
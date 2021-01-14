
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
            this.txtIDMedicalBill = new System.Windows.Forms.TextBox();
            this.dtgvExamination = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchMedicalByIDMedicalBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIDPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamination)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dtgvExamination.Size = new System.Drawing.Size(833, 57);
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
            this.label12.Location = new System.Drawing.Point(347, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Khám bệnh";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIDPatient);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(5, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 212);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các xét nghiệm cần làm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 149);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(833, 57);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtIDPatient
            // 
            this.txtIDPatient.Location = new System.Drawing.Point(108, 19);
            this.txtIDPatient.Name = "txtIDPatient";
            this.txtIDPatient.ReadOnly = true;
            this.txtIDPatient.Size = new System.Drawing.Size(48, 20);
            this.txtIDPatient.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // frmExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 562);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDPatient;
        private System.Windows.Forms.Label label1;
    }
}
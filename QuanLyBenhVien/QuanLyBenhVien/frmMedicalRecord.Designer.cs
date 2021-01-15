
namespace QuanLyBenhVien
{
    partial class frmMedicalRecord
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
            this.btnSearchMedicalByIDMedicalBill = new System.Windows.Forms.Button();
            this.txtIDPatient = new System.Windows.Forms.TextBox();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbStatusPre = new System.Windows.Forms.RichTextBox();
            this.btnInsertTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(300, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Lập hồ sơ bệnh án";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertTest);
            this.groupBox1.Controls.Add(this.rtbStatusPre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchMedicalByIDMedicalBill);
            this.groupBox1.Controls.Add(this.txtIDPatient);
            this.groupBox1.Controls.Add(this.dtgvPatient);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(1, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 237);
            this.groupBox1.TabIndex = 14;
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
            // txtIDPatient
            // 
            this.txtIDPatient.Location = new System.Drawing.Point(108, 19);
            this.txtIDPatient.Name = "txtIDPatient";
            this.txtIDPatient.Size = new System.Drawing.Size(48, 20);
            this.txtIDPatient.TabIndex = 15;
            // 
            // dtgvPatient
            // 
            this.dtgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPatient.Location = new System.Drawing.Point(6, 45);
            this.dtgvPatient.MultiSelect = false;
            this.dtgvPatient.Name = "dtgvPatient";
            this.dtgvPatient.ReadOnly = true;
            this.dtgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPatient.Size = new System.Drawing.Size(781, 57);
            this.dtgvPatient.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mã bệnh nhân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tình trạng trước khi nhập viện:";
            // 
            // rtbStatusPre
            // 
            this.rtbStatusPre.Location = new System.Drawing.Point(11, 131);
            this.rtbStatusPre.Name = "rtbStatusPre";
            this.rtbStatusPre.Size = new System.Drawing.Size(667, 96);
            this.rtbStatusPre.TabIndex = 19;
            this.rtbStatusPre.Text = "";
            // 
            // btnInsertTest
            // 
            this.btnInsertTest.Location = new System.Drawing.Point(697, 173);
            this.btnInsertTest.Name = "btnInsertTest";
            this.btnInsertTest.Size = new System.Drawing.Size(90, 54);
            this.btnInsertTest.TabIndex = 15;
            this.btnInsertTest.Text = "Lập hồ sơ";
            this.btnInsertTest.UseVisualStyleBackColor = true;
            this.btnInsertTest.Click += new System.EventHandler(this.btnInsertTest_Click);
            // 
            // frmMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "frmMedicalRecord";
            this.Text = "frmMedicalRecord";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchMedicalByIDMedicalBill;
        private System.Windows.Forms.TextBox txtIDPatient;
        private System.Windows.Forms.DataGridView dtgvPatient;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtbStatusPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertTest;
    }
}
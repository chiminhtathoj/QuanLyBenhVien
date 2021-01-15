
namespace QuanLyBenhVien
{
    partial class frmResultDiagnose
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
            this.btnSearchTestByTestID = new System.Windows.Forms.Button();
            this.txtIDTest = new System.Windows.Forms.TextBox();
            this.dtgvTest = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpkDateResult = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDOT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResultDiagnose = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTest)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Kết quả chẩn đoán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchTestByTestID);
            this.groupBox1.Controls.Add(this.txtIDTest);
            this.groupBox1.Controls.Add(this.dtgvTest);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 146);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xét nghiệm";
            // 
            // btnSearchTestByTestID
            // 
            this.btnSearchTestByTestID.Location = new System.Drawing.Point(175, 17);
            this.btnSearchTestByTestID.Name = "btnSearchTestByTestID";
            this.btnSearchTestByTestID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTestByTestID.TabIndex = 17;
            this.btnSearchTestByTestID.Text = "Tìm kiếm";
            this.btnSearchTestByTestID.UseVisualStyleBackColor = true;
            this.btnSearchTestByTestID.Click += new System.EventHandler(this.btnSearchTestByTestID_Click);
            // 
            // txtIDTest
            // 
            this.txtIDTest.Location = new System.Drawing.Point(121, 19);
            this.txtIDTest.Name = "txtIDTest";
            this.txtIDTest.Size = new System.Drawing.Size(48, 20);
            this.txtIDTest.TabIndex = 15;
            // 
            // dtgvTest
            // 
            this.dtgvTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTest.Location = new System.Drawing.Point(6, 45);
            this.dtgvTest.MultiSelect = false;
            this.dtgvTest.Name = "dtgvTest";
            this.dtgvTest.ReadOnly = true;
            this.dtgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTest.Size = new System.Drawing.Size(530, 95);
            this.dtgvTest.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mã phiếu xét nghiệm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpkDateResult);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbDOT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbResultDiagnose);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 192);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuẩn đoán của bác sĩ";
            // 
            // dtpkDateResult
            // 
            this.dtpkDateResult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateResult.Location = new System.Drawing.Point(385, 104);
            this.dtpkDateResult.Name = "dtpkDateResult";
            this.dtpkDateResult.Size = new System.Drawing.Size(121, 20);
            this.dtpkDateResult.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngày Lập:";
            // 
            // cbbDOT
            // 
            this.cbbDOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDOT.FormattingEnabled = true;
            this.cbbDOT.Items.AddRange(new object[] {
            "Không có bệnh",
            "Ngoại trú",
            "Nhập viện",
            "Chuyển viện"});
            this.cbbDOT.Location = new System.Drawing.Point(385, 43);
            this.cbbDOT.Name = "cbbDOT";
            this.cbbDOT.Size = new System.Drawing.Size(121, 21);
            this.cbbDOT.TabIndex = 19;
            this.cbbDOT.SelectedIndexChanged += new System.EventHandler(this.cbbDOT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hướng điều trị:";
            // 
            // rtbResultDiagnose
            // 
            this.rtbResultDiagnose.Location = new System.Drawing.Point(6, 43);
            this.rtbResultDiagnose.Name = "rtbResultDiagnose";
            this.rtbResultDiagnose.Size = new System.Drawing.Size(370, 138);
            this.rtbResultDiagnose.TabIndex = 17;
            this.rtbResultDiagnose.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nội dung:";
            // 
            // btnInsertTest
            // 
            this.btnInsertTest.Location = new System.Drawing.Point(464, 386);
            this.btnInsertTest.Name = "btnInsertTest";
            this.btnInsertTest.Size = new System.Drawing.Size(90, 54);
            this.btnInsertTest.TabIndex = 15;
            this.btnInsertTest.Text = "Lập phiếu kết quả";
            this.btnInsertTest.UseVisualStyleBackColor = true;
            this.btnInsertTest.Click += new System.EventHandler(this.btnInsertTest_Click);
            // 
            // frmResultDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 448);
            this.Controls.Add(this.btnInsertTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "frmResultDiagnose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả chẩn đoán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchTestByTestID;
        private System.Windows.Forms.TextBox txtIDTest;
        private System.Windows.Forms.DataGridView dtgvTest;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResultDiagnose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDOT;
        private System.Windows.Forms.Button btnInsertTest;
        private System.Windows.Forms.DateTimePicker dtpkDateResult;
        private System.Windows.Forms.Label label9;
    }
}
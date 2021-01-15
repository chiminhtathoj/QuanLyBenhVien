
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 9);
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
            this.groupBox1.Size = new System.Drawing.Size(860, 146);
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
            this.dtgvTest.Size = new System.Drawing.Size(847, 95);
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
            // frmResultDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "frmResultDiagnose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả chẩn đoán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTest)).EndInit();
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
    }
}
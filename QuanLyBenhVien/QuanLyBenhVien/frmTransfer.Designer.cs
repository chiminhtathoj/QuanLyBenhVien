
namespace QuanLyBenhVien
{
    partial class frmTransfer
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
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertTransfer = new System.Windows.Forms.Button();
            this.rtbStatusPre = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchTransfer = new System.Windows.Forms.Button();
            this.txtIDPatient = new System.Windows.Forms.TextBox();
            this.dtgvPatient = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbReason);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnInsertTransfer);
            this.groupBox1.Controls.Add(this.rtbStatusPre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchTransfer);
            this.groupBox1.Controls.Add(this.txtIDPatient);
            this.groupBox1.Controls.Add(this.dtgvPatient);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(4, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 357);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // rtbReason
            // 
            this.rtbReason.Location = new System.Drawing.Point(10, 249);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(667, 96);
            this.rtbReason.TabIndex = 21;
            this.rtbReason.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lý do chuyển viện:";
            // 
            // btnInsertTransfer
            // 
            this.btnInsertTransfer.Location = new System.Drawing.Point(697, 291);
            this.btnInsertTransfer.Name = "btnInsertTransfer";
            this.btnInsertTransfer.Size = new System.Drawing.Size(90, 54);
            this.btnInsertTransfer.TabIndex = 15;
            this.btnInsertTransfer.Text = "Lập hồ sơ";
            this.btnInsertTransfer.UseVisualStyleBackColor = true;
            this.btnInsertTransfer.Click += new System.EventHandler(this.btnInsertTransfer_Click);
            // 
            // rtbStatusPre
            // 
            this.rtbStatusPre.Location = new System.Drawing.Point(11, 131);
            this.rtbStatusPre.Name = "rtbStatusPre";
            this.rtbStatusPre.Size = new System.Drawing.Size(667, 96);
            this.rtbStatusPre.TabIndex = 19;
            this.rtbStatusPre.Text = "";
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
            // btnSearchTransfer
            // 
            this.btnSearchTransfer.Location = new System.Drawing.Point(162, 17);
            this.btnSearchTransfer.Name = "btnSearchTransfer";
            this.btnSearchTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTransfer.TabIndex = 17;
            this.btnSearchTransfer.Text = "Tìm kiếm";
            this.btnSearchTransfer.UseVisualStyleBackColor = true;
            this.btnSearchTransfer.Click += new System.EventHandler(this.btnSearchTransfer_Click);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Giấy chuyển viện";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "frmTransfer";
            this.Text = "Chuyển viện";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertTransfer;
        private System.Windows.Forms.RichTextBox rtbStatusPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchTransfer;
        private System.Windows.Forms.TextBox txtIDPatient;
        private System.Windows.Forms.DataGridView dtgvPatient;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.Label label2;
    }
}
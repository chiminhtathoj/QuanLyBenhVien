
namespace QuanLyBenhVien
{
    partial class frmPay
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
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.btnSearchPay = new System.Windows.Forms.Button();
            this.txtSearchPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertTest = new System.Windows.Forms.Button();
            this.txtSumMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(338, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Thanh toán";
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(12, 80);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(776, 239);
            this.dtgvBill.TabIndex = 14;
            this.dtgvBill.TabStop = false;
            // 
            // btnSearchPay
            // 
            this.btnSearchPay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPay.Location = new System.Drawing.Point(248, 53);
            this.btnSearchPay.Name = "btnSearchPay";
            this.btnSearchPay.Size = new System.Drawing.Size(89, 23);
            this.btnSearchPay.TabIndex = 16;
            this.btnSearchPay.Text = "Tìm kiếm";
            this.btnSearchPay.UseVisualStyleBackColor = true;
            this.btnSearchPay.Click += new System.EventHandler(this.btnSearchPay_Click);
            // 
            // txtSearchPay
            // 
            this.txtSearchPay.Location = new System.Drawing.Point(125, 54);
            this.txtSearchPay.Name = "txtSearchPay";
            this.txtSearchPay.Size = new System.Drawing.Size(117, 20);
            this.txtSearchPay.TabIndex = 15;
            this.txtSearchPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchPay_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhập mã bệnh nhân:";
            // 
            // btnInsertTest
            // 
            this.btnInsertTest.Location = new System.Drawing.Point(698, 325);
            this.btnInsertTest.Name = "btnInsertTest";
            this.btnInsertTest.Size = new System.Drawing.Size(90, 54);
            this.btnInsertTest.TabIndex = 19;
            this.btnInsertTest.Text = "Thanh toán tất cả";
            this.btnInsertTest.UseVisualStyleBackColor = true;
            this.btnInsertTest.Click += new System.EventHandler(this.btnInsertTest_Click);
            // 
            // txtSumMoney
            // 
            this.txtSumMoney.Location = new System.Drawing.Point(363, 343);
            this.txtSumMoney.Name = "txtSumMoney";
            this.txtSumMoney.Size = new System.Drawing.Size(124, 20);
            this.txtSumMoney.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tổng tiền:";
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumMoney);
            this.Controls.Add(this.btnInsertTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchPay);
            this.Controls.Add(this.txtSearchPay);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.label12);
            this.Name = "frmPay";
            this.Text = "Thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Button btnSearchPay;
        private System.Windows.Forms.TextBox txtSearchPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertTest;
        private System.Windows.Forms.TextBox txtSumMoney;
        private System.Windows.Forms.Label label2;
    }
}
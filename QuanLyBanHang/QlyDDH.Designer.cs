namespace QuanLyBanHang
{
    partial class QlyDDH
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.TenKH,
            this.NgayDat,
            this.SLg,
            this.TT});
            this.dgvOrder.Location = new System.Drawing.Point(12, 40);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(898, 445);
            this.dgvOrder.TabIndex = 0;
            // 
            // MaDH
            // 
            this.MaDH.HeaderText = "Mã đơn hàng ";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.HeaderText = "Ngày đặt hàng";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // SLg
            // 
            this.SLg.HeaderText = "Số lượng";
            this.SLg.MinimumWidth = 6;
            this.SLg.Name = "SLg";
            this.SLg.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.HeaderText = "Tổng ";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 11);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(774, 11);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(108, 23);
            this.btnPrintInvoice.TabIndex = 2;
            this.btnPrintInvoice.Text = "In Hóa Đơn";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // QlyDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 497);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvOrder);
            this.Name = "QlyDDH";
            this.Text = "QlyDDH";
            this.Load += new System.EventHandler(this.QlyDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintInvoice;
    }
}
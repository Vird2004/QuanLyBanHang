namespace QuanLyBanHang
{
    partial class QLKH
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
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.btnAdd_Change = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.DiaChi});
            this.dgvKH.Location = new System.Drawing.Point(324, 12);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(528, 505);
            this.dgvKH.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd_Change);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 505);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hàng hóa";
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Ma khach hang";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Ten khach hang";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Dia chi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TenKH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MaKH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dia chi";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(83, 36);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(217, 22);
            this.txtMaKH.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 266);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(83, 185);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(217, 22);
            this.txtSDT.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(83, 109);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(217, 22);
            this.txtTenKH.TabIndex = 7;
            // 
            // btnAdd_Change
            // 
            this.btnAdd_Change.Location = new System.Drawing.Point(14, 322);
            this.btnAdd_Change.Name = "btnAdd_Change";
            this.btnAdd_Change.Size = new System.Drawing.Size(83, 23);
            this.btnAdd_Change.TabIndex = 8;
            this.btnAdd_Change.Text = "Them/Sua";
            this.btnAdd_Change.UseVisualStyleBackColor = true;
            this.btnAdd_Change.Click += new System.EventHandler(this.btnAdd_Change_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(114, 322);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(83, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Xoa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(217, 320);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 27);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Quay lai";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKH);
            this.Name = "QLKH";
            this.Text = "QLKH";
            this.Load += new System.EventHandler(this.QLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd_Change;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReturn;
    }
}
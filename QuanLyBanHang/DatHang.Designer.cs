namespace QuanLyBanHang
{
    partial class DatHang
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveDH = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd_Change = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDDH = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ĐG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHH = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveDH);
            this.groupBox1.Controls.Add(this.panel);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.dgvDDH);
            this.groupBox1.Controls.Add(this.dgvHH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quan ly don hang";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(47, 303);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(224, 32);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSaveDH
            // 
            this.btnSaveDH.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSaveDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveDH.Location = new System.Drawing.Point(399, 333);
            this.btnSaveDH.Name = "btnSaveDH";
            this.btnSaveDH.Size = new System.Drawing.Size(163, 35);
            this.btnSaveDH.TabIndex = 11;
            this.btnSaveDH.Text = "Lưu hóa đơn";
            this.btnSaveDH.UseVisualStyleBackColor = false;
            this.btnSaveDH.Click += new System.EventHandler(this.btnSaveDH_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnReturn);
            this.panel.Controls.Add(this.btnDel);
            this.panel.Controls.Add(this.btnAdd_Change);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.cbSanPham);
            this.panel.Controls.Add(this.numSL);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(577, 21);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(316, 347);
            this.panel.TabIndex = 10;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(47, 238);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(224, 59);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd_Change
            // 
            this.btnAdd_Change.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd_Change.Location = new System.Drawing.Point(47, 173);
            this.btnAdd_Change.Name = "btnAdd_Change";
            this.btnAdd_Change.Size = new System.Drawing.Size(224, 59);
            this.btnAdd_Change.TabIndex = 16;
            this.btnAdd_Change.Text = "Thêm đơn hàng";
            this.btnAdd_Change.UseVisualStyleBackColor = false;
            this.btnAdd_Change.Click += new System.EventHandler(this.btnAdd_Change_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(113, 87);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(190, 24);
            this.cbSanPham.TabIndex = 14;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(113, 139);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(120, 22);
            this.numSL.TabIndex = 13;
            this.numSL.ValueChanged += new System.EventHandler(this.numSL_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(699, 533);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Tổng tiền: ";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // dgvDDH
            // 
            this.dgvDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDDH.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.Tenhh,
            this.SLg,
            this.ĐG,
            this.TT});
            this.dgvDDH.Location = new System.Drawing.Point(6, 384);
            this.dgvDDH.Name = "dgvDDH";
            this.dgvDDH.RowHeadersWidth = 51;
            this.dgvDDH.RowTemplate.Height = 24;
            this.dgvDDH.Size = new System.Drawing.Size(887, 146);
            this.dgvDDH.TabIndex = 1;
            this.dgvDDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDDH_CellContentClick);
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // Tenhh
            // 
            this.Tenhh.HeaderText = "Tên sản phẩm";
            this.Tenhh.MinimumWidth = 6;
            this.Tenhh.Name = "Tenhh";
            this.Tenhh.ReadOnly = true;
            // 
            // SLg
            // 
            this.SLg.HeaderText = "Số lượng";
            this.SLg.MinimumWidth = 6;
            this.SLg.Name = "SLg";
            this.SLg.ReadOnly = true;
            // 
            // ĐG
            // 
            this.ĐG.HeaderText = "Đơn giá";
            this.ĐG.MinimumWidth = 6;
            this.ĐG.Name = "ĐG";
            this.ĐG.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.HeaderText = "Thành tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // dgvHH
            // 
            this.dgvHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHH.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SL,
            this.DV,
            this.Gia});
            this.dgvHH.Location = new System.Drawing.Point(6, 27);
            this.dgvHH.Name = "dgvHH";
            this.dgvHH.RowHeadersWidth = 51;
            this.dgvHH.RowTemplate.Height = 24;
            this.dgvHH.Size = new System.Drawing.Size(556, 300);
            this.dgvHH.TabIndex = 0;
            this.dgvHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHH_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DV
            // 
            this.DV.HeaderText = "Đơn vị";
            this.DV.MinimumWidth = 6;
            this.DV.Name = "DV";
            this.DV.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatHang";
            this.Text = "DatHang";
            this.Load += new System.EventHandler(this.DatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHH;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAdd_Change;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveDH;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ĐG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
    }
}
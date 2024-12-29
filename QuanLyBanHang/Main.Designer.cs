namespace QuanLyBanHang
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_find = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGV_SqlData = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_find = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_guide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_ItemList = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_DELETE = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Order = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_bill = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_ADD = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_EXIT = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SqlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.BTN_ItemList);
            this.panel1.Controls.Add(this.BTN_DELETE);
            this.panel1.Controls.Add(this.BTN_Order);
            this.panel1.Controls.Add(this.BTN_bill);
            this.panel1.Controls.Add(this.BTN_ADD);
            this.panel1.Location = new System.Drawing.Point(30, 274);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 465);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TXT_find
            // 
            this.TXT_find.AutoRoundedCorners = true;
            this.TXT_find.BorderRadius = 29;
            this.TXT_find.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_find.DefaultText = "";
            this.TXT_find.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXT_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXT_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_find.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_find.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXT_find.ForeColor = System.Drawing.Color.MediumPurple;
            this.TXT_find.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_find.Location = new System.Drawing.Point(529, 14);
            this.TXT_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_find.Name = "TXT_find";
            this.TXT_find.PasswordChar = '\0';
            this.TXT_find.PlaceholderText = "";
            this.TXT_find.SelectedText = "";
            this.TXT_find.Size = new System.Drawing.Size(1011, 60);
            this.TXT_find.TabIndex = 5;
            // 
            // DGV_SqlData
            // 
            this.DGV_SqlData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SqlData.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.DGV_SqlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SqlData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.SoLuong,
            this.DVT,
            this.GiaBan,
            this.MaKho,
            this.MaNCC});
            this.DGV_SqlData.Location = new System.Drawing.Point(347, 84);
            this.DGV_SqlData.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_SqlData.Name = "DGV_SqlData";
            this.DGV_SqlData.RowHeadersWidth = 51;
            this.DGV_SqlData.Size = new System.Drawing.Size(1193, 655);
            this.DGV_SqlData.TabIndex = 7;
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "Mã hàng hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // TenHH
            // 
            this.TenHH.HeaderText = "Tên hàng hóa";
            this.TenHH.MinimumWidth = 6;
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng tồn";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // MaKho
            // 
            this.MaKho.HeaderText = "Mã kho hàng";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.ReadOnly = true;
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // BTN_find
            // 
            this.BTN_find.AutoRoundedCorners = true;
            this.BTN_find.BorderRadius = 31;
            this.BTN_find.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_find.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_find.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BTN_find.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_find.ForeColor = System.Drawing.Color.White;
            this.BTN_find.Image = global::QuanLyBanHang.Properties.Resources.search;
            this.BTN_find.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_find.Location = new System.Drawing.Point(347, 14);
            this.BTN_find.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_find.Name = "BTN_find";
            this.BTN_find.Size = new System.Drawing.Size(175, 65);
            this.BTN_find.TabIndex = 6;
            this.BTN_find.Text = "TÌM KIẾM";
            this.BTN_find.Click += new System.EventHandler(this.BTN_find_Click);
            // 
            // BTN_guide
            // 
            this.BTN_guide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_guide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_guide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_guide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_guide.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_guide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_guide.ForeColor = System.Drawing.Color.White;
            this.BTN_guide.Image = global::QuanLyBanHang.Properties.Resources.question;
            this.BTN_guide.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_guide.Location = new System.Drawing.Point(249, 7);
            this.BTN_guide.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_guide.Name = "BTN_guide";
            this.BTN_guide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_guide.Size = new System.Drawing.Size(76, 63);
            this.BTN_guide.TabIndex = 4;
            // 
            // BTN_ItemList
            // 
            this.BTN_ItemList.AutoRoundedCorners = true;
            this.BTN_ItemList.BorderRadius = 31;
            this.BTN_ItemList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_ItemList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_ItemList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_ItemList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_ItemList.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BTN_ItemList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ItemList.ForeColor = System.Drawing.Color.White;
            this.BTN_ItemList.Image = global::QuanLyBanHang.Properties.Resources.list_check;
            this.BTN_ItemList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_ItemList.Location = new System.Drawing.Point(11, 305);
            this.BTN_ItemList.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ItemList.Name = "BTN_ItemList";
            this.BTN_ItemList.Size = new System.Drawing.Size(268, 65);
            this.BTN_ItemList.TabIndex = 5;
            this.BTN_ItemList.Text = "THỐNG KÊ";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.AutoRoundedCorners = true;
            this.BTN_DELETE.BorderRadius = 31;
            this.BTN_DELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_DELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_DELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_DELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_DELETE.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BTN_DELETE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE.Image = global::QuanLyBanHang.Properties.Resources.basket_shopping_minus;
            this.BTN_DELETE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_DELETE.Location = new System.Drawing.Point(11, 159);
            this.BTN_DELETE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(268, 65);
            this.BTN_DELETE.TabIndex = 4;
            this.BTN_DELETE.Text = "Quản Lý Đơn Đặt Hàng";
            this.BTN_DELETE.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BTN_Order
            // 
            this.BTN_Order.AutoRoundedCorners = true;
            this.BTN_Order.BorderRadius = 31;
            this.BTN_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Order.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BTN_Order.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_Order.ForeColor = System.Drawing.Color.White;
            this.BTN_Order.Image = global::QuanLyBanHang.Properties.Resources.box_circle_check;
            this.BTN_Order.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Order.Location = new System.Drawing.Point(11, 14);
            this.BTN_Order.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Order.Name = "BTN_Order";
            this.BTN_Order.Size = new System.Drawing.Size(268, 64);
            this.BTN_Order.TabIndex = 3;
            this.BTN_Order.Text = "ĐẶT HÀNG";
            this.BTN_Order.Click += new System.EventHandler(this.BTN_Order_Click);
            // 
            // BTN_bill
            // 
            this.BTN_bill.AutoRoundedCorners = true;
            this.BTN_bill.BorderRadius = 31;
            this.BTN_bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_bill.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BTN_bill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_bill.ForeColor = System.Drawing.Color.White;
            this.BTN_bill.Image = global::QuanLyBanHang.Properties.Resources.receipt;
            this.BTN_bill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_bill.Location = new System.Drawing.Point(11, 232);
            this.BTN_bill.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_bill.Name = "BTN_bill";
            this.BTN_bill.Size = new System.Drawing.Size(268, 65);
            this.BTN_bill.TabIndex = 2;
            this.BTN_bill.Text = "IN HÓA ĐƠN";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.AutoRoundedCorners = true;
            this.BTN_ADD.BorderRadius = 31;
            this.BTN_ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_ADD.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BTN_ADD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD.Image = global::QuanLyBanHang.Properties.Resources.cart_arrow_down;
            this.BTN_ADD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_ADD.Location = new System.Drawing.Point(11, 86);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(268, 65);
            this.BTN_ADD.TabIndex = 0;
            this.BTN_ADD.Text = "QUẢN LÝ MẶT HÀNG";
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_minimize
            // 
            this.BTN_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_minimize.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_minimize.ForeColor = System.Drawing.Color.White;
            this.BTN_minimize.Image = global::QuanLyBanHang.Properties.Resources.compress;
            this.BTN_minimize.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_minimize.Location = new System.Drawing.Point(152, 7);
            this.BTN_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_minimize.Name = "BTN_minimize";
            this.BTN_minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_minimize.Size = new System.Drawing.Size(76, 63);
            this.BTN_minimize.TabIndex = 1;
            this.BTN_minimize.Click += new System.EventHandler(this.BTN_minimize_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_EXIT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_EXIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_EXIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_EXIT.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_EXIT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.Image = global::QuanLyBanHang.Properties.Resources.XXXXXXXXXXXX1;
            this.BTN_EXIT.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_EXIT.Location = new System.Drawing.Point(58, 7);
            this.BTN_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_EXIT.Size = new System.Drawing.Size(76, 63);
            this.BTN_EXIT.TabIndex = 0;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyBanHang.Properties.Resources.maid_catttttttt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(72, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1556, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_SqlData);
            this.Controls.Add(this.BTN_find);
            this.Controls.Add(this.TXT_find);
            this.Controls.Add(this.BTN_guide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_minimize);
            this.Controls.Add(this.BTN_EXIT);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SqlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton BTN_EXIT;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_minimize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BTN_ADD;
        private Guna.UI2.WinForms.Guna2Button BTN_bill;
        private Guna.UI2.WinForms.Guna2Button BTN_Order;
        private Guna.UI2.WinForms.Guna2Button BTN_DELETE;
        private Guna.UI2.WinForms.Guna2Button BTN_ItemList;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_guide;
        private Guna.UI2.WinForms.Guna2TextBox TXT_find;
        private Guna.UI2.WinForms.Guna2Button BTN_find;
        private System.Windows.Forms.DataGridView DGV_SqlData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
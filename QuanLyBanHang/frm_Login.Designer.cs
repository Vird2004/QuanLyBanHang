namespace QuanLyBanHang
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.LBL_AppName = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.BTN_ViewPass = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_LOGIN = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.LBL_pass = new System.Windows.Forms.Label();
            this.LBL_user = new System.Windows.Forms.Label();
            this.GPB_BUNNY = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BTN_GUIDE = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPB_BUNNY)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_AppName
            // 
            this.LBL_AppName.AutoSize = true;
            this.LBL_AppName.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AppName.ForeColor = System.Drawing.Color.MediumPurple;
            this.LBL_AppName.Location = new System.Drawing.Point(-1, 18);
            this.LBL_AppName.Name = "LBL_AppName";
            this.LBL_AppName.Size = new System.Drawing.Size(429, 48);
            this.LBL_AppName.TabIndex = 0;
            this.LBL_AppName.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbLogin.Controls.Add(this.BTN_ViewPass);
            this.gbLogin.Controls.Add(this.BTN_LOGIN);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.LBL_pass);
            this.gbLogin.Controls.Add(this.LBL_user);
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(7, 72);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(435, 303);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Thông tin đăng nhập";
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
            // 
            // BTN_ViewPass
            // 
            this.BTN_ViewPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_ViewPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_ViewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_ViewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_ViewPass.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_ViewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_ViewPass.ForeColor = System.Drawing.Color.White;
            this.BTN_ViewPass.Image = global::QuanLyBanHang.Properties.Resources.view;
            this.BTN_ViewPass.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_ViewPass.Location = new System.Drawing.Point(350, 155);
            this.BTN_ViewPass.Name = "BTN_ViewPass";
            this.BTN_ViewPass.Size = new System.Drawing.Size(49, 34);
            this.BTN_ViewPass.TabIndex = 14;
            this.BTN_ViewPass.Click += new System.EventHandler(this.BTN_ViewPass_Click);
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.AutoRoundedCorners = true;
            this.BTN_LOGIN.BorderRadius = 29;
            this.BTN_LOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_LOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_LOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_LOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_LOGIN.FillColor = System.Drawing.Color.MediumPurple;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.Black;
            this.BTN_LOGIN.Location = new System.Drawing.Point(106, 212);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(216, 60);
            this.BTN_LOGIN.TabIndex = 12;
            this.BTN_LOGIN.Text = "LOG IN";
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 18;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(23, 155);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(321, 38);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtUsername.BorderRadius = 18;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(23, 69);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(321, 38);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // LBL_pass
            // 
            this.LBL_pass.AutoSize = true;
            this.LBL_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_pass.Location = new System.Drawing.Point(5, 114);
            this.LBL_pass.Name = "LBL_pass";
            this.LBL_pass.Size = new System.Drawing.Size(114, 24);
            this.LBL_pass.TabIndex = 5;
            this.LBL_pass.Text = "Password:";
            // 
            // LBL_user
            // 
            this.LBL_user.AutoSize = true;
            this.LBL_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_user.Location = new System.Drawing.Point(5, 41);
            this.LBL_user.Name = "LBL_user";
            this.LBL_user.Size = new System.Drawing.Size(119, 24);
            this.LBL_user.TabIndex = 4;
            this.LBL_user.Text = "Username:";
            // 
            // GPB_BUNNY
            // 
            this.GPB_BUNNY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GPB_BUNNY.BackgroundImage = global::QuanLyBanHang.Properties.Resources.nhau_dancing_in_maid_oufit;
            this.GPB_BUNNY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GPB_BUNNY.Cursor = System.Windows.Forms.Cursors.Default;
            this.GPB_BUNNY.Image = global::QuanLyBanHang.Properties.Resources.nhau_dancing_in_maid_oufit;
            this.GPB_BUNNY.ImageRotate = 0F;
            this.GPB_BUNNY.Location = new System.Drawing.Point(462, 72);
            this.GPB_BUNNY.Name = "GPB_BUNNY";
            this.GPB_BUNNY.Size = new System.Drawing.Size(190, 303);
            this.GPB_BUNNY.TabIndex = 5;
            this.GPB_BUNNY.TabStop = false;
            // 
            // BTN_GUIDE
            // 
            this.BTN_GUIDE.BackColor = System.Drawing.Color.Transparent;
            this.BTN_GUIDE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_GUIDE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_GUIDE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_GUIDE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_GUIDE.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_GUIDE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_GUIDE.ForeColor = System.Drawing.Color.White;
            this.BTN_GUIDE.Image = global::QuanLyBanHang.Properties.Resources.question;
            this.BTN_GUIDE.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_GUIDE.IndicateFocus = true;
            this.BTN_GUIDE.Location = new System.Drawing.Point(533, 19);
            this.BTN_GUIDE.Name = "BTN_GUIDE";
            this.BTN_GUIDE.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_GUIDE.Size = new System.Drawing.Size(48, 47);
            this.BTN_GUIDE.TabIndex = 4;
            this.BTN_GUIDE.UseTransparentBackground = true;
            this.BTN_GUIDE.Click += new System.EventHandler(this.BTN_GUIDE_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::QuanLyBanHang.Properties.Resources.XXXXXXXXXXXX1;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.IndicateFocus = true;
            this.btnExit.Location = new System.Drawing.Point(604, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(48, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.BTN_LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.GPB_BUNNY);
            this.Controls.Add(this.BTN_GUIDE);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.LBL_AppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPB_BUNNY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_AppName;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label LBL_pass;
        private System.Windows.Forms.Label LBL_user;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button BTN_LOGIN;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_GUIDE;
        private Guna.UI2.WinForms.Guna2PictureBox GPB_BUNNY;
        private Guna.UI2.WinForms.Guna2Button BTN_ViewPass;
    }
}


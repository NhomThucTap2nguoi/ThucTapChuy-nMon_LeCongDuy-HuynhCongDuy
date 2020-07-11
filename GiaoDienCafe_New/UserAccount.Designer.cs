﻿namespace GiaoDienCafe_New
{
    partial class UserAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.dtgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.cbVitri = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtHienthi = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton22 = new Guna.UI.WinForms.GunaButton();
            this.btLammoi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaikhoan)).BeginInit();
            this.gunaPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTaikhoan
            // 
            this.dtgvTaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.PassWord,
            this.Type});
            this.dtgvTaikhoan.Location = new System.Drawing.Point(0, 216);
            this.dtgvTaikhoan.Name = "dtgvTaikhoan";
            this.dtgvTaikhoan.Size = new System.Drawing.Size(1265, 341);
            this.dtgvTaikhoan.TabIndex = 78;
            this.dtgvTaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTaikhoan_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tài khoản";
            this.UserName.Name = "UserName";
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên hiển thị";
            this.DisplayName.Name = "DisplayName";
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "Mật khẩu";
            this.PassWord.Name = "PassWord";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại";
            this.Type.Name = "Type";
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.BackColor = System.Drawing.Color.OldLace;
            this.gunaPanel8.Controls.Add(this.cbVitri);
            this.gunaPanel8.Controls.Add(this.gunaButton3);
            this.gunaPanel8.Controls.Add(this.btLammoi);
            this.gunaPanel8.Controls.Add(this.btSua);
            this.gunaPanel8.Controls.Add(this.btThem);
            this.gunaPanel8.Controls.Add(this.btXoa);
            this.gunaPanel8.Controls.Add(this.txtHienthi);
            this.gunaPanel8.Controls.Add(this.gunaLabel7);
            this.gunaPanel8.Controls.Add(this.txtMatkhau);
            this.gunaPanel8.Controls.Add(this.txtTaikhoan);
            this.gunaPanel8.Controls.Add(this.gunaLabel4);
            this.gunaPanel8.Controls.Add(this.gunaLabel3);
            this.gunaPanel8.Controls.Add(this.gunaLabel2);
            this.gunaPanel8.Controls.Add(this.gunaButton22);
            this.gunaPanel8.Location = new System.Drawing.Point(2, 2);
            this.gunaPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Size = new System.Drawing.Size(1263, 217);
            this.gunaPanel8.TabIndex = 77;
            // 
            // cbVitri
            // 
            this.cbVitri.BackColor = System.Drawing.Color.Transparent;
            this.cbVitri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVitri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVitri.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVitri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVitri.FocusedState.Parent = this.cbVitri;
            this.cbVitri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVitri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVitri.FormattingEnabled = true;
            this.cbVitri.HoverState.Parent = this.cbVitri;
            this.cbVitri.ItemHeight = 30;
            this.cbVitri.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbVitri.ItemsAppearance.Parent = this.cbVitri;
            this.cbVitri.Location = new System.Drawing.Point(533, 150);
            this.cbVitri.Name = "cbVitri";
            this.cbVitri.ShadowDecoration.Parent = this.cbVitri;
            this.cbVitri.Size = new System.Drawing.Size(68, 36);
            this.cbVitri.TabIndex = 80;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton3.Location = new System.Drawing.Point(991, 6);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(231, 34);
            this.gunaButton3.TabIndex = 78;
            this.gunaButton3.Text = "Chức Năng";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSua
            // 
            this.btSua.BorderRadius = 15;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Location = new System.Drawing.Point(991, 141);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(90, 50);
            this.btSua.TabIndex = 77;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BorderRadius = 15;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Location = new System.Drawing.Point(991, 59);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(90, 50);
            this.btThem.TabIndex = 76;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.BorderColor = System.Drawing.Color.Maroon;
            this.btXoa.BorderRadius = 15;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Location = new System.Drawing.Point(1132, 59);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(90, 50);
            this.btXoa.TabIndex = 74;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtHienthi
            // 
            this.txtHienthi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHienthi.DefaultText = "";
            this.txtHienthi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHienthi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHienthi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienthi.DisabledState.Parent = this.txtHienthi;
            this.txtHienthi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienthi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienthi.FocusedState.Parent = this.txtHienthi;
            this.txtHienthi.ForeColor = System.Drawing.Color.Black;
            this.txtHienthi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienthi.HoverState.Parent = this.txtHienthi;
            this.txtHienthi.Location = new System.Drawing.Point(510, 66);
            this.txtHienthi.Name = "txtHienthi";
            this.txtHienthi.PasswordChar = '\0';
            this.txtHienthi.PlaceholderText = "Nhập tên Hiển thị";
            this.txtHienthi.SelectedText = "";
            this.txtHienthi.ShadowDecoration.Parent = this.txtHienthi;
            this.txtHienthi.Size = new System.Drawing.Size(140, 37);
            this.txtHienthi.TabIndex = 68;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(367, 141);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel7.TabIndex = 66;
            this.gunaLabel7.Text = "Vị trí";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.Parent = this.txtMatkhau;
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.FocusedState.Parent = this.txtMatkhau;
            this.txtMatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.HoverState.Parent = this.txtMatkhau;
            this.txtMatkhau.Location = new System.Drawing.Point(175, 147);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '\0';
            this.txtMatkhau.PlaceholderText = "Nhập Mật khẩu";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.ShadowDecoration.Parent = this.txtMatkhau;
            this.txtMatkhau.Size = new System.Drawing.Size(132, 39);
            this.txtMatkhau.TabIndex = 61;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BorderColor = System.Drawing.Color.Black;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaikhoan.DefaultText = "";
            this.txtTaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.DisabledState.Parent = this.txtTaikhoan;
            this.txtTaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.FocusedState.Parent = this.txtTaikhoan;
            this.txtTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.HoverState.Parent = this.txtTaikhoan;
            this.txtTaikhoan.Location = new System.Drawing.Point(175, 66);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PasswordChar = '\0';
            this.txtTaikhoan.PlaceholderText = "Nhập Tên tài khoản";
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.ShadowDecoration.Parent = this.txtTaikhoan;
            this.txtTaikhoan.Size = new System.Drawing.Size(132, 37);
            this.txtTaikhoan.TabIndex = 60;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(28, 141);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel4.TabIndex = 58;
            this.gunaLabel4.Text = "Mật khẩu";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(28, 59);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel3.TabIndex = 56;
            this.gunaLabel3.Text = "Tài khoản";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(367, 66);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel2.TabIndex = 54;
            this.gunaLabel2.Text = "Tên hiển thị";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaButton22
            // 
            this.gunaButton22.AnimationHoverSpeed = 0.07F;
            this.gunaButton22.AnimationSpeed = 0.03F;
            this.gunaButton22.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton22.BorderColor = System.Drawing.Color.Black;
            this.gunaButton22.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton22.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton22.ForeColor = System.Drawing.Color.Black;
            this.gunaButton22.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton22.Image")));
            this.gunaButton22.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton22.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton22.Location = new System.Drawing.Point(218, 6);
            this.gunaButton22.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton22.Name = "gunaButton22";
            this.gunaButton22.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton22.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton22.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton22.OnHoverImage = null;
            this.gunaButton22.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton22.Size = new System.Drawing.Size(519, 34);
            this.gunaButton22.TabIndex = 30;
            this.gunaButton22.Text = "Thông Tin Hàng";
            this.gunaButton22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btLammoi
            // 
            this.btLammoi.BorderRadius = 15;
            this.btLammoi.CheckedState.Parent = this.btLammoi;
            this.btLammoi.CustomImages.Parent = this.btLammoi;
            this.btLammoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLammoi.ForeColor = System.Drawing.Color.Black;
            this.btLammoi.HoverState.Parent = this.btLammoi;
            this.btLammoi.Location = new System.Drawing.Point(1132, 136);
            this.btLammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btLammoi.Name = "btLammoi";
            this.btLammoi.ShadowDecoration.Parent = this.btLammoi;
            this.btLammoi.Size = new System.Drawing.Size(90, 50);
            this.btLammoi.TabIndex = 75;
            this.btLammoi.Text = "Làm mới";
            this.btLammoi.Click += new System.EventHandler(this.btLammoi_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvTaikhoan);
            this.Controls.Add(this.gunaPanel8);
            this.Name = "UserAccount";
            this.Size = new System.Drawing.Size(1283, 560);
            this.Load += new System.EventHandler(this.UserAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaikhoan)).EndInit();
            this.gunaPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        private Guna.UI2.WinForms.Guna2ComboBox cbVitri;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtHienthi;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTaikhoan;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton gunaButton22;
        private Guna.UI2.WinForms.Guna2Button btLammoi;
    }
}

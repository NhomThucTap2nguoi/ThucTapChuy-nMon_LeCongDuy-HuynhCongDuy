namespace GiaoDienCafe_New
{
    partial class UserDouong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDouong));
            this.dtgvDouong = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sss = new Guna.UI.WinForms.GunaPanel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbDanhmuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenmon = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton22 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDouong)).BeginInit();
            this.sss.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDouong
            // 
            this.dtgvDouong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDouong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDouong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.price});
            this.dtgvDouong.Location = new System.Drawing.Point(3, 225);
            this.dtgvDouong.Name = "dtgvDouong";
            this.dtgvDouong.Size = new System.Drawing.Size(1263, 335);
            this.dtgvDouong.TabIndex = 79;
            this.dtgvDouong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDouong_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID đồ uống";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Đồ uống";
            this.name.Name = "name";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Loại đồ uống";
            this.idCategory.Name = "idCategory";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // sss
            // 
            this.sss.BackColor = System.Drawing.Color.OldLace;
            this.sss.Controls.Add(this.txtPrice);
            this.sss.Controls.Add(this.cbDanhmuc);
            this.sss.Controls.Add(this.gunaButton3);
            this.sss.Controls.Add(this.btSua);
            this.sss.Controls.Add(this.btThem);
            this.sss.Controls.Add(this.btXoa);
            this.sss.Controls.Add(this.txtTenmon);
            this.sss.Controls.Add(this.gunaLabel7);
            this.sss.Controls.Add(this.txtID);
            this.sss.Controls.Add(this.gunaLabel4);
            this.sss.Controls.Add(this.gunaLabel3);
            this.sss.Controls.Add(this.gunaLabel2);
            this.sss.Controls.Add(this.gunaButton22);
            this.sss.Location = new System.Drawing.Point(2, 2);
            this.sss.Margin = new System.Windows.Forms.Padding(2);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(1264, 261);
            this.sss.TabIndex = 78;
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(708, 149);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 34);
            this.txtPrice.TabIndex = 81;
            // 
            // cbDanhmuc
            // 
            this.cbDanhmuc.BackColor = System.Drawing.Color.Transparent;
            this.cbDanhmuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhmuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDanhmuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDanhmuc.FocusedState.Parent = this.cbDanhmuc;
            this.cbDanhmuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDanhmuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDanhmuc.FormattingEnabled = true;
            this.cbDanhmuc.HoverState.Parent = this.cbDanhmuc;
            this.cbDanhmuc.ItemHeight = 30;
            this.cbDanhmuc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbDanhmuc.ItemsAppearance.Parent = this.cbDanhmuc;
            this.cbDanhmuc.Location = new System.Drawing.Point(218, 139);
            this.cbDanhmuc.Name = "cbDanhmuc";
            this.cbDanhmuc.ShadowDecoration.Parent = this.cbDanhmuc;
            this.cbDanhmuc.Size = new System.Drawing.Size(140, 36);
            this.cbDanhmuc.TabIndex = 80;
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
            this.gunaButton3.Location = new System.Drawing.Point(970, 6);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(267, 34);
            this.gunaButton3.TabIndex = 78;
            this.gunaButton3.Text = "Chức Năng";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSua
            // 
            this.btSua.BorderRadius = 15;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Location = new System.Drawing.Point(1055, 144);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(100, 50);
            this.btSua.TabIndex = 77;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BorderRadius = 15;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Location = new System.Drawing.Point(970, 66);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(100, 50);
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
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Location = new System.Drawing.Point(1137, 66);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(100, 50);
            this.btXoa.TabIndex = 74;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtTenmon
            // 
            this.txtTenmon.BorderColor = System.Drawing.Color.Black;
            this.txtTenmon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenmon.DefaultText = "";
            this.txtTenmon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenmon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenmon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenmon.DisabledState.Parent = this.txtTenmon;
            this.txtTenmon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenmon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenmon.FocusedState.Parent = this.txtTenmon;
            this.txtTenmon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenmon.HoverState.Parent = this.txtTenmon;
            this.txtTenmon.Location = new System.Drawing.Point(708, 66);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.PasswordChar = '\0';
            this.txtTenmon.PlaceholderText = "Nhập tên Hiển thị";
            this.txtTenmon.SelectedText = "";
            this.txtTenmon.ShadowDecoration.Parent = this.txtTenmon;
            this.txtTenmon.Size = new System.Drawing.Size(140, 34);
            this.txtTenmon.TabIndex = 68;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(454, 133);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel7.TabIndex = 66;
            this.gunaLabel7.Text = "Giá";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(218, 66);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "Nhập Tên tài khoản";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(140, 34);
            this.txtID.TabIndex = 60;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(61, 125);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel4.TabIndex = 58;
            this.gunaLabel4.Text = "Danh mục";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(61, 58);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel3.TabIndex = 56;
            this.gunaLabel3.Text = "ID";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(454, 58);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel2.TabIndex = 54;
            this.gunaLabel2.Text = "Tên Món";
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
            this.gunaButton22.Location = new System.Drawing.Point(31, 6);
            this.gunaButton22.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton22.Name = "gunaButton22";
            this.gunaButton22.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton22.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton22.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton22.OnHoverImage = null;
            this.gunaButton22.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton22.Size = new System.Drawing.Size(817, 34);
            this.gunaButton22.TabIndex = 30;
            this.gunaButton22.Text = "Thông Tin Hàng";
            this.gunaButton22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserDouong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvDouong);
            this.Controls.Add(this.sss);
            this.Name = "UserDouong";
            this.Size = new System.Drawing.Size(1283, 560);
            this.Load += new System.EventHandler(this.UserDouong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDouong)).EndInit();
            this.sss.ResumeLayout(false);
            this.sss.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDouong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private Guna.UI.WinForms.GunaPanel sss;
        private System.Windows.Forms.TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbDanhmuc;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtTenmon;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton gunaButton22;
    }
}

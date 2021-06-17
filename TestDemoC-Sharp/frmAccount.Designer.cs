
namespace TestDemoC_Sharp
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.btManager = new Guna.UI.WinForms.GunaButton();
            this.btAccount = new Guna.UI.WinForms.GunaButton();
            this.btLogout = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientCircleButton1 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.btThem = new Guna.UI.WinForms.GunaButton();
            this.btSua = new Guna.UI.WinForms.GunaButton();
            this.btXoa = new Guna.UI.WinForms.GunaButton();
            this.btXem = new Guna.UI.WinForms.GunaButton();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btSearch = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btManager
            // 
            this.btManager.AnimationHoverSpeed = 0.07F;
            this.btManager.AnimationSpeed = 0.03F;
            this.btManager.BackColor = System.Drawing.Color.Transparent;
            this.btManager.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btManager.BorderColor = System.Drawing.Color.Black;
            this.btManager.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btManager.FocusedColor = System.Drawing.Color.Empty;
            this.btManager.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btManager.ForeColor = System.Drawing.Color.White;
            this.btManager.Image = ((System.Drawing.Image)(resources.GetObject("btManager.Image")));
            this.btManager.ImageSize = new System.Drawing.Size(20, 20);
            this.btManager.Location = new System.Drawing.Point(8, 217);
            this.btManager.Name = "btManager";
            this.btManager.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btManager.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btManager.OnHoverForeColor = System.Drawing.Color.White;
            this.btManager.OnHoverImage = null;
            this.btManager.OnPressedColor = System.Drawing.Color.Black;
            this.btManager.Radius = 15;
            this.btManager.Size = new System.Drawing.Size(131, 44);
            this.btManager.TabIndex = 7;
            this.btManager.Text = "Manager";
            this.btManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btManager.Click += new System.EventHandler(this.btManager_Click);
            // 
            // btAccount
            // 
            this.btAccount.AnimationHoverSpeed = 0.07F;
            this.btAccount.AnimationSpeed = 0.03F;
            this.btAccount.BackColor = System.Drawing.Color.Transparent;
            this.btAccount.BaseColor = System.Drawing.Color.Green;
            this.btAccount.BorderColor = System.Drawing.Color.Black;
            this.btAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btAccount.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.ForeColor = System.Drawing.Color.White;
            this.btAccount.Image = ((System.Drawing.Image)(resources.GetObject("btAccount.Image")));
            this.btAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btAccount.Location = new System.Drawing.Point(8, 288);
            this.btAccount.Name = "btAccount";
            this.btAccount.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btAccount.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.btAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btAccount.OnHoverImage = null;
            this.btAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btAccount.Radius = 15;
            this.btAccount.Size = new System.Drawing.Size(146, 48);
            this.btAccount.TabIndex = 8;
            this.btAccount.Text = "Account";
            this.btAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btLogout
            // 
            this.btLogout.AnimationHoverSpeed = 0.07F;
            this.btLogout.AnimationSpeed = 0.03F;
            this.btLogout.BackColor = System.Drawing.Color.Transparent;
            this.btLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btLogout.BorderColor = System.Drawing.Color.Black;
            this.btLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Image = ((System.Drawing.Image)(resources.GetObject("btLogout.Image")));
            this.btLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btLogout.Location = new System.Drawing.Point(8, 143);
            this.btLogout.Name = "btLogout";
            this.btLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btLogout.OnHoverImage = null;
            this.btLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btLogout.Radius = 15;
            this.btLogout.Size = new System.Drawing.Size(131, 44);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // gunaGradientCircleButton1
            // 
            this.gunaGradientCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton1.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientCircleButton1.BaseColor2 = System.Drawing.SystemColors.GrayText;
            this.gunaGradientCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.Image = null;
            this.gunaGradientCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton1.Location = new System.Drawing.Point(-251, 12);
            this.gunaGradientCircleButton1.Name = "gunaGradientCircleButton1";
            this.gunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.OnHoverImage = null;
            this.gunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.Size = new System.Drawing.Size(435, 446);
            this.gunaGradientCircleButton1.TabIndex = 6;
            // 
            // datagridview
            // 
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(228, 12);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(536, 353);
            this.datagridview.TabIndex = 10;
            // 
            // btThem
            // 
            this.btThem.AnimationHoverSpeed = 0.07F;
            this.btThem.AnimationSpeed = 0.03F;
            this.btThem.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btThem.BorderColor = System.Drawing.Color.Black;
            this.btThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btThem.FocusedColor = System.Drawing.Color.Empty;
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btThem.Location = new System.Drawing.Point(228, 396);
            this.btThem.Name = "btThem";
            this.btThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btThem.OnHoverImage = null;
            this.btThem.OnPressedColor = System.Drawing.Color.Black;
            this.btThem.Size = new System.Drawing.Size(117, 42);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Add";
            // 
            // btSua
            // 
            this.btSua.AnimationHoverSpeed = 0.07F;
            this.btSua.AnimationSpeed = 0.03F;
            this.btSua.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btSua.BorderColor = System.Drawing.Color.Black;
            this.btSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btSua.FocusedColor = System.Drawing.Color.Empty;
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btSua.Location = new System.Drawing.Point(369, 396);
            this.btSua.Name = "btSua";
            this.btSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btSua.OnHoverImage = null;
            this.btSua.OnPressedColor = System.Drawing.Color.Black;
            this.btSua.Size = new System.Drawing.Size(117, 42);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Update";
            // 
            // btXoa
            // 
            this.btXoa.AnimationHoverSpeed = 0.07F;
            this.btXoa.AnimationSpeed = 0.03F;
            this.btXoa.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btXoa.BorderColor = System.Drawing.Color.Black;
            this.btXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btXoa.Location = new System.Drawing.Point(510, 396);
            this.btXoa.Name = "btXoa";
            this.btXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btXoa.OnHoverImage = null;
            this.btXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btXoa.Size = new System.Drawing.Size(117, 42);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Delete";
            // 
            // btXem
            // 
            this.btXem.AnimationHoverSpeed = 0.07F;
            this.btXem.AnimationSpeed = 0.03F;
            this.btXem.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btXem.BorderColor = System.Drawing.Color.Black;
            this.btXem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btXem.FocusedColor = System.Drawing.Color.Empty;
            this.btXem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.White;
            this.btXem.Image = ((System.Drawing.Image)(resources.GetObject("btXem.Image")));
            this.btXem.ImageSize = new System.Drawing.Size(20, 20);
            this.btXem.Location = new System.Drawing.Point(647, 396);
            this.btXem.Name = "btXem";
            this.btXem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btXem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btXem.OnHoverForeColor = System.Drawing.Color.White;
            this.btXem.OnHoverImage = null;
            this.btXem.OnPressedColor = System.Drawing.Color.Black;
            this.btXem.Size = new System.Drawing.Size(117, 42);
            this.btXem.TabIndex = 11;
            this.btXem.Text = "Show";
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(823, 29);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(264, 20);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btSearch
            // 
            this.btSearch.AnimationHoverSpeed = 0.07F;
            this.btSearch.AnimationSpeed = 0.03F;
            this.btSearch.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btSearch.BorderColor = System.Drawing.Color.Black;
            this.btSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btSearch.Location = new System.Drawing.Point(970, 79);
            this.btSearch.Name = "btSearch";
            this.btSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btSearch.OnHoverImage = null;
            this.btSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btSearch.Size = new System.Drawing.Size(117, 42);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            // 
            // frmAccount
            // 
            this.AcceptButton = this.btAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btLogout;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.btManager);
            this.Controls.Add(this.btAccount);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.gunaGradientCircleButton1);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btManager;
        private Guna.UI.WinForms.GunaButton btAccount;
        private Guna.UI.WinForms.GunaButton btLogout;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton1;
        private System.Windows.Forms.DataGridView datagridview;
        private Guna.UI.WinForms.GunaButton btThem;
        private Guna.UI.WinForms.GunaButton btSua;
        private Guna.UI.WinForms.GunaButton btXoa;
        private Guna.UI.WinForms.GunaButton btXem;
        private System.Windows.Forms.TextBox txtsearch;
        private Guna.UI.WinForms.GunaButton btSearch;
    }
}
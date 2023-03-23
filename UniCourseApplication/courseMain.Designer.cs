
namespace UniCourseApplication
{
    partial class courseMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseMain));
            this.GunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.GunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.nav_settings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nav_history = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nav_profile = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nav_home = new Guna.UI.WinForms.GunaAdvenceButton();
            this.GunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.GunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaPanel1
            // 
            this.GunaPanel1.Location = new System.Drawing.Point(-1, 76);
            this.GunaPanel1.Name = "GunaPanel1";
            this.GunaPanel1.Size = new System.Drawing.Size(1264, 640);
            this.GunaPanel1.TabIndex = 72;
            // 
            // GunaPanel2
            // 
            this.GunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GunaPanel2.Controls.Add(this.PictureBox1);
            this.GunaPanel2.Controls.Add(this.nav_settings);
            this.GunaPanel2.Controls.Add(this.nav_history);
            this.GunaPanel2.Controls.Add(this.nav_profile);
            this.GunaPanel2.Controls.Add(this.nav_home);
            this.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.GunaPanel2.Name = "GunaPanel2";
            this.GunaPanel2.Size = new System.Drawing.Size(1279, 48);
            this.GunaPanel2.TabIndex = 70;
            // 
            // nav_settings
            // 
            this.nav_settings.Animated = true;
            this.nav_settings.AnimationHoverSpeed = 0.07F;
            this.nav_settings.AnimationSpeed = 0.03F;
            this.nav_settings.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_settings.BorderColor = System.Drawing.Color.Black;
            this.nav_settings.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.nav_settings.Checked = true;
            this.nav_settings.CheckedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_settings.CheckedBorderColor = System.Drawing.Color.Black;
            this.nav_settings.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_settings.CheckedImage = null;
            this.nav_settings.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nav_settings.FocusedColor = System.Drawing.Color.Empty;
            this.nav_settings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.nav_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_settings.Image = null;
            this.nav_settings.ImageSize = new System.Drawing.Size(20, 20);
            this.nav_settings.LineBottom = 4;
            this.nav_settings.LineColor = System.Drawing.Color.WhiteSmoke;
            this.nav_settings.Location = new System.Drawing.Point(80, 3);
            this.nav_settings.Name = "nav_settings";
            this.nav_settings.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nav_settings.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_settings.OnHoverImage = null;
            this.nav_settings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_settings.OnPressedColor = System.Drawing.Color.Black;
            this.nav_settings.OnPressedDepth = 0;
            this.nav_settings.Size = new System.Drawing.Size(112, 45);
            this.nav_settings.TabIndex = 3;
            this.nav_settings.Text = "Γενικά";
            this.nav_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nav_settings.Click += new System.EventHandler(this.nav_settings_Click);
            // 
            // nav_history
            // 
            this.nav_history.Animated = true;
            this.nav_history.AnimationHoverSpeed = 0.07F;
            this.nav_history.AnimationSpeed = 0.03F;
            this.nav_history.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_history.BorderColor = System.Drawing.Color.Black;
            this.nav_history.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.nav_history.CheckedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_history.CheckedBorderColor = System.Drawing.Color.Black;
            this.nav_history.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_history.CheckedImage = null;
            this.nav_history.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_history.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nav_history.FocusedColor = System.Drawing.Color.Empty;
            this.nav_history.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.nav_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_history.Image = null;
            this.nav_history.ImageSize = new System.Drawing.Size(20, 20);
            this.nav_history.LineBottom = 4;
            this.nav_history.LineColor = System.Drawing.Color.WhiteSmoke;
            this.nav_history.Location = new System.Drawing.Point(330, 3);
            this.nav_history.Name = "nav_history";
            this.nav_history.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_history.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nav_history.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_history.OnHoverImage = null;
            this.nav_history.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_history.OnPressedColor = System.Drawing.Color.Black;
            this.nav_history.OnPressedDepth = 0;
            this.nav_history.Size = new System.Drawing.Size(112, 45);
            this.nav_history.TabIndex = 2;
            this.nav_history.Text = "Εργασίες";
            this.nav_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nav_history.Click += new System.EventHandler(this.nav_history_Click);
            // 
            // nav_profile
            // 
            this.nav_profile.Animated = true;
            this.nav_profile.AnimationHoverSpeed = 0.07F;
            this.nav_profile.AnimationSpeed = 0.03F;
            this.nav_profile.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_profile.BorderColor = System.Drawing.Color.Black;
            this.nav_profile.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.nav_profile.CheckedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_profile.CheckedBorderColor = System.Drawing.Color.Black;
            this.nav_profile.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_profile.CheckedImage = null;
            this.nav_profile.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_profile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nav_profile.FocusedColor = System.Drawing.Color.Empty;
            this.nav_profile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.nav_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_profile.Image = null;
            this.nav_profile.ImageSize = new System.Drawing.Size(20, 20);
            this.nav_profile.LineBottom = 4;
            this.nav_profile.LineColor = System.Drawing.Color.WhiteSmoke;
            this.nav_profile.Location = new System.Drawing.Point(448, 3);
            this.nav_profile.Name = "nav_profile";
            this.nav_profile.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_profile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nav_profile.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_profile.OnHoverImage = null;
            this.nav_profile.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_profile.OnPressedColor = System.Drawing.Color.Black;
            this.nav_profile.OnPressedDepth = 0;
            this.nav_profile.Size = new System.Drawing.Size(112, 45);
            this.nav_profile.TabIndex = 1;
            this.nav_profile.Text = "MyFiles";
            this.nav_profile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nav_profile.Click += new System.EventHandler(this.nav_profile_Click);
            // 
            // nav_home
            // 
            this.nav_home.Animated = true;
            this.nav_home.AnimationHoverSpeed = 0.07F;
            this.nav_home.AnimationSpeed = 0.03F;
            this.nav_home.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_home.BorderColor = System.Drawing.Color.Black;
            this.nav_home.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.nav_home.CheckedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_home.CheckedBorderColor = System.Drawing.Color.Black;
            this.nav_home.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_home.CheckedImage = null;
            this.nav_home.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nav_home.FocusedColor = System.Drawing.Color.Empty;
            this.nav_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.nav_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_home.Image = null;
            this.nav_home.ImageSize = new System.Drawing.Size(20, 20);
            this.nav_home.LineBottom = 4;
            this.nav_home.LineColor = System.Drawing.Color.WhiteSmoke;
            this.nav_home.Location = new System.Drawing.Point(198, 3);
            this.nav_home.Name = "nav_home";
            this.nav_home.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.nav_home.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nav_home.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.nav_home.OnHoverImage = null;
            this.nav_home.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.nav_home.OnPressedColor = System.Drawing.Color.Black;
            this.nav_home.OnPressedDepth = 0;
            this.nav_home.Size = new System.Drawing.Size(126, 45);
            this.nav_home.TabIndex = 0;
            this.nav_home.Text = "Υλικό";
            this.nav_home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nav_home.Click += new System.EventHandler(this.nav_home_Click);
            // 
            // GunaSeparator1
            // 
            this.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.GunaSeparator1.Location = new System.Drawing.Point(-4, 60);
            this.GunaSeparator1.Name = "GunaSeparator1";
            this.GunaSeparator1.Size = new System.Drawing.Size(1287, 10);
            this.GunaSeparator1.TabIndex = 71;
            this.GunaSeparator1.Click += new System.EventHandler(this.GunaSeparator1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(4, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(43, 39);
            this.PictureBox1.TabIndex = 18;
            this.PictureBox1.TabStop = false;
            // 
            // courseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 722);
            this.Controls.Add(this.GunaPanel1);
            this.Controls.Add(this.GunaPanel2);
            this.Controls.Add(this.GunaSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "courseMain";
            this.Text = "courseMain";
            this.Load += new System.EventHandler(this.courseMain_Load);
            this.GunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI.WinForms.GunaPanel GunaPanel1;
        internal Guna.UI.WinForms.GunaPanel GunaPanel2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal Guna.UI.WinForms.GunaAdvenceButton nav_settings;
        internal Guna.UI.WinForms.GunaAdvenceButton nav_history;
        internal Guna.UI.WinForms.GunaAdvenceButton nav_profile;
        internal Guna.UI.WinForms.GunaAdvenceButton nav_home;
        internal Guna.UI.WinForms.GunaSeparator GunaSeparator1;
        internal System.Windows.Forms.Timer Timer1;
    }
}

namespace UniCourseApplication
{
    partial class agaphmena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agaphmena));
            this.GunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.Label1 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaSeparator1
            // 
            this.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.GunaSeparator1.Location = new System.Drawing.Point(-60, 53);
            this.GunaSeparator1.Name = "GunaSeparator1";
            this.GunaSeparator1.Size = new System.Drawing.Size(1287, 10);
            this.GunaSeparator1.TabIndex = 117;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(199)))));
            this.Label1.Location = new System.Drawing.Point(75, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(499, 33);
            this.Label1.TabIndex = 116;
            this.Label1.Text = "Κατάλογος Αγαπημένων Μαθημάτων";
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(1167, 632);
            this.FlowLayoutPanel1.TabIndex = 114;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(5, 6);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(52, 43);
            this.PictureBox1.TabIndex = 115;
            this.PictureBox1.TabStop = false;
            // 
            // agaphmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1167, 700);
            this.Controls.Add(this.GunaSeparator1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agaphmena";
            this.Text = "agaphmena";
            this.Load += new System.EventHandler(this.agaphmena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI.WinForms.GunaSeparator GunaSeparator1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
    }
}
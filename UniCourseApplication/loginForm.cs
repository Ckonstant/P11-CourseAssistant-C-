using Microsoft.VisualBasic;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCourseApplication
{
    public partial class loginForm : Form
    {
        private int i = 0;
        public loginForm()
        {
            InitializeComponent();
        }

        public void loginForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + @"\FULLDATA\"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\FULLDATA\");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
                i += 1;
                if (i == 25)
                {
                    this.Timer1.Stop();
                    this.GunaGradient2Panel1.Visible = false;
                    this.GunaGradient2Panel2.Visible = true;
                    // GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
                    i = 0;
                    if (this.GunaLineTextBox1.Text == "betatester" & this.GunaLineTextBox2.Text == "betatester")
                    {
                    Form1 secondForm = new Form1();
                    secondForm.Show();
                    this.Hide();
                    }
                    else
                    {
                        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                        MessageBoxAdv.Show("Λανθασμένο Συνθηματικό/Κωδικός!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
        }

        private void GunaGradient2Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.GunaGradient2Panel1.Visible = true;
                this.GunaGradient2Panel2.Visible = false;
                this.Timer1.Start();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        private void GunaPictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void PictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.GunaGradient2Panel1.Visible = true;
                this.GunaGradient2Panel2.Visible = false;
                this.Timer1.Start();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        private void GunaLabel1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
        private void GunaLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.GunaGradient2Panel1.Visible = true;
                this.GunaGradient2Panel2.Visible = false;
                this.Timer1.Start();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        private void GunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void GunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void GunaLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Δεν είναι εφικτή η δημιουργία προφίλ στο Beta Testing.", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void GunaLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                this.GunaGradient2Panel1.Visible = true;
                this.GunaGradient2Panel2.Visible = false;
                this.Timer1.Start();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                this.GunaGradient2Panel1.Visible = true;
                this.GunaGradient2Panel2.Visible = false;
                this.Timer1.Start();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void GunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Όνομα Χρήστη : betatester" + Constants.vbNewLine + "Κωδικός Χρήστη : betatester", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GunaGradient2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

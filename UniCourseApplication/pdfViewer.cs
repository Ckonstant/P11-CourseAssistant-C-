using Microsoft.VisualBasic;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCourseApplication
{
    public partial class pdfViewer : Form
    {
        public pdfViewer()
        {
            InitializeComponent();
        }

        private void GunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        courseFiles coursef = Application.OpenForms.OfType<courseFiles>().FirstOrDefault();
        courseMain courseM = Application.OpenForms.OfType<courseMain>().FirstOrDefault();
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        labs labor = Application.OpenForms.OfType<labs>().FirstOrDefault();
        private void pdfViewer_Load(object sender, EventArgs e)
        {
            //Interaction.MsgBox("hello"+form1.fullpathview);
            try
            {
                if (form1.windowFlag == false)
                {
                    this.PictureBox2.Visible = true;
                    this.PictureBox3.Visible = false;
                    this.PictureBox4.Visible = false;
                    this.PictureBox5.Visible = false;
                }
                else
                {
                    this.PictureBox2.Visible = false;
                    this.PictureBox3.Visible = true;
                    this.PictureBox4.Visible = true;
                    this.PictureBox5.Visible = true;
                }
                this.BringToFront();
                this.GunaLabel1.Text = form1.fullpathview;
                this.AxAcroPDF1.LoadFile(form1.fullpathview);
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε το Adobe PDF Reader Dll.Παρακαλώ κατεβάστε το πακέτο!" + Constants.vbNewLine + "https://get.adobe.com/uk/reader/", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        courseMain cmain = Application.OpenForms.OfType<courseMain>().FirstOrDefault();
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (form1.pdfFlag == true)
                    {
                    coursef.GunaPanel3.Visible = false;
                }
                if (form1.pdfFlag == false)
                {
                    labor.GunaPanel3.Visible = false;
                }
                //form1.windowFlag = false;
               
                    //coursef.GunaPanel3.Visible = false;
               
                   // labor.GunaPanel3.Visible = false;
                 
                // WindowsApp1.My.MyProject.Forms.labs.GunaPanel3.Visible = false;

                this.Close();
               // if (Application.OpenForms.OfType<pdfViewer>().Any() | Application.OpenForms.OfType<General>().Any())
                //{
                  //  courseMain coursfile = new courseMain();
                  //  cmain.openChildForm(coursfile);
              //  }
              //  else
              //  {
              //      courseFiles coursfile = new courseFiles();
              //      cmain.openChildForm(coursfile);
             //   }

            }
            // Form1.Show()
            // Form1.BringToFront()
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private Form currentForm = default;

        public void openChildForm(Form childForm)
        {
            // ' GunaTransition1.HideSync(currentForm)
            if (currentForm != null)
                currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            GunaPanel1.Controls.Add(childForm);
            GunaPanel1.Tag = childForm;
            childForm.BringToFront();


            childForm.Show();

        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    form1.windowFlag = true;
                    var fn = new pdfViewer();
                    // Form1.Hide()
                    fn.Show();
                    fn.WindowState = FormWindowState.Maximized;
                    this.PictureBox3.Visible = false;
                    this.PictureBox2.Visible = true;
                    fn.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    fn.ControlBox = false;
                }

                else
                {
                    form1.windowFlag = false;
                    this.Close();
                    this.PictureBox2.Visible = false;
                    this.PictureBox3.Visible = true;
                    // Form1.Show()
                    form1.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            coursef.GunaPanel3.Visible = false;
           // WindowsApp1.My.MyProject.Forms.labs.GunaPanel3.Visible = false;
            form1.windowFlag = false;
            form1.Show();
            form1.BringToFront();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void AxAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }

}

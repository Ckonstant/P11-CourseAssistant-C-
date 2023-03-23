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
    public partial class courseMain : Form
    {
        public courseMain()
        {
            InitializeComponent();
        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public bool pdfFormFlag = true;
        private void GunaSeparator1_Click(object sender, EventArgs e)
        {

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

        private void courseMain_Load(object sender, EventArgs e)
        {
            General gen = new General();
            this.openChildForm(gen);
        }
        private void nav_home_Click(object sender, EventArgs e)
        {
            form1.pdfFlag = true;
            if (Application.OpenForms.OfType<courseFiles>().Any() | Application.OpenForms.OfType<General>().Any())
            {
                courseFiles coursfile = new courseFiles();
                this.openChildForm(coursfile);
            }
            else
            {
                courseFiles coursfile = new courseFiles();
                this.openChildForm(coursfile);
            }
        }
        private void nav_settings_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<courseFiles>().Any() | Application.OpenForms.OfType<General>().Any())
            {
                General gen = new General();
                this.openChildForm(gen);
            }
            else
            {
                General gen = new General();
                this.openChildForm(gen);
            }
        }

        private void nav_history_Click(object sender, EventArgs e)
        {
            form1.pdfFlag = false;
            if (Application.OpenForms.OfType<courseFiles>().Any() | Application.OpenForms.OfType<General>().Any() | Application.OpenForms.OfType<labs>().Any())
            {
                labs lab = new labs();
                this.openChildForm(lab);
            }
            else
            {
                labs lab = new labs();
                this.openChildForm(lab);
            }
        }

        private void nav_profile_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<courseFiles>().Any() | Application.OpenForms.OfType<General>().Any() | Application.OpenForms.OfType<labs>().Any() | Application.OpenForms.OfType<myFiles>().Any())
            {
                myFiles myf = new myFiles();
                this.openChildForm(myf);
            }
            else
            {
                myFiles myf = new myFiles();
                this.openChildForm(myf);
            }
        }

    }
}

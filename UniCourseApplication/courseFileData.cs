using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Syncfusion.Windows.Forms;

namespace UniCourseApplication
{
    public partial class courseFileData : UserControl
    {
        private string s;
        public string pathView;
        public courseFileData()
        {
            InitializeComponent();
        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        courseFiles coursef = Application.OpenForms.OfType<courseFiles>().FirstOrDefault();
        courseMain courseM = Application.OpenForms.OfType<courseMain>().FirstOrDefault();
        labs labor = Application.OpenForms.OfType<labs>().FirstOrDefault();
        private void GunaLabel1_Click(object sender, EventArgs e)
        {
            int pos = 0;
            foreach (var x in form1.names)
            {

                if (x.Equals("Ηλεκτρονική"))
                {
                    Interaction.MsgBox(pos);
                }
                pos += 1;
            }

        }
        private void BackUpDataBase(string filePath)
        {

            if (File.Exists(this.GunaLabel4.Text))
            {
                File.Copy(this.GunaLabel4.Text, filePath);
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Επιτυχής αποθήκευση αρχείου.", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void courseFileData_Load(object sender, EventArgs e)
        {
            this.GunaContextMenuStrip1.Cursor = Cursors.Hand;
            if (this.GunaLabel2.Text.Equals("pdf"))
            {
                this.pictureBox1.Visible = true;
            }

            else
            {
                this.PictureBox2.Visible = true;
            }
        }
        private void FilePath()
        {
            using (var sfdSaveFileDialog = new SaveFileDialog()
            {
                DefaultExt = "pdf",
                Title = "Save file as",
                FileName = string.Format(this.GunaLabel1.Text),
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "All files (*.*)|*.*"
            })
            {


                var result = sfdSaveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BackUpDataBase(sfdSaveFileDialog.FileName);
                }
            }
        }
        private void GunaSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void GunaSeparator1_MouseHover(object sender, EventArgs e)
        {

        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void GunaAdvenceButton1_MouseEnter(object sender, EventArgs e)
        {
            this.GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250);
            this.GunaLabel1.BackColor = Color.FromArgb(250, 250, 250);
            this.GunaLabel4.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void GunaAdvenceButton1_MouseLeave(object sender, EventArgs e)
        {
            this.GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255);
            this.GunaLabel1.BackColor = Color.FromArgb(255, 255, 255);
            this.GunaLabel4.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void GunaSeparator1_MouseEnter(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250);
            this.GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void GunaSeparator1_MouseLeave(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255);
            this.GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void GunaLabel1_Click_1(object sender, EventArgs e)
        {
            this.ToolStripMenuItem3.PerformClick();
        }

        private void GunaLabel1_MouseEnter(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250);
            this.GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250);
            this.GunaLabel1.ForeColor = Color.DeepSkyBlue;
            this.GunaLabel1.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void GunaLabel1_MouseLeave(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255);
            this.GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255);
            this.GunaLabel1.ForeColor = Color.Black;
            this.GunaLabel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void GunaLabel4_Click(object sender, EventArgs e)
        {
            // downloadMenu.Show()
        }

        private void GunaLabel4_MouseEnter(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250);
            this.GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250);
            this.GunaLabel4.ForeColor = Color.DeepSkyBlue;
            this.GunaLabel4.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void GunaLabel4_MouseLeave(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255);
            this.GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255);
            this.GunaLabel4.ForeColor = Color.Black;
            this.GunaLabel4.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250);
            this.GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250);

            this.GunaLabel4.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255);
            this.GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255);

            this.GunaLabel4.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(250, 250, 250);
            this.GunaSeparator1.BackColor = Color.FromArgb(250, 250, 250);

            this.GunaLabel4.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.GunaAdvenceButton1.BaseColor = Color.FromArgb(255, 255, 255);
            this.GunaSeparator1.BackColor = Color.FromArgb(255, 255, 255);

            this.GunaLabel4.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void GunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {

            this.GunaContextMenuStrip1.Show(new Point(Control.MousePosition.X - 170, Control.MousePosition.Y));

        }





        
        private void GunaLabel4_Click_1(object sender, EventArgs e)
        {

        }
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (form1.pdfFlag == true)
            {


                string test = this.GunaLabel4.Text;
                test = Strings.Right(test, 4);
               // Interaction.MsgBox(test);

                if (test != ".pdf")
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show("Μόνο αρχεία pdf μπορούν να γίνουν προεπισκόπηση!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // 'lb_company.SaveAs(strNewFileName, 32)

                    Process.Start("notepad.exe", this.GunaLabel4.Text);
                    return;
                }


                if (Application.OpenForms.OfType<pdfViewer>().Any())
                {
                    // courseFiles.GunaPanel1.Controls.Clear()
                    form1.fullpathview = this.GunaLabel4.Text;
                    
                    // WindowsApp1.My.MyProject.Forms.pdfViewer.Close();
                    pdfViewer pdfv = new pdfViewer();
                    coursef.openChildForm(pdfv);

                    coursef.GunaPanel3.Visible = true;
                }

                else
                {
                    // courseFiles.GunaPanel1.Controls.Clear()
                    // links.Close()
                    form1.fullpathview = this.GunaLabel4.Text;
                    //Interaction.MsgBox(form1.fullpathview);
                     pdfViewer pdfv = new pdfViewer();
                   coursef.GunaPanel3.Visible = true;
                     coursef.openChildForm(pdfv);
                    
                    
                }
            }
            else
            {
                string test = this.GunaLabel4.Text;
                test = Strings.Right(test, 4);


                if (test != ".pdf")
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show("Μόνο αρχεία pdf μπορούν να γίνουν προεπισκόπηση!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // 'lb_company.SaveAs(strNewFileName, 32)

                    Process.Start("notepad.exe", this.GunaLabel4.Text);
                    return;
                }


                if (Application.OpenForms.OfType<pdfViewer>().Any())
                {
                    // courseFiles.GunaPanel1.Controls.Clear()
                    form1.fullpathview = this.GunaLabel4.Text;
                    pdfViewer pdfv = new pdfViewer();
                    labor.GunaPanel3.Visible = true;
                    labor.openChildForm(pdfv);
                    //WindowsApp1.My.MyProject.Forms.pdfViewer.Close();

                    //WindowsApp1.My.MyProject.Forms.labs.openChildForm(WindowsApp1.My.MyProject.Forms.pdfViewer);

                    // WindowsApp1.My.MyProject.Forms.labs.GunaPanel3.Visible = true;
                }

                else
                {
                    form1.fullpathview = this.GunaLabel4.Text;
                    pdfViewer pdfv = new pdfViewer();
                    labor.GunaPanel3.Visible = true;
                    labor.openChildForm(pdfv);
                    // courseFiles.GunaPanel1.Controls.Clear()
                    // links.Close()
                    //WindowsApp1.My.MyProject.Forms.Form1.fullpathview = this.GunaLabel4.Text;
                    //WindowsApp1.My.MyProject.Forms.labs.openChildForm(WindowsApp1.My.MyProject.Forms.pdfViewer);

                    //WindowsApp1.My.MyProject.Forms.labs.GunaPanel3.Visible = true;
                }

            }
            // courseMain.nav_home.PerformClick()
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FilePath();
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string FileToDelete;

                FileToDelete = this.GunaLabel4.Text;

                if (File.Exists(FileToDelete) == true)
                {

                    File.Delete(FileToDelete);
                    // courseFiles.Close()
                    // courseFiles.Show()
                    if (coursef.GunaAdvenceButton1.Checked == true)
                    {
                        coursef.GunaAdvenceButton1.PerformClick();
                    }
                    else if (coursef.GunaAdvenceButton2.Checked == true)
                    {

                        coursef.GunaAdvenceButton2.PerformClick();
                    }


                    else
                    {
                        coursef.GunaAdvenceButton3.PerformClick();
                    }
                    // courseMain.nav_home.PerformClick()
                    if (courseM.nav_profile.Checked == true)
                    {
                        courseM.nav_profile.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void GunaLabel1_Click_2(object sender, EventArgs e)
        {
            ToolStripMenuItem3.PerformClick();
        }
    }
    
    
}

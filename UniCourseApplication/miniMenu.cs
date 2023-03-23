using System;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms;

namespace UniCourseApplication
{
    public partial class miniMenu : Form
    {
        public miniMenu()
        {
            wc = new WebClient();
            InitializeComponent();
        }

        
        private void miniMenu_Load(object sender, EventArgs e)
        {
            // Me.Location = New Point(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y + 5)
            this.TopMost = true;
            this.Location = new Point((Size)Control.MousePosition);
            // Me.Location = New Point(GridScheduleSample.calendar.GunaAdvenceButton1.Location.X, GridScheduleSample.calendar.GunaAdvenceButton1.Location.Y)
        }
        private void miniMenu_Deactivate(object sender, EventArgs e)
        {
            this.Close();
            // Form1.TopMost = True

        }
        private Form currentForm = null;
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        courseMain courseM = Application.OpenForms.OfType<courseMain>().FirstOrDefault();
        public void openChildForm(Form childForm)
        {
            // ' GunaTransition1.HideSync(currentForm)
            if (currentForm != null)
                currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            form1.Panel1.Controls.Add(childForm);
            form1.Panel1.Tag = childForm;
            childForm.BringToFront();


            childForm.Show();



        }
        private void GunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form2>().Any())
            {
                // GunaTransition2.HideSync(GunaPanel5)
                courseMain courser = new courseMain();
                this.openChildForm(courser);
            }


            // 'GunaTransition1.ShowSync(GunaPanel15)
            // GunaTransition2.ShowSync(GunaPanel5)

            else
            {

                courseMain courser = new courseMain();
                this.openChildForm(courser);

            }
            this.Close();
        }
        private string dpath = Application.StartupPath + @"\FULLDATA\";
        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("hello");
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Βαθμός Μαθήματος :" + Properties.Settings.Default.vathmoiList[form1.coursepos] + Constants.vbNewLine + "Όνομα Μαθήματος :" + form1.names[form1.coursepos] + Constants.vbNewLine + "Εξάμηνο Μαθήματος :" + form1.courseEksamino[form1.coursepos], "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MsgBox("Βαθμός Μαθήματος :" + My.Settings.vathmoiList(Form1.coursepos) + vbNewLine + "Όνομα Μαθήματος :" + Form1.names(Form1.coursepos) + vbNewLine + "Εξάμηνο Μαθήματος :" + Form1.courseEksamino(Form1.coursepos))
        }
        public long GetDownloadSize(string URL)
        {
            var r = WebRequest.Create(URL);
            r.Method = WebRequestMethods.Http.Get;
            using (var rsp = r.GetResponse())
            {
                return rsp.ContentLength;
            }
        }

        public void checkNewPackage()
        {
            // '  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
            try
            {
                Interaction.MsgBox((object)form1.coursepos);
                var infoReader = new FileInfo(dpath + form1.typos[form1.coursepos] + ".zip");
                string newDsize = this.GetDownloadSize(form1.courseDpLink[form1.coursepos]).ToString();
                // MsgBox(newDsize)
                if (infoReader.Length == 0L)
                {

                    return;
                }
                if (infoReader.Exists)
                {
                    if (Conversions.ToDouble(newDsize) == infoReader.Length)
                    {
                        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                        MessageBoxAdv.Show("Δεν βρέθηκε νέο πακέτο για λήψη", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        // MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                        var result = MessageBox.Show("Θέλετε να γίνει λήψη του πακέτου?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if ((int)result == (int)Constants.vbYes)
                        {
                            this.DeleteDirectory(dpath + form1.typos[form1.coursepos]);
                            downloadPackage();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {




        }
        private void downloadPackage()
        {
            try
            {
                wc.DownloadFileCompleted += OnDownloadComplete;
                // AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
                // AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
                if (!Directory.Exists(dpath))
                {
                    Directory.CreateDirectory(dpath);
                }
                wc.DownloadFileAsync(new Uri(form1.courseDpLink[form1.coursepos]), dpath + form1.typos[form1.coursepos] + ".zip");
            }
            // GunaProgressBar1.Visible = True
            // GunaLabel1.Visible = True
            // GunaLabel2.Visible = True
            // GunaLabel3.Visible = True
            // GunaLabel4.Visible = True
            // GunaLabel5.Visible = True


            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private WebClient wc;
        private void DeleteDirectory(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    // Delete all files from the Directory
                    foreach (string filepath in Directory.GetFiles(path))
                        File.Delete(filepath);
                    // Delete all child Directories
                    foreach (string dir in Directory.GetDirectories(path))
                        DeleteDirectory(dir);
                    // Delete a Directory
                    Directory.Delete(path);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            checkNewPackage();
            // Me.Close()
        }
        private void OnDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error is null)
            {

                try
                {




                    string zipPath = dpath + form1.typos[form1.coursepos] + ".zip";
                    string extractPath = dpath;

                    // 'ZipFile.CreateFromDirectory(startPath, zipPath)

                    ZipFile.ExtractToDirectory(zipPath, extractPath);

                    // 'MsgBox("Επιτυχης εγκατασταση πακετου.")
                    if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form2>().Any())
                    {
                        courseMain courser = new courseMain();
                        this.openChildForm(courser);
                    }
                    else
                    {
                        courseMain courser = new courseMain();
                        this.openChildForm(courser);
                    }
                }
                // '  Me.Close()
                // '  Form1.Show()
                catch (Exception ex)
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            else
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(e.Error.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void GunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("h");
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            var result = MessageBox.Show("Θέλετε να γίνει οριστική Διαγραφή μαθήματος?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if ((int)result == (int)Constants.vbYes)
            {
                this.DeleteDirectory(dpath + form1.typos[form1.coursepos]);
            }

            else
            {
                return;
            }

        }
        private bool agapFlag = false;
        private void GunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            // Form1.agaphmenaList.Add(Form1.coursepos)
            var saveTest = Properties.Settings.Default.agaList;

            for (int i = saveTest.Count - 1; i >= 0; i -= 1)
            {
                if (Conversions.ToDouble(saveTest[i]) == (double)form1.coursepos)
                {
                    saveTest.RemoveAt(i);
                    agapFlag = true;
                }
            }
            if (agapFlag == false)
            {
                saveTest.Add(form1.coursepos.ToString());
            }

            Properties.Settings.Default.agaList = saveTest;
            Properties.Settings.Default.Save();
            form1.GunaAdvenceTileButton4.PerformClick();
            this.Close();
            // PictureBox1.Visible = False
            // PictureBox2.Visible = True
        }
    }
}

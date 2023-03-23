using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
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
    public partial class General : Form
    {
        public General()
        {
            wc = new WebClient();
            InitializeComponent();
        }
        private WebClient wc;
        private string dpath = Application.StartupPath + @"\FULLDATA\";
       Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private void General_Load(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(dpath + form1.typos[form1.coursepos]); // 'gunalabel7.text  = p.x = anaptiksi folder
            if (dir.Exists)
            {
                this.PictureBox5.Visible = false;
                this.Label1.ForeColor = Color.FromArgb(91, 95, 199);
            }
            else
            {
                this.PictureBox5.Visible = true;
                this.Label1.ForeColor = Color.FromArgb(208, 140, 69);
            }
            var usStates = new List<string>();

            usStates.Add("0");
            usStates.Add("0,5");
            usStates.Add("1");
            usStates.Add("1,5");
            usStates.Add("2");
            usStates.Add("2,5");
            usStates.Add("3");
            usStates.Add("3,5");
            usStates.Add("4");
            usStates.Add("4,5");
            usStates.Add("5");
            usStates.Add("5,5");
            usStates.Add("6");
            usStates.Add("6,5");
            usStates.Add("7");
            usStates.Add("7,5");
            usStates.Add("8");
            usStates.Add("8,5");
            usStates.Add("9");
            usStates.Add("9,5");
            usStates.Add("10");

            this.sfComboBox1.DataSource = usStates;
            this.Label1.Text = form1.names[form1.coursepos];
            var saveTest = Properties.Settings.Default.agaList;
            if (saveTest !=null)
            {
                for (int i = saveTest.Count - 1; i >= 0; i -= 1)
                {
                    if (Conversions.ToDouble(saveTest[i]) == (double)form1.coursepos)
                    {
                        this.PictureBox1.Visible = false;
                        this.PictureBox2.Visible = true;
                    }
                }
            }

            this.GunaAdvenceTileButton2.Text = "Κωδικός Μαθήματος: " + form1.courseID[form1.coursepos];
            this.GunaAdvenceTileButton9.Text = "Ο Βαθμός μου            " + Constants.vbNewLine + Properties.Settings.Default.vathmoiList[form1.coursepos]; // Form1.courseGrade(Form1.coursepos)
            this.GunaAdvenceTileButton4.Text = "Εξάμηνο Σπουδών : " + form1.courseEksamino[form1.coursepos];
            this.GunaAdvenceTileButton3.Text = "Εργαστήριο Μαθήματος   " + form1.courseLab[form1.coursepos];
            this.GunaAdvenceTileButton7.Text = "Διδάσκων Καθηγητής   " + form1.courseDidaskon[form1.coursepos];
            this.Label2.Text = form1.courseDrive[form1.coursepos];
            this.Label3.Text = form1.courseSite[form1.coursepos];
            this.Label4.Text = form1.courseDiscord[form1.coursepos];
            if (Conversions.ToDouble(Properties.Settings.Default.vathmoiList[form1.coursepos]) > 4.5d)
            {
                this.PictureBox3.Visible = true;
            }
        }
        public bool agapFlag = false;
       // Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            var result = MessageBoxAdv.Show("Το μάθημα βρίσκεται ήδη στον κατάλογο με τα αγαπημένα,Θέλετε να γίνει αφαίρεση?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    var saveTest = Properties.Settings.Default.agaList;
                    for (int i = saveTest.Count - 1; i >= 0; i -= 1)
                    {
                        if (Conversions.ToDouble(saveTest[i]) == (double)form1.coursepos)
                        {
                            saveTest.RemoveAt(i);
                        }
                    }

                    // saveTest.RemoveAt(Form1.coursepos)
                    Properties.Settings.Default.agaList = saveTest;
                    Properties.Settings.Default.Save();
                    this.PictureBox1.Visible = true;
                    this.PictureBox2.Visible = false;
                }

                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton9_Click(object sender, EventArgs e)
        {
            // My.Settings.vathmoiList.Item(Form1.coursepos) = 10
            // My.Settings.Save()
            // Form1.courseGrade(Form1.coursepos) = 10
            // Form3.Show()
            if (this.sfComboBox1.Visible == false)
            {
                this.sfComboBox1.Visible = true;
            }
            else
            {
                this.sfComboBox1.Visible = false;
            }
            // PictureBox4.Visible = True

        }
        private void sfComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.vathmoiList[form1.coursepos] = Conversions.ToString(this.sfComboBox1.SelectedItem);
                Properties.Settings.Default.Save();
                this.sfComboBox1.Visible = false;
                this.GunaAdvenceTileButton9.Text = "Ο Βαθμός μου            " + Constants.vbNewLine + Properties.Settings.Default.vathmoiList[form1.coursepos];
                if (Conversions.ToDouble(Properties.Settings.Default.vathmoiList[form1.coursepos]) > 4.5d)
                {
                    this.PictureBox3.Visible = true;
                }
                else
                {
                    this.PictureBox3.Visible = false;
                }
            }
            // courseMain.nav_settings.PerformClick()
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Form1.agaphmenaList.Add(Form1.coursepos)
            try
            {
                if (Properties.Settings.Default.agaList is null)
                {
                    Properties.Settings.Default.agaList = new StringCollection();
                }
                var saveTest = Properties.Settings.Default.agaList;
                saveTest.Add(form1.coursepos.ToString());



                Properties.Settings.Default.agaList = saveTest;
                Properties.Settings.Default.Save();
                this.PictureBox1.Visible = false;
                this.PictureBox2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            Process.Start(this.Label2.Text);
        }

        private void GunaAdvenceTileButton8_Click(object sender, EventArgs e)
        {
            Process.Start(this.Label3.Text);
        }

        private void GunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            Process.Start(this.Label4.Text);
        }

        private void downloadPackage()
        {
            try
            {
                wc.DownloadFileCompleted += OnDownloadComplete;
                wc.DownloadProgressChanged += client_ProgressChanged;
                // AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
                if (!Directory.Exists(dpath))
                {
                    Directory.CreateDirectory(dpath);
                }
                wc.DownloadFileAsync(new Uri(form1.courseDpLink[form1.coursepos]), dpath + form1.typos[form1.coursepos] + ".zip");
                this.GunaProgressBar1.Visible = true;
            }
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
        public long GetDownloadSize(string URL)
        {
            var r = WebRequest.Create(URL);
            r.Method = WebRequestMethods.Http.Get;
            using (var rsp = r.GetResponse())
            {
                return rsp.ContentLength;
            }
        }
        private void DeleteDirectory(string path)
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
            }
        }
        private void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {



            this.GunaProgressBar1.Value = e.ProgressPercentage;


        }
        public void checkNewPackage()
        {
            // '  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
            try
            {
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
                        MessageBoxAdv.Show("Δεν υπάρχει νέο πακέτο για το μάθημα!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                        var result = MessageBoxAdv.Show("Υπάρχει νέο Πακέτο,Θέλετε να γίνει λήψη τώρα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }
        private Form currentForm = null;
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
                        courseMain coursm = new courseMain();
                        this.openChildForm(coursm);
                    }
                    else
                    {
                        courseMain coursm = new courseMain();
                        this.openChildForm(coursm);
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
                MessageBoxAdv.Show("Σφάλμα κατά την εγκατάσταση του πακέτου!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GunaAdvenceTileButton10_Click(object sender, EventArgs e)
        {
            checkNewPackage();
        }
    }
}

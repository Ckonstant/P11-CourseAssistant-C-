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
    public partial class courseControl : UserControl
    {
        private WebClient wc;

        private string dpath = Application.StartupPath + @"\FULLDATA\"; // 'keep the path of the files
        private DateTime lastUpdate;
        private long lastBytes = 0L;
        private double iSecond = 0d;

        public courseControl()
        {
            wc = new WebClient();
            InitializeComponent();
        }
        private Form currentForm = null;
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public void openChildForm(Form childForm) // Open child form inside a panel so we can simulate 2 forms in the same instance.
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




                    string zipPath = dpath + form1.typos[form1.coursepos] + ".zip"; // when the file is downloaded i just unzip it so i can manage the files inside.
                    string extractPath = dpath;
                    // Using 

                    // 'ZipFile.CreateFromDirectory(startPath, zipPath)







                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                    form1.GunaCircleProgressBar7.Visible = false;
                   //this.Alert1("Επιτυχής Εγκατάσταση Πακέτου!!", WindowsApp1.AlertForm.alertTypeEnum.Success);
                    // 'MsgBox("Επιτυχης εγκατασταση πακετου.")
                    if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form2>().Any())
                    {
                        courseMain courseF = new courseMain();
                        this.openChildForm(courseF);
                    }
                    else
                    {
                        courseMain courseF = new courseMain();
                        this.openChildForm(courseF);
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


        private void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e) // Downlkoad file and check the progress for each byte to fill the progressbar.
        {
            try
            {
                // ' MsgBox("Total size of :" + (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00") + "Found")
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100d;
                this.GunaLabel4.Text = string.Format("{0} MB / {1} MB", (e.BytesReceived / 1024m / 1024m).ToString("0.00"), (e.TotalBytesToReceive / 1024m / 1024m).ToString("0.00"));
                // ' ActiveForm.Text = ("Ποσοστό Ολοκλήρωσης: ") + e.ProgressPercentage.ToString & ("%")
                this.GunaLabel5.Text = "(" + e.ProgressPercentage + "%)";
                if (lastBytes == 0L)
                {
                    lastUpdate = DateTime.Now;
                    lastBytes = e.BytesReceived;
                    return;
                }

                var now = DateTime.Now;
                var timeSpan = now - lastUpdate;
                if (!(timeSpan.Seconds == 0))
                {
                    long bytesChange = e.BytesReceived - lastBytes;
                    double bytesPerSecond = bytesChange / (double)timeSpan.Seconds;

                    lastBytes = e.BytesReceived;
                    lastUpdate = now;
                    this.GunaLabel2.Text = string.Format("{0} MB/s", (bytesPerSecond / 1024d / 1024d).ToString("0.00"));
                    // ' left.Text = "Timeleft:" + Math.Round(((1 - Me.ProgressBar1.Value / 100) * Math.Round((e.TotalBytesToReceive / 1024), 2)) / bytesPerSecond) + " s"
                    // ' left.Text = "Timeleft:" & Math.Round(((1 - Me.ProgressBar1.Value / 100) * Math.Round((e.TotalBytesToReceive / 1024), 2)) / bytesPerSecond / 1024D / 1024D) & " s"


                    var iSpan = TimeSpan.FromSeconds(iSecond);
                    iSecond = Math.Round((e.TotalBytesToReceive - e.BytesReceived) / bytesPerSecond);
                    if (iSecond < 60d)
                    {
                        this.GunaLabel3.Text = "Estimated:" + iSpan.Seconds.ToString().PadLeft(1, '0') + "s";
                    }
                    else if (iSecond < 3600d)
                    {
                        this.GunaLabel3.Text = "Estimated:" + iSpan.Minutes.ToString().PadLeft(1, '0') + " minutes " + iSpan.Seconds.ToString().PadLeft(1, '0') + "s";
                    }
                    else
                    {
                        this.GunaLabel3.Text = "Estimated:" + iSpan.Hours.ToString().PadLeft(1, '0') + " hours " + iSpan.Minutes.ToString().PadLeft(1, '0') + " minutes ";
                        // '&                         iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
                    }
                    // 'left.Text = "Estimated:" & Math.Round((e.TotalBytesToReceive - e.BytesReceived) / (bytesPerSecond)) & "s"

                }



                this.GunaProgressBar1.Value = e.ProgressPercentage;

                if (this.GunaProgressBar1.Value == 90)
                {
                    this.GunaLabel1.Text = "Αποσυμπίεση αρχειων...";
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void downloadPackage() // start downloading package from a personal one drive link.
        {
            try
            {
                //this.Alert1("Κατέβασμα Πακέτου σε επεξεργασία...", WindowsApp1.AlertForm.alertTypeEnum.Info);
                form1.GunaCircleProgressBar7.Visible = true;
                wc.DownloadFileCompleted += OnDownloadComplete;
                wc.DownloadProgressChanged += client_ProgressChanged;
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

        public int coursePosition = 0;
        private int counti = 0;
        public long GetDownloadSize(string URL) // function to return the size of the file we download
        {
            var r = WebRequest.Create(URL);
            r.Method = WebRequestMethods.Http.Head;
            using (var rsp = r.GetResponse())
            {
                return rsp.ContentLength;
            }
        }
        public void checkNewPackage()        // function to check for new course package compared the installed file with the new file.
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            // '  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
            try
            {
                var infoReader = new FileInfo(dpath + form1.typos[form1.coursepos] + ".zip");
                string newDsize = this.GetDownloadSize(form1.courseDpLink[form1.coursepos]).ToString();
                if (infoReader.Exists)
                {
                    if (Conversions.ToDouble(newDsize) == infoReader.Length)
                    {
                        Interaction.MsgBox("Δεν υπάρχει νέο πακέτο.");
                        return;
                    }
                    else
                    {
                        var result = MessageBoxAdv.Show("Υπάρχει νέο πακέτο,Θέλετε να γίνει λήψη τώρα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if ((int)result == (int)Constants.vbYes)
                        {
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
       
        private void GunaAdvenceTileButton1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;


            counti = 0;
            foreach (var x in form1.names)
            {

                if (x.Equals(this.courseName.Text))
                {
                    form1.coursepos = counti;
                }
                counti += 1;
            }
            form1.courseFlag = this.courseName.Text;

            if (e.Button == MouseButtons.Left)
            {
                var dir = new DirectoryInfo(dpath + form1.typos[form1.coursepos]); // 'gunalabel7.text  = p.x = anaptiksi folder
                if (dir.Exists)
                {
                    // checkNewPackage()

                    if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form2>().Any())
                    {
                        courseMain courseF = new courseMain();
                        this.openChildForm(courseF);
                    }
                    else
                    {
                        courseMain courseF = new courseMain();
                        this.openChildForm(courseF);
                    }
                }
                else
                {
                    var result = MessageBoxAdv.Show("Κατεβάστε το πακέτο πρώτα πριν την επιλογή μαθήματος,Θέλετε να γίνει λήψη τώρα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        downloadPackage();
                    }

                    else
                    {
                        if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form2>().Any())
                        {
                            courseMain courseF = new courseMain();
                            this.openChildForm(courseF);
                        }
                        else
                        {
                            courseMain courseF = new courseMain();
                            this.openChildForm(courseF);
                        }
                        return;
                    }

                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                miniMenu courseF = new miniMenu();
                courseF.Show();
                
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.GunaProgressBar1.Visible = true;
            this.GunaProgressBar1.Increment(1);
            if (this.GunaProgressBar1.Value == 100)
            {
                this.GunaProgressBar1.Visible = false;
                this.GunaProgressBar1.Value = 0;
                this.Timer1.Stop();
            }
        }

        private void GunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {

        }

    }
}

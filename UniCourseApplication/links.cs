using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;
//using ExcelDataReader;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms;

namespace UniCourseApplication
{
    public partial class links : Form
    {
        public links()
        {
            InitializeComponent();
        }

        private void links_Load(object sender, EventArgs e)
        {
            this.GunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.GunaDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.GunaDateTimePicker1.Value = DateTime.Now;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private List<string> listco = new List<string>();
        private string len;
        private double fullLenght;
        private string fileExtension;
        public double totalFilesSize = 0d;
        private int bytesLeft;
        private int totalbytes;
        public int sumFiles = 0;
        public double fileSizesum = 0d;
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private void GradientPanel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var path in files)
            {


                this.ListBox1.Items.Add(Path.GetFullPath(path));
                // CheckedListBox1.Items.Add(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))

                // comboList.Add(System.IO.Path.GetFileName(OpenFileDialog1.FileName))
                listco.Clear();
                len = (new FileInfo(path).Length / 1024d / 1024d).ToString("N2");
                fullLenght = new FileInfo(path).Length;
                if (fullLenght > 100000d)
                {
                    len = (new FileInfo(path).Length / 1024d / 1024d).ToString("N2") + " MB";
                }
                else
                {
                    len = (new FileInfo(path).Length / 1024d).ToString("N2") + " KB";
                }
                fileExtension = Path.GetExtension(path);

                this.ListBox2.Items.Add(Path.GetFileName(path) + len);
                this.ListBox3.Items.Add(fullLenght);
                this.Label2.Text = fullLenght.ToString();
                var loopTo = this.ListBox2.Items.Count - 1;
                for (i = 0; i <= loopTo; i++)
                    listco.Add(this.ListBox2.Items[i].ToString() + "  " + " MB");
                var c = new UniCourseApplication.UserControl1();
                c.Dock = DockStyle.Top;
                c.BringToFront();
                c.Label1.Text = Path.GetFullPath(path);
                c.GunaLabel1.Text = "Όνομα Αρχείου: " + Path.GetFileName(path);
                c.GunaLabel2.Text = "Μέγεθος Αρχείου :  " + len;
                c.GunaLabel4.Text = (new FileInfo(path).Length / 1024d / 1024d).ToString();
                c.SfToolTip1.SetToolTip(c.GunaLabel1, Path.GetFullPath(path));
                c.SfToolTip1.SetToolTip(c.GunaLabel2, "Το μέγεδος του αρχείου σε MB ή KB");
                if (fileExtension == ".xlsx")
                {
                    c.GunaPictureBox1.Visible = true;
                    c.GunaPictureBox6.Visible = true;
                    c.GunaLabel3.Text = "Τύπος Αρχείου : Excel";
                }
                else if (fileExtension == ".pdf")
                {
                    c.GunaPictureBox2.Visible = true;
                    c.GunaLabel3.Text = "Τύπος Αρχείου : PDF";
                    c.GunaPictureBox6.Visible = true;
                }
                else if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".gif")
                {
                    c.GunaLabel3.Text = "Τύπος Αρχείου : Picture";
                    c.GunaPictureBox3.Visible = true;
                }
                else if (fileExtension == ".zip" || fileExtension == ".7z" || fileExtension == ".rar")
                {
                    c.GunaLabel3.Text = "Τύπος Αρχείου : Zip File";
                    c.GunaPictureBox5.Visible = true;
                }
                else
                {
                    c.GunaLabel3.Text = "Τύπος Αρχείου : File";
                    c.GunaPictureBox4.Visible = true;
                }
                this.GradientPanel2.Controls.Add(c);



                sumFiles = 0;
                sumFiles = this.ListBox1.Items.Count;
                this.Label3.Text = sumFiles.ToString();
                fileSizesum = fileSizesum + fullLenght;
                totalFilesSize = fileSizesum / 1024d / 1024d;
                this.Label4.Text = "Συνολικό μέγεθος αρχείων = " + totalFilesSize.ToString("N2") + " MB";
                this.GradientPanel2.BackgroundImage = null;
                this.Label1.Visible = false;
                this.GunaProgressBar1.Value = (int)Math.Round(100d * totalFilesSize / 25d);
                this.Label7.Text = totalFilesSize.ToString("N2") + "/ 25MB";
                if (totalFilesSize > 25d)
                {
                    this.Label7.ForeColor = Color.Red;
                   // form1.Alert1("Φτάσατε το όριο των επιτρεπτών Αρχείων για αποστολή.", WindowsApp1.AlertForm.alertTypeEnum.Warning);
                }
            }


        }
        private void GradientPanel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

            }
        }



        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
        {

            this.OpenFileDialog1.FileName = "";
            this.OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls";

            if (this.OpenFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                // GunaDataGridView1.Columns.Clear()

                var fi = new FileInfo(this.OpenFileDialog1.FileName);
                string FileName = this.OpenFileDialog1.FileName;

                this.ListBox1.Items.Add(Path.GetFullPath(this.OpenFileDialog1.FileName));


                len = ((double)new FileInfo(this.OpenFileDialog1.FileName).Length / 1024d / 1024d).ToString("N2");
                fullLenght = new FileInfo(this.OpenFileDialog1.FileName).Length;
                if (fullLenght > 100000d)
                {
                    len = ((double)new FileInfo(this.OpenFileDialog1.FileName).Length / 1024d / 1024d).ToString("N2") + " MB";
                }
                else
                {
                    len = ((double)new FileInfo(this.OpenFileDialog1.FileName).Length / 1024d).ToString("N2") + " KB";
                }
                fileExtension = Path.GetExtension(this.OpenFileDialog1.FileName);
                // MsgBox(fileExtension)
                // ListBox2.Items.Add(System.IO.Path.GetFileName(OpenFileDialog1.FileName) + len)
                // ListBox3.Items.Add(fullLenght)
                this.Label2.Text = fullLenght.ToString();
                var loopTo = this.ListBox2.Items.Count - 1;
                for (i = 0; i <= loopTo; i++)
                    listco.Add(this.ListBox2.Items[i].ToString() + "  " + " MB");
                var c = new UniCourseApplication.UserControl1();
                c.Dock = DockStyle.Top;
                c.BringToFront();
                c.Label1.Text = Path.GetFullPath(this.OpenFileDialog1.FileName);
                c.GunaLabel1.Text = "Όνομα Αρχείου: " + Path.GetFileName(this.OpenFileDialog1.FileName);
                c.GunaLabel2.Text = "Μέγεθος Αρχείου :  " + len;
                c.GunaLabel4.Text = ((double)new FileInfo(this.OpenFileDialog1.FileName).Length / 1024d / 1024d).ToString();
                c.SfToolTip1.SetToolTip(c.GunaLabel1, Path.GetFullPath(this.OpenFileDialog1.FileName));
                c.SfToolTip1.SetToolTip(c.GunaLabel2, "Το μέγεδος του αρχείου σε MB ή KB");
                if (fileExtension == ".xlsx")
                {
                    c.GunaPictureBox1.Visible = true;
                    c.GunaPictureBox6.Visible = true;
                    c.GunaLabel3.Text = "Τύπος Αρχείου : Excel";
                }
                else if (fileExtension == ".pdf")
                {
                    c.GunaPictureBox2.Visible = true;
                    c.GunaLabel3.Text = "Τύπος Αρχείου : PDF";
                }
                else if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".gif")
                {
                    c.GunaLabel3.Text = "Τύπος Αρχείου : Picture";
                    c.GunaPictureBox3.Visible = true;
                }
                else if (fileExtension == ".zip" || fileExtension == ".7z" || fileExtension == ".rar")
                {
                    c.GunaLabel3.Text = "Τύπος Αρχείου : Zip File";
                    c.GunaPictureBox5.Visible = true;
                }
                else
                {
                    c.GunaLabel3.Text = "Τύπος Αρχείου : File";
                    c.GunaPictureBox4.Visible = true;
                }
                this.GradientPanel2.Controls.Add(c);

            }

            sumFiles = 0;
            sumFiles = this.ListBox1.Items.Count;
            this.Label3.Text = sumFiles.ToString();
            fileSizesum = fileSizesum + fullLenght;
            totalFilesSize = fileSizesum / 1024d / 1024d;
            this.Label4.Text = "Συνολικό μέγεθος αρχείων = " + totalFilesSize.ToString("N2") + " MB";
            this.GradientPanel2.BackgroundImage = null;
            this.Label1.Visible = false;
            this.GunaProgressBar1.Value = (int)Math.Round(100d * totalFilesSize / 25d);
            this.Label7.Text = totalFilesSize.ToString("N2") + "/ 25MB";
            if (totalFilesSize > 25d)
            {
                this.Label7.ForeColor = Color.Red;
                //form1.Alert1("Φτάσατε το όριο των επιτρεπτών Αρχείων για αποστολή.", WindowsApp1.AlertForm.alertTypeEnum.Warning);
            }
        }
        private void uploadMessage()
        {
            try
            {
                var mail = new MailMessage();
                var SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("csforcesioannina@gmail.com");
                mail.To.Add(this.GunaTextBox1.Text);
                mail.Subject = this.GunaComboBox1.SelectedItem.ToString() + " Ημερομηνία: " + this.GunaDateTimePicker1.Text;
                mail.Body = this.GunaLineTextBox2.Text;

                // Dim attachment As System.Net.Mail.Attachment
                if (this.ListBox1.Items.Count != 0) // This listbox holds the path of the files...
                {
                    var loopTo = this.ListBox1.Items.Count - 1;
                    for (i = 0; i <= loopTo; i++)
                        mail.Attachments.Add(new Attachment(Conversions.ToString(this.ListBox1.Items[i])));
                }
                // attachment = New System.Net.Mail.Attachment("C:\Users\Akuaku\Desktop\fg.xlsx")
                // mail.Attachments.Add(attachment)

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("csforcesioannina@gmail.com", "pwxjmrbsqzuayqht");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Το mail στάλθηκε με επιτυχία , θα σταλθεί απάντηση οταν γίνει ο έλεγχος του μέιλ!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // WindowsApp1.My.MyProject.Forms.Form1.Alert1("Επιτυχημένη Αποστολή πακέτου", WindowsApp1.AlertForm.alertTypeEnum.Success);
                // MsgBox("sucess")
                Interaction.MsgBox("Το μηνυμα Σταλθηκε με επιτυχια.");
                this.GunaGradient2Panel1.Visible = false;
                this.GunaGradient2Panel2.Visible = true;
            }
            catch (Exception e)
            {

               // form1.Alert1("Αποτυχία Αποστολής πακέτου", WindowsApp1.AlertForm.alertTypeEnum.Error);
            }

            // MessageBox.Show("mail Send")
            // GunaProgressBar1.Visible = True
            // Timer1.Start()
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            uploadMessage();
        }

        private void GunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void GunaGradient2Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.GunaGradient2Panel1.Visible = true;
            this.GunaGradient2Panel2.Visible = false;
            // GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
            this.BackgroundWorker1.RunWorkerAsync();
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {
            this.GunaGradient2Panel1.Visible = true;
            this.GunaGradient2Panel2.Visible = false;
            // GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
            this.BackgroundWorker1.RunWorkerAsync();
        }

        private void GunaButton8_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Φόρμα Αποστολής E-Mail", "CS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GunaGradient2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

}

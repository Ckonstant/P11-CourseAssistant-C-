using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Syncfusion.Windows.Forms;

namespace UniCourseApplication
{
    public partial class myFiles : Form
    {
        private DataTable table;
        private string dipath = Application.StartupPath + @"\FULLDATA\";
        private string sourcepath;
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public myFiles()
        {
            InitializeComponent();
            sourcepath = dipath + @"\myFiles";
        }
        private void LoadRows(string dir)
        {
            if (Directory.Exists(dir))
            {
                try
                {
                    foreach (string fn in Directory.GetFiles(dir, "*.*"))
                        table.Rows.Add(Path.GetFileName(fn), fn);
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private static void CopyDirectory(string sourcePath, string destPath)
        {
            try
            {
                if (!Directory.Exists(destPath))
                {
                    Directory.CreateDirectory(destPath);
                }

                foreach (string file__1 in Directory.GetFiles(Path.GetDirectoryName(sourcePath)))
                {
                    string dest = Path.Combine(destPath, Path.GetFileName(file__1));
                    File.Copy(file__1, dest);
                }

                foreach (string folder in Directory.GetDirectories(Path.GetDirectoryName(sourcePath)))
                {
                    string dest = Path.Combine(destPath, Path.GetFileName(folder));
                    CopyDirectory(folder, dest);
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GunaPanel1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string sourcepath;
                string DestPath;
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var path in files)
                {



                    var c = new UniCourseApplication.courseFileData();
                    c.Dock = DockStyle.Top;

                    c.GunaLabel4.Text = path;
                    c.GunaLabel1.Text = path.Substring(path.LastIndexOf(@"\") + 1);

                    sourcepath = path;

                    var dir = new DirectoryInfo(dipath + form1.typos[form1.coursepos] + @"\myFiles");

                    if (dir.Exists)
                    {
                        DestPath = dipath + form1.typos[form1.coursepos] + @"\myFiles\" + path.Substring(path.LastIndexOf(@"\") + 1);
                        File.Copy(sourcepath, DestPath, true);
                        this.GunaPanel1.Controls.Add(c);
                    }

                    else
                    {
                        Directory.CreateDirectory(dir.FullName);
                        DestPath = dipath + form1.typos[form1.coursepos] + @"\myFiles\" + path.Substring(path.LastIndexOf(@"\") + 1);
                        File.Copy(sourcepath, DestPath, true);
                        this.GunaPanel1.Controls.Add(c);
                    }





                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaPanel1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void myFiles_Load(object sender, EventArgs e)
        {
            try
            {
                this.GunaPanel1.Controls.Clear();
                string fileExten;
                var r = new Random();
                table = new DataTable();
                table.Clear();

                {
                    var withBlock = table.Columns;
                    withBlock.Add("Name", typeof(string));
                    withBlock.Add("FullPath", typeof(string));
                }
                this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\myFiles");

                for (int i = table.Rows.Count - 1; i >= 0; i -= 1)
                {
                    var c = new UniCourseApplication.courseFileData();
                    c.Dock = DockStyle.Top;
                    fileExten = table.Rows[i][0].ToString();
                    c.GunaLabel1.Text = table.Rows[i][0].ToString();
                    c.GunaLabel2.Text = fileExten.Substring(fileExten.LastIndexOf(".") + 1);
                    c.GunaLabel3.Text = table.Rows[i][0].ToString();
                    c.GunaLabel4.Text = table.Rows[i][1].ToString();

                    this.GunaPanel1.Controls.Add(c);

                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            var dlg = new OpenFileDialog();
            dlg.Title = "Open Schedule file";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            // dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourcepath;
                    string DestPath;




                    var c = new UniCourseApplication.courseFileData();
                    c.Dock = DockStyle.Top;

                    c.GunaLabel4.Text = dlg.FileName;
                    c.GunaLabel1.Text = dlg.FileName.Substring(dlg.FileName.LastIndexOf(@"\") + 1);

                    sourcepath = dlg.FileName;
                    DestPath = dipath + form1.typos[form1.coursepos] + @"\myFiles\" + dlg.FileName.Substring(dlg.FileName.LastIndexOf(@"\") + 1);

                    File.Copy(sourcepath, DestPath, true);

                    this.GunaPanel1.Controls.Add(c);
                }



                catch (Exception ex)
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dipath + form1.typos[form1.coursepos] + @"\myFiles");
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

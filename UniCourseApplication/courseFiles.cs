using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Linq;

namespace UniCourseApplication
{
    public partial class courseFiles : Form
    {
        private DataTable table;
        private string dipath = Application.StartupPath + @"\FULLDATA\";

        public courseFiles()
        {
            InitializeComponent();
            //GunaPanel3 = _GunaPanel3;
           // _GunaPanel3.Name = "GunaPanel3";
        }

        private void LoadRows(string dir)
        {
            if (System.IO.Directory.Exists(dir))
            {
                try
                {
                    foreach (string fn in System.IO.Directory.GetFiles(dir, "*.*"))
                        table.Rows.Add(System.IO.Path.GetFileName(fn), fn);
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
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
            this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\diafaneies");

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

        private void GunaAdvenceButton2_Click(object sender, EventArgs e)
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
                this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\askiseis");

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

        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
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
                this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\themata");

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
            this.GunaPanel3.Controls.Add(childForm);
            this.GunaPanel3.Tag = childForm;
            childForm.BringToFront();


            childForm.Show();



        }
        private void courseFiles_Load(object sender, EventArgs e)
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
            this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\diafaneies");

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

        private void GunaSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void GunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaAdvenceButton4_Click(object sender, EventArgs e)
        {

        }

        private void GunaAdvenceTileButton10_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GunaAdvenceButton1.Checked == true)
                {
                    Process.Start(dipath + form1.typos[form1.coursepos] + @"\diafaneies");
                }
                else if (this.GunaAdvenceButton2.Checked == true)
                {
                    Process.Start(dipath + form1.typos[form1.coursepos] + @"\askiseis");
                }
                else
                {
                    Process.Start(dipath + form1.typos[form1.coursepos] + @"\themata");
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            var r = new Random();
            table = new DataTable();
            table.Clear();

            {
                var withBlock = table.Columns;
                withBlock.Add("Name", typeof(string));
                withBlock.Add("FullPath", typeof(string));
            }
            this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\diafaneies");

            for (int i = table.Rows.Count - 1; i >= 0; i -= 1)
            {

            }
            col.AddRange((string[])table.Rows[0][0]);
        }


    }

}

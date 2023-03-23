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
    public partial class labs : Form
    {
        public labs()
        {
            InitializeComponent();
            
           
        }
        private DataTable table;
        private string dipath = Application.StartupPath + @"\FULLDATA\";

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
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private void labs_Load(object sender, EventArgs e)
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
                this.LoadRows(dipath + form1.typos[form1.coursepos] + @"\lab");

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
    }
}

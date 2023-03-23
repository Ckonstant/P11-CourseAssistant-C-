using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms;

namespace UniCourseApplication
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void GunaSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void GunaPictureBox6_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            DialogResult result;
            try
            {

                result = MessageBoxAdv.Show("Θέλετε να γίνει προεπισκόπηση;", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBoxAdv.Show("Σφάλμα κατά την προεπισκόπηση του αρχείου(.pdf αρχεία αποδεκτά)", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }
        Form4 form4 = Application.OpenForms.OfType<Form4>().FirstOrDefault();
        links linker = Application.OpenForms.OfType<links>().FirstOrDefault();
        private void GunaCircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int finalIndex = 0;
                foreach (var index in form4.ListBox1.Items)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(index, this.Label1.Text, false)))
                    {
                        finalIndex = i;
                    }
                    i += 1;
                }

                linker.sumFiles = linker.sumFiles - 1;
                linker.Label3.Text = "Συνολικά αρχεία = " + linker.sumFiles.ToString();
                linker.totalFilesSize = linker.totalFilesSize - Convert.ToDouble(this.GunaLabel4.Text);
                linker.fileSizesum = linker.fileSizesum - Convert.ToDouble(this.GunaLabel4.Text) * 1024d * 1024d;
                linker.Label7.Text = linker.totalFilesSize.ToString("N2") + " / 25 MB";
                linker.GunaProgressBar1.Value = (int)Math.Round(100d * linker.totalFilesSize / 25d);
                linker.ListBox1.Items.RemoveAt(finalIndex);
                linker.GradientPanel2.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

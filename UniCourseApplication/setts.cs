using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
//using System.Windows.Forms;

namespace UniCourseApplication
{
    public partial class setts : Form
    {
        public setts()
        {
            InitializeComponent();
        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private void setts_Load(object sender, EventArgs e)
        {

        }
        private void GunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.GunaWinSwitch1.Checked == true)
            {
                form1.GunaControlBox3.Visible = false;
            }
            else
            {
                form1.GunaControlBox3.Visible = true;
            }
        }

        private void GunaWinSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Μη διαθέσιμο πακέτο Θεμάτων προς το παρον!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GunaWinSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.GunaWinSwitch2.Checked == true)
            {
                form1.GunaControlBox1.Visible = false;
            }
            else
            {
                form1.GunaControlBox1.Visible = true;
            }
        }

        private void GunaWinSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.GunaWinSwitch5.Checked == true)
            {
                form1.hideGrade = true;
            }
            else
            {
                form1.hideGrade = false;
            }
        }

        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            var result = MessageBoxAdv.Show("Θέλετε να γίνει οριστική Διαγραφή όλων των πακέτων?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string packagePath = Application.StartupPath + @"\FULLDATA";
                    var existPath = new DirectoryInfo(packagePath); // 'gunalabel7.text  = p.x = anaptiksi folder
                    if (existPath.Exists)
                    {
                        Directory.Delete(packagePath, true);
                        if (!Directory.Exists(Application.StartupPath + @"\FULLDATA\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + @"\FULLDATA\");
                        }
                    }
                    else
                    {
                        MessageBoxAdv.Show("Δεν υπάρχουν διαθέσιμα πακέτα για διαγραφή!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show(ex.Message, "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
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
        

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            var result = MessageBoxAdv.Show("Θέλετε να αφαιρεθούν όλα τα μαθήματα από τα αγαπημένα?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    var saveTest = Properties.Settings.Default.agaList;
                    for (int i = saveTest.Count - 1; i >= 0; i -= 1)


                        saveTest.RemoveAt(i);

                    // saveTest.RemoveAt(Form1.coursepos)
                    Properties.Settings.Default.agaList = saveTest;
                    Properties.Settings.Default.Save();
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

        private void GunaAdvenceTileButton10_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Δεν Βρέθηκε νέα έκδοση !!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GunaButton8_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Διάφορες Ρυθμίσεις,πολλές ρυθμίσεις υπό κατασκευή στο Beta", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GunaWinSwitch10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.GunaWinSwitch10.Checked == true)
            {
                this.GunaLineTextBox1.Visible = false;
            }
            else
            {
                this.GunaLineTextBox1.Visible = true;
            }
        }

        private void GunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            var result = MessageBoxAdv.Show("Θέλετε να απεγκαταστήσετε την εφαρμογή?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBoxAdv.Show("ΣΦΑΛΜΑ!Δοκιμάστε να κάνετε απεγκατάσταση από τον πίνακα ελέγχου!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
namespace UniCourseApplication
{
    public partial class apps : Form
    {
        public apps()
        {
            InitializeComponent();
        }

        private void apps_Load(object sender, EventArgs e)
        {

        }
        private void GunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.office.com/");
        }

        private void GunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("WINWORD.exe");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("POWERPNT.exe");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/v6kJXC2KnY");
        }

        private void GunaAdvenceTileButton11_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Excel.exe");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton8_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("OUTLOOK.exe");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://teams.microsoft.com/_?culture=el-gr&country=GR&lm=deeplink&lmsrc=homePageWeb&cmpid=WebSignIn#/scheduling-form/?startTime=Wed%20Apr%2013%202022%2014:30:00%20GMT%2B0300%20(Eastern%20European%20Summer%20Time)&endTime=Wed%20Apr%2013%202022%2015:00:00%20GMT%2B0300%20(Eastern%20European%20Summer%20Time)&opener=1&navCtx=time-block-click&calendarType=User&webinarType=None");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.wolframalpha.com/");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://drive.google.com/drive/u/2/folders/1Tz9JoMia5Jem5gwxFPBDo_19LyBqUgJN");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton9_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://ecourse.uoi.gr/");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GunaAdvenceTileButton10_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.adobe.com/");
            }
            catch
            {

                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Δεν βρέθηκε η εγκατάσταση της εφαρμογής", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

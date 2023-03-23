using Microsoft.VisualBasic.CompilerServices;
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
    public partial class agaphmena : Form
    {
        public agaphmena()
        {
            InitializeComponent();
        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private void agaphmena_Load(object sender, EventArgs e)
        {
            try
            {


                foreach (string x in Properties.Settings.Default.agaList) // 'when form loads it adds every course to favourite panel with unique attributes behind it.
                {

                    var c = new UniCourseApplication.courseControl();
                    c.GunaAdvenceTileButton1.Text = form1.names[Conversions.ToInteger(x)];
                    c.courseName.Text = form1.names[Conversions.ToInteger(x)];
                    this.FlowLayoutPanel1.Controls.Add(c);

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

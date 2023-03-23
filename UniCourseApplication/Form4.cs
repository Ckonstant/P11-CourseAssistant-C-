using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCourseApplication
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private long DirSize(string path)
        {
            long sz = 0L;
            // get file length
            var d = new DirectoryInfo(path);
            foreach (var f in d.GetFiles())
                // recurse into directories
                sz += f.Length;
            foreach (var dx in d.GetDirectories())
                sz += DirSize(dx.FullName);
            return sz;
        }



        private void Form4_Load(object sender, EventArgs e)
        {

            


            int foldercount = 0;
            if (form1.hideGrade == true)
            {
                PictureBox8.Visible = true;
                PictureBox9.Visible = true;
                PictureBox10.Visible = true;
                Label35.Visible = false;
                Label36.Visible = false;
                Label37.Visible = false;
            }
            else
            {
                PictureBox8.Visible = false;
                PictureBox9.Visible = false;
                PictureBox10.Visible = false;
                Label35.Visible = true;
                Label36.Visible = true;
                Label37.Visible = true;
            }
            // MsgBox((DirSize(My.Application.Info.DirectoryPath + "\FULLDATA\") / 1024 / 1024 / 1024).ToString("N1"))
            try
            {
                foldercount = Directory.GetDirectories(Application.StartupPath + @"\FULLDATA\").Count();
            }
            catch (Exception ex)
            {

            }
            try
            {
                if (Properties.Settings.Default.agaList is null)
                {
                    Properties.Settings.Default.agaList   = new System.Collections.Specialized.StringCollection();
                }
                if (Properties.Settings.Default.vathmoiList is null)
                {
                    Properties.Settings.Default.vathmoiList = new System.Collections.Specialized.StringCollection();
                }
                Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();

                range1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

                range1.EndValue = foldercount;

                range1.Height = 5;

                range1.InRange = false;

                range1.Name = "GaugeRange1";

                range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;

                range1.StartValue = 0F;

                this.RadialGauge1.Ranges.Add(range1);


                string startingPath = Application.StartupPath.ToString();
                RadialGauge1.Value = foldercount;
                //RadialGauge1.Ranges. = foldercount;
                RadialGauge2.Value = Properties.Settings.Default.agaList.Count;
                // RadialGauge2.Ranges(0).EndValue = global::My.Settings.agaList.Count;
                float size = DirSize(startingPath + @"\FULLDATA\");
                // float.TryParse(myString, out myFloat);
                float myFloat = (size / 1024 / 1024);
                float roundedFloat = (float)Math.Round(myFloat, 2);
                RadialGauge3.Value =roundedFloat ;
               // RadialGauge3.Ranges(0).EndValue = (DirSize(global::My.Application.Info.DirectoryPath + @"\FULLDATA\") / 1024 / 1024).ToString("N1");
                string countPerasmena = 0.ToString();

                // Dim saveTest As StringCollection = My.Settings.vathmoiList
                if (Properties.Settings.Default.vathmoiList.Count < 60)
                {
                    for (int i = 0; i <= 66; i++)
                    {
                        Properties.Settings.Default.vathmoiList.Add("1");
                        Properties.Settings.Default.Save();
                    }


                }
                // My.Settings.vathmoiList.Clear()
                // My.Settings.Save()
                string s = 0.ToString();
                foreach (var x in Properties.Settings.Default.vathmoiList)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(x, 4, false)))
                    {
                        s = Conversions.ToString(Operators.AddObject(s, x));
                        countPerasmena = (Conversions.ToDouble(countPerasmena) + 1d).ToString();
                    }
                }
                Label44.Text = "   " + countPerasmena + @"/47
Περασμένα";
                if (Conversions.ToDouble(countPerasmena) != 0d)
                {
                    Label35.Text = (Conversions.ToDouble(s) / Conversions.ToDouble(countPerasmena)).ToString("N2");
                }
                else
                {
                    Label35.Text = "0";
                }

                Label36.Text = countPerasmena;
                GunaGradient2Panel1.Visible = false;
                //GunaCircleProgressBar4.Value = countPerasmena;
                string strURL = "https://www.cs.uoi.gr/nea/";
            }



            // loadWeb(strURL)
            // Debug.Print(HDoc.GetElementById("question-header").FirstChild.InnerText)
            // Debug.Print(FindClass(HDoc, "cs-newscategorie"))
            catch (Exception ex )
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.Show("Κάτι πήγε στραβά/Δοκιμάστε την επανεγκατάσταση του προγράμματος", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

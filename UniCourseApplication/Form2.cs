using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCourseApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private string[] names;
        private string[] epiloghs;
        private void Form2_Load(object sender, EventArgs e)
        {
            form1.GunaCircleProgressBar7.Visible = false;
            names = new[] { "Απειροστικός Ι", "Αγγλικά", "Γενική Φυσική", "Γραμμική Άλγεβρα", "Εισαγωγή στον Προγραμματισμό", "Εισαγωγή στους Η/Υ και Πληροφορική", "Απειροστικός Λογισμός ΙΙ", "Βασικές Αρχές Κυκλωμάτων", "Διακριτά Μαθηματικά Ι", "Τεχνικές Αντικειμενοστρεφούς Προγραμματισμού", "Ανάπτυξη Λογισμικού", "Διακριτά Μαθηματικά ΙΙ", "Δομές Δεδομένων", "Πιθανότητες και Στατιστική", "Ψηφιακή Σχεδίαση Ι", "Αρχές Γλωσσών Προγραμματισμού", "Εισαγωγή στην Αριθμητική Ανάλυση", "Ηλεκτρονική", "Σχεδίαση και Ανάλυση Αλγορίθμων", "Ψηφιακή Σχεδίαση ΙΙ", "Θεωρία Υπολογισμού", "Προγραμματισμός Συστημάτων", "Σήματα και Συστήματα", "Yπολογιστικά Μαθηματικά", "Αρχιτεκτονική Υπολογιστών", "Λειτουργικά Συστήματα", "Tεχνητή Νοημοσύνη", "Τηλεπικοινωνιακά Συστήματα", "Βάσεις Δεδομένων", "Γραφικά Υπολογιστών και Συστήματα Αλληλεπίδρασης", "Δίκτυα Υπολογιστών Ι", "Δίκτυα Υπολογιστών ΙΙ", "Μεταφραστές", "Τεχνολογία Λογισμικού", "Μικροεπεξεργαστές" };
            epiloghs = new[] { "Αλληλεπίδραση Ανθρώπου Υπολογιστή", "Μηχανική Μάθηση", "Ανάκτηση Πληροφορίας", "Ανάπτυξη Λογισμικού ΙΙ", "Αρχιτεκτονική Υπολογιστών ΙΙ", "Ασύρματα Δίκτυα", "Ασφάλεια Υπολογιστικών και Επικοινωνιακών Συστημάτων", "Βελτιστοποίηση", "Δοκιμή και Αξιοπιστία Ηλεκτρονικών Συστημάτων", "Εξελικτικός Υπολογισμός", "Εξόρυξη Δεδομένων", "Θεωρία Γραφημάτων", "Θεωρία Πληροφορίας και Κωδίκων", "Ιατρική Πληροφορική", "Κυκλώματα VLSI", "Μεταφραστές ΙΙ", "Παράλληλα Συστήματα και Προγραμματισμός", "Πολυμέσα", "Προηγμένη Σχεδίαση Αλγορίθμων και Δομών", "Προσομοίωση και Μοντελοποίηση Υπολογιστικών Συστημάτων", "Προχωρημένα Θέματα Τεχνολογίας και Εφαρμογών Βάσεων Δεδομένων", "Ρομποτική", "Υπολογιστική Γεωμετρία", "Υπολογιστική Νοημοσύνη", "Υπολογιστική Πολυπλοκότητα", "Ψηφιακή Επεξεργασία Εικόνας", "Διαχείριση Σύνθετων Δεδομένων", "Τεχνολογίες Διαδικτύου", "Αλγοριθμικές Τεχνικές για Δεδομένα Ευρείας Κλίμακας", "Ασύρματες Ζεύξεις", "Διδακτική της Πληροφορικής", "Εικονική, Επαυξημένη και Μικτή Πραγματικότητα", "Προηγμένες Μέθοδοι 3Δ Γραφικών" };

            for (int i = 0; i <= 5; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel2.Controls.Add(c);
            }
            for (int i = 6; i <= 9; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel3.Controls.Add(c);
            }
            for (int i = 10; i <= 14; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel4.Controls.Add(c);
            }
            for (int i = 15; i <= 19; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel5.Controls.Add(c);
            }
            for (int i = 20; i <= 24; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel6.Controls.Add(c);
            }
            for (int i = 25; i <= 27; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel7.Controls.Add(c);
            }
            for (int i = 28; i <= 30; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel8.Controls.Add(c);
            }
            for (int i = 31; i <= 33; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = names[i];
                c.courseName.Text = names[i];
                this.FlowLayoutPanel9.Controls.Add(c);
            }
            for (int i = 0, loopTo = epiloghs.Length - 1; i <= loopTo; i += 1)
            {
                var c = new UniCourseApplication.courseControl();
                c.GunaAdvenceTileButton1.Text = epiloghs[i];
                c.courseName.Text = epiloghs[i];
                this.FlowLayoutPanel11.Controls.Add(c);
            }

            var x = new UniCourseApplication.courseControl();
            x.GunaAdvenceTileButton1.Text = names[34];
            x.courseName.Text = names[34];
            this.FlowLayoutPanel10.Controls.Add(x);
            this.GunaAdvenceButton1.PerformClick();
        }



        private void Form2_Shown(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel2.Visible == false)
            {
                this.FlowLayoutPanel2.Visible = true;
                this.GunaAdvenceButton1.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel2.Visible = false;
                //Image myImage = Properties.Resources.
                this.GunaAdvenceButton1.Image = Properties.Resources.more_than_16px;
            }
        }
        
        private void GunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel3.Visible == false)
            {
                this.FlowLayoutPanel3.Visible = true;
               this.GunaAdvenceButton2.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel3.Visible = false;
                this.GunaAdvenceButton2.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel4.Visible == false)
            {
                this.FlowLayoutPanel4.Visible = true;
                this.GunaAdvenceButton3.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel4.Visible = false;
                this.GunaAdvenceButton3.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel5.Visible == false)
            {
                this.FlowLayoutPanel5.Visible = true;
                this.GunaAdvenceButton4.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel5.Visible = false;
                this.GunaAdvenceButton4.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel6.Visible == false)
            {
                this.FlowLayoutPanel6.Visible = true;
                this.GunaAdvenceButton5.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel6.Visible = false;
                this.GunaAdvenceButton5.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel7.Visible == false)
            {
                this.FlowLayoutPanel7.Visible = true;
                this.GunaAdvenceButton6.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel7.Visible = false;
                this.GunaAdvenceButton6.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel8.Visible == false)
            {
                this.FlowLayoutPanel8.Visible = true;
                this.GunaAdvenceButton7.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel8.Visible = false;
                this.GunaAdvenceButton7.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel9.Visible == false)
            {
                this.FlowLayoutPanel9.Visible = true;
                this.GunaAdvenceButton8.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel9.Visible = false;
                this.GunaAdvenceButton8.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel10.Visible == false)
            {
                this.FlowLayoutPanel10.Visible = true;
                this.GunaAdvenceButton9.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel10.Visible = false;
                this.GunaAdvenceButton9.Image = Properties.Resources.more_than_16px;
            }
        }

        private void GunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            if (this.FlowLayoutPanel11.Visible == false)
            {
                this.FlowLayoutPanel11.Visible = true;
                this.GunaAdvenceButton10.Image = UniCourseApplication.Properties.Resources.expand_arrow_24px;
            }
            else
            {
                this.FlowLayoutPanel11.Visible = false;
                this.GunaAdvenceButton10.Image = Properties.Resources.more_than_16px;
            }
        }
    }
}

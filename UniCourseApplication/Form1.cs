using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Syncfusion.Windows.Forms;
using UniCourseApplication.GridScheduleSample;

namespace UniCourseApplication
{
   
    public partial class Form1 : Form
    {
        public bool hideGrade = false;
        public string[] names;
        public string courseFlag;
        public string[] courseID;
        public string[] courseDpLink;
        public string[] typos;
        public string[] courseEksamino;
        public string[] courseDrive;
        public string[] courseDidaskon;
        public string[] courseGrade;
        public string[] courseSite;
        public string[] courseDiscord;
        public string[] courseLab;
        public int coursepos = 0;
        public string fullpathview;
        public bool windowFlag = false;
        public List<string> agaphmenaList = new List<string>();
        public bool pdfFlag = true;

        public Form1()
        {
            InitializeComponent();
            
        }
       

        private void GunaButton23_Click(object sender, EventArgs e)
        {
            this.GunaButton23.Visible = false;
            this.GunaButton22.Visible = true;
            // GunaButton14.Visible = False
            // GunaButton15.Visible = True
            this.GunaPanel8.Visible = false;
            this.GunaPanel8.Width = 187;
            this.GunaTransition1.ShowSync(this.GunaPanel8);
        }

        private void GunaButton22_Click(object sender, EventArgs e)
        {
            this.GunaButton22.Visible = false;
            this.GunaButton23.Visible = true;
            this.GunaPanel8.Visible = false;
            this.GunaPanel8.Width = 40;
            this.GunaTransition1.ShowSync(this.GunaPanel8);
        }
        public bool IsInternetConnected()
        {

            return new Ping().Send("www.google.com").Status == IPStatus.Success;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Timer3.Start()

            if (IsInternetConnected() == true)
            {
                GunaPictureBox3.Visible = true;
                GunaPictureBox4.Visible = false;
            }
            else
            {
                GunaPictureBox4.Visible = true;
                GunaPictureBox3.Visible = false;
            }

           
            names = new[] { "Απειροστικός Ι", "Αγγλικά", "Γενική Φυσική", "Γραμμική Άλγεβρα", "Εισαγωγή στον Προγραμματισμό", "Εισαγωγή στους Η/Υ και Πληροφορική", "Απειροστικός Λογισμός ΙΙ", "Βασικές Αρχές Κυκλωμάτων", "Διακριτά Μαθηματικά Ι", "Τεχνικές Αντικειμενοστρεφούς Προγραμματισμού", "Ανάπτυξη Λογισμικού", "Διακριτά Μαθηματικά ΙΙ", "Δομές Δεδομένων", "Πιθανότητες και Στατιστική", "Ψηφιακή Σχεδίαση Ι", "Αρχές Γλωσσών Προγραμματισμού", "Εισαγωγή στην Αριθμητική Ανάλυση", "Ηλεκτρονική", "Σχεδίαση και Ανάλυση Αλγορίθμων", "Ψηφιακή Σχεδίαση ΙΙ", "Θεωρία Υπολογισμού", "Προγραμματισμός Συστημάτων", "Σήματα και Συστήματα", "Yπολογιστικά Μαθηματικά", "Αρχιτεκτονική Υπολογιστών", "Λειτουργικά Συστήματα", "Tεχνητή Νοημοσύνη", "Τηλεπικοινωνιακά Συστήματα", "Βάσεις Δεδομένων", "Γραφικά Υπολογιστών και Συστήματα Αλληλεπίδρασης", "Δίκτυα Υπολογιστών Ι", "Δίκτυα Υπολογιστών ΙΙ", "Μεταφραστές", "Τεχνολογία Λογισμικού", "Μικροεπεξεργαστές", "Αλληλεπίδραση Ανθρώπου Υπολογιστή", "Μηχανική Μάθηση", "Ανάκτηση Πληροφορίας", "Ανάπτυξη Λογισμικού ΙΙ", "Αρχιτεκτονική Υπολογιστών ΙΙ", "Ασύρματα Δίκτυα", "Ασφάλεια Υπολογιστικών και Επικοινωνιακών Συστημάτων", "Βελτιστοποίηση", "Δοκιμή και Αξιοπιστία Ηλεκτρονικών Συστημάτων", "Εξελικτικός Υπολογισμός", "Εξόρυξη Δεδομένων", "Θεωρία Γραφημάτων", "Θεωρία Πληροφορίας και Κωδίκων", "Ιατρική Πληροφορική", "Κυκλώματα VLSI", "Μεταφραστές ΙΙ", "Παράλληλα Συστήματα και Προγραμματισμός", "Πολυμέσα", "Προηγμένη Σχεδίαση Αλγορίθμων και Δομών", "Προσομοίωση και Μοντελοποίηση Υπολογιστικών Συστημάτων", "Προχωρημένα Θέματα Τεχνολογίας και Εφαρμογών Βάσεων Δεδομένων", "Ρομποτική", "Υπολογιστική Γεωμετρία", "Υπολογιστική Νοημοσύνη", "Υπολογιστική Πολυπλοκότητα", "Ψηφιακή Επεξεργασία Εικόνας", "Διαχείριση Σύνθετων Δεδομένων", "Τεχνολογίες Διαδικτύου", "Αλγοριθμικές Τεχνικές για Δεδομένα Ευρείας Κλίμακας", "Ασύρματες Ζεύξεις", "Διδακτική της Πληροφορικής", "Εικονική, Επαυξημένη και Μικτή Πραγματικότητα", "Προηγμένες Μέθοδοι 3Δ Γραφικών" };

            typos = new[] { "Apeiro", "Agglika", "Geniki", "gramiki", "python", "unix", "apeiro2", "bak", "diak1", "java", "anaptiksi", "diak2", "domes", "pithanot", "psifiaki", "arxes", "arithmitiki", "ilektroniki", "analisi", "psifiaki2", "theoria", "C", "simata", "upologistika", "arhitek", "leitourgika", "tehniti", "tilep", "vaseis", "grafika", "diktia1", "diktia2", "metafrastes", "texnologia", "mikroepekse", "alilepidrasi", "mhxaniki", "anaktisi", "anaptiksi2", "arhitekt2", "asyrmatadiktia", "asfaleiaupolo", "veltisto", "dokimiaksia", "ekseliktikos", "eksoriksi", "theoriagraf", "theoriakodikon", "iatriki", "vlsi", "metafrastes2", "paralisistimata", "polymesa", "proigmenisxediasi", "prosomoiosi", "proxorimena", "robotiki", "geometria", "yponoimosini", "ypopoliplokotita", "psifeikonas", "sintheta", "tehnodiadiktio", "eureias", "zeukseis", "didaktiki", "eikonikh", "3dgraf" };
            courseDpLink = new[] { "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21115&authkey=AEcCE9YN0ASutt0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21114&authkey=AO-cal_wG1_p6-M", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21144&authkey=AMzCznIe2rwj-38", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21122&authkey=AEodzyGh7SygXis", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21136&authkey=AJXEZ3he4qwX0zo", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21118&authkey=AB0b2MjmwkzcAtk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21145&authkey=AE9HDhg-1Jqmft0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21145&authkey=AE9HDhg-1Jqmft0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21135&authkey=AJbgEKHKMW3Gdqo", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21121&authkey=AFzJmuFSeR_hTVs", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21119&authkey=AO08EW1LuGPQrRA", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21141&authkey=AN-TyFxJhIzESRw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21129&authkey=AIhH8c2Y2iqL4uw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21134&authkey=AEKxRYcZLKfMl1M", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21133&authkey=AHdV5-w7iNSWbE0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21120&authkey=AFjOQ6qpJ4mIItk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21143&authkey=AHMGkvltVTNhMJw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21139&authkey=ADs8F8j_YzIkA-I", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21132&authkey=AC_wNXqXYgILj14", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21123&authkey=AB_j7NjLpfQR_-Y", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21130&authkey=AIS4yQ5lGtqtGkQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21124&authkey=AFMPq1g5S27wmAQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21146&authkey=AC4ze3VY0xLWPJM", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21147&authkey=ACdn4fmWsCKMZzU", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21137&authkey=AG7Ltg4br8krDh0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21127&authkey=AHh2AWSp9keKdwY", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21131&authkey=ACnCCxDjLSJdvYg", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21142&authkey=AKjJ8UzlnaBZ2JE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21128&authkey=AKHJwKZ1oL1Ox7o", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21140&authkey=AP47mn68hvAI3Ag", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21138&authkey=AF8HAWs7rAQLNIg", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21117&authkey=AIh6m-PyMq5wje0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21125&authkey=AF4vxNPTDCKUECk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21116&authkey=AFwkVA7IKFWRsLI", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21117&authkey=AIh6m-PyMq5wje0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21170&authkey=AKhWyDlEK8-L7ek", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21168&authkey=AOQQNi55fBN2AZQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21155&authkey=AEkLRtfQWRqhxkQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21154&authkey=AJgvU7aBQaL8ems", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21148&authkey=AMUKE-jjwvwQ30I", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21161&authkey=AA96g9xnVBKrr5Y", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21159&authkey=APGCXPGynNRpu5k", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21166&authkey=AOidqbYpecJvqpw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21152&authkey=ADLsw-j7VDZVTm4", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21157&authkey=AB70Cl91syFGMDM", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21165&authkey=AG8KUhRIVVecVR0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21169&authkey=AOeXtDDVlCBVwzs", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21151&authkey=AE9NBKP2Nlp_Yxk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21167&authkey=AHKyr-K7ksmDJ2Q", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21178&authkey=AOgquofc5FjCjZM", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21153&authkey=ANmlj-kdf5xJjGE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21162&authkey=AIPE257g5DgDdcY", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21173&authkey=AAne4P84X1js9Po", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21177&authkey=ALBrytyLjzFkWGE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21160&authkey=AO3Swpoe5UaBH6k", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21163&authkey=AByWgleVhu9tvfs", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21172&authkey=AFTe4shF_Amv4Qg", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21150&authkey=AOPTANdrygr83YI", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21164&authkey=AIHFGpPJ3F3ILMc", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21156&authkey=ADaOQWlsBhojn54", "https://onedrive.live.com/downlaod?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21179&authkey=AOrO-7RlcyQmLPM", "https://onedrive.live.com/downlaod?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21174&authkey=AAarjuEUkuxo9QY", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21158&authkey=ALxBDEuoAauIDfw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21149&authkey=ALHq-gUOyS0PnYo", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21176&authkey=AC8ApbwY41Fp0L0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21171&authkey=AM-5hc6Kwf5pzlE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21171&authkey=AM-5hc6Kwf5pzlE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21175&authkey=AMBEjThe-AnCYos" };

            courseID = new[] { "MYY102", "ΜΥΥ101", "ΜΥΥ103", "ΜΥΥ104", "ΜΥΥ105", "ΜΥΥ106", "MYY202", "ΜΥΥ203", "ΜΥΥ204", "ΜΥΥ205", "ΜΥΥ301", "ΜΥΥ302", "ΜΥΥ303", "ΜΥΥ304", "ΜΥΥ305", "ΜΥΥ401", "ΜΥΥ403", "ΜΥΥ404", "ΜΥΥ405", "ΜΥΥ406", "ΜΥΥ501", "ΜΥΥ502", "ΜΥΥ503", "ΜΥΥ504", "ΜΥΥ505", "ΜΥΥ601", "ΜΥΥ602", "ΜΥΥ603", "ΜΥΥ701", "ΜΥΥ702", "ΜΥΥ703", "ΜΥΥ801", "ΜΥΥ802", "ΜΥΥ803", "MYY901", "ΜΥΕ001", "ΜΥΕ002", "ΜΥΕ003", "ΜΥΕ004", "ΜΥΕ005", "ΜΥΕ006", "ΜΥΕ007", "ΜΥΕ008", "ΜΥΕ010", "ΜΥΕ011", "ΜΥΕ012", "ΜΥΕ014", "ΜΥΕ015", "ΜΥΕ016", "MYE018", "ΜΥΕ020", "ΜΥΕ023", "ΜΥΕ025", "ΜΥΕ028", "ΜΥΕ029", "ΜΥΕ030", "ΜΥΕ031", "ΜΥΕ034", "ΜΥΕ035", "ΜΥΕ036", "ΜΥΕ037", "ΜΥΕ041", "ΜΥΕ042", "ΜΥΕ047", "ΜΥΕ048", "ΜΥΕ050", "ΜΥΕ051", "ΜΥΕ052" };


            courseEksamino = new[] { "1o", "1o", "1o", "1ο", "1ο", "1o", "2ο", "2ο", "2o", "2ο", "3ο", "3o", "3ο", "3ο", "3ο", "4ο", "4ο", "4ο", "4ο", "4ο", "5ο", "5ο", "5ο", "5ο", "5ο", "6o", "6o", "6o", "7ο", "7ο", "7ο", "8ο", "8ο", "8ο", "9o", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+", "5+" };

            courseGrade = new[] { "0", "0", "5", "9.5", "5", "6", "5", "6", "5", "7", "6", "0", "5", "5", "5", "5", "0", "0", "0", "5", "0", "6", "0", "0", "5", "0", "0", "0", "0", "0", "0", "0", "0", "0", "9", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

            courseLab = new[] { "ΟΧΙ", "ΟΧΙ", "ΟΧΙ", "ΟΧΙ", "NAI", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "NAI", "ΟΧΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ" };


            courseDiscord = new[] { "https://discord.com/channels/695303849443065947/695362927250898947", "https://discord.com/channels/695303849443065947/760901695919095866", "https://discord.com/channels/695303849443065947/695381692038512670", "https://discord.com/channels/695303849443065947/695382590588190752", "https://discord.com/channels/695303849443065947/695382119328776202", "https://discord.com/channels/695303849443065947/695382402037448775", "https://discord.com/channels/695303849443065947/695385470292721675", "https://discord.com/channels/695303849443065947/695385596276768808", "https://discord.com/channels/695303849443065947/695385783644848229", "https://discord.com/channels/695303849443065947/695385857938554901", "https://discord.com/channels/695303849443065947/695386250449780785", "https://discord.com/channels/695303849443065947/695386294619996281", "https://discord.com/channels/695303849443065947/695386342367952978", "https://discord.com/channels/695303849443065947/695386398903107685", "https://discord.com/channels/695303849443065947/695386455408640031", "https://discord.com/channels/695303849443065947/695386600930017312", "https://discord.com/channels/695303849443065947/695386697021784114", "https://discord.com/channels/695303849443065947/695386762511515668", "https://discord.com/channels/695303849443065947/695386864101621791", "https://discord.com/channels/695303849443065947/695386964186365982", "https://discord.com/channels/695303849443065947/695387115332173897", "https://discord.com/channels/695303849443065947/695387172114792469", "https://discord.com/channels/695303849443065947/695387244814401557", "https://discord.com/channels/695303849443065947/695387339576443004", "https://discord.com/channels/695303849443065947/695387420106948638", "https://discord.com/channels/695303849443065947/695387546330333184", "https://discord.com/channels/695303849443065947/695387649015414885", "https://discord.com/channels/695303849443065947/695387749355618375", "https://discord.com/channels/695303849443065947/695387847502463006", "https://discord.com/channels/695303849443065947/695387897099976744", "https://discord.com/channels/695303849443065947/695387944302805033", "https://discord.com/channels/695303849443065947/695388060661186600", "https://discord.com/channels/695303849443065947/695388129900757033", "https://discord.com/channels/695303849443065947/695388195176710224", "https://discord.com/channels/695303849443065947/695388060661186600", "https://discord.com/channels/695303849443065947/695388605044097024", "https://discord.com/channels/695303849443065947/695388701848764426", "https://discord.com/channels/695303849443065947/695388768894451713", "https://discord.com/channels/695303849443065947/695388843431690320", "https://discord.com/channels/695303849443065947/695389024004735046", "https://discord.com/channels/695303849443065947/695389110440951838", "https://discord.com/channels/695303849443065947/695389226618847332", "https://discord.com/channels/695303849443065947/695389318604128327", "https://discord.com/channels/695303849443065947/760932190144954388", "https://discord.com/channels/695303849443065947/760933382967918683", "https://discord.com/channels/695303849443065947/695389386094805062", "https://discord.com/channels/695303849443065947/695389480718303293", "https://discord.com/channels/695303849443065947/695389578588061816", "https://discord.com/channels/695303849443065947/760933630176002128", "https://discord.com/channels/695303849443065947/695389624570478712", "https://discord.com/channels/695303849443065947/760934362387578901", "https://discord.com/channels/695303849443065947/695389820935077958", "https://discord.com/channels/695303849443065947/695389913931186236", "https://discord.com/channels/695303849443065947/695394826429923369", "https://discord.com/channels/695303849443065947/940640659281412146", "https://discord.com/channels/695303849443065947/695390128771694643", "https://discord.com/channels/695303849443065947/695390129161896056", "https://discord.com/channels/695303849443065947/695390129174478889", "https://discord.com/channels/695303849443065947/695390129182736425", "https://discord.com/channels/695303849443065947/695390656293765160", "https://discord.com/channels/695303849443065947/760936030362271797", "https://discord.com/channels/695303849443065947/695390924905381899", "https://discord.com/channels/695303849443065947/760936289066287165", "https://discord.com/channels/695303849443065947/695391171945431080", "https://discord.com/channels/695303849443065947/695391258704871485", "https://discord.com/channels/695303849443065947/695391344851550259", "https://discord.com/channels/695303849443065947/760937008146677770", "https://discord.com/channels/695303849443065947/760937121225113600" };


            courseSite = new[] { "https://ecourse.uoi.gr/enrol/index.php?id=1379", "https://ecourse.uoi.gr/enrol/index.php?id=370", "https://ecourse.uoi.gr/enrol/index.php?id=432", "https://ecourse.uoi.gr/enrol/index.php?id=1347", "https://ecourse.uoi.gr/course/view.php?id=489", "https://ecourse.uoi.gr/enrol/index.php?id=276", "https://ecourse.uoi.gr/enrol/index.php?id=1536", "https://ecourse.uoi.gr/enrol/index.php?id=1525", "https://ecourse.uoi.gr/enrol/index.php?id=777", "https://ecourse.uoi.gr/enrol/index.php?id=399", "https://www.cs.uoi.gr/~pvassil/courses/sw_dev/index.html", "https://www.cse.uoi.gr/~kontog/courses/Discrete-Math-2/", "https://ecourse.uoi.gr/enrol/index.php?id=704", "https://ecourse.uoi.gr/enrol/index.php?id=575", "https://ecourse.uoi.gr/enrol/index.php?id=1592", "https://www.cse.uoi.gr/~cnomikos/courses/pl/pl-main.htm", "https://ecourse.uoi.gr/course/view.php?id=1759", "https://ecourse.uoi.gr/course/view.php?id=1517", "https://www.cse.uoi.gr/~stavros/mypage-teaching-BSc-DAA.html", "https://ecourse.uoi.gr/enrol/index.php?id=1534", "https://www.cse.uoi.gr/~palios/automata/", "https://www.cse.uoi.gr/~dimako/teaching/fall20.html", "https://ecourse.uoi.gr/course/view.php?id=870", "https://ecourse.uoi.gr/enrol/index.php?id=1731", "https://ecourse.uoi.gr/course/view.php?id=995", "https://www.cse.uoi.gr/~stergios/teaching/myy601/", "https://www.cse.uoi.gr/~arly/courses/ai/ai.html", "https://ecourse.uoi.gr/course/view.php?id=1038", "https://www.cs.uoi.gr/~pitoura/courses/db/db19/index.html", "https://ecourse.uoi.gr/enrol/index.php?id=13", "https://www.cse.uoi.gr/~epap/MYY703/", "https://users.cse.uoi.gr/~cliaskos/?Courses___MYY801___MYY801_-_EAR_2022", "https://ecourse.uoi.gr/course/view.php?id=543", "https://www.cse.uoi.gr/~zarras/se.htm", "https://ecourse.uoi.gr/enrol/index.php?id=370", "https://ecourse.uoi.gr/enrol/index.php?id=64", "https://ecourse.uoi.gr/course/view.php?id=3270", "https://ecourse.uoi.gr/course/view.php?id=871", "https://www.cs.uoi.gr/~zarras/soft-devII.htm", "https://ecourse.uoi.gr/enrol/index.php?id=1270", "https://www.cs.uoi.gr/~epap/MYE006/", "https://www.cs.uoi.gr/~stergios/teaching/mye007/", "https://ecourse.uoi.gr/course/view.php?id=329", "https://ecourse.uoi.gr/enrol/index.php?id=950", "https://ecourse.uoi.gr/ecourse_info.php?glink=/enrol/index.php&id=1503", "https://www.cs.uoi.gr/~tsap/teaching/cse012/index-gr.html", "https://ecourse.uoi.gr/enrol/index.php?id=1951", "https://ecourse.uoi.gr/enrol/index.php?id=1822", "https://ecourse.uoi.gr/enrol/index.php?id=1600", "https://www.cs.uoi.gr/~tsiatouhas/MYE018-VLSI.htm", "https://ecourse.uoi.gr/enrol/index.php?id=1636", "https://www.cse.uoi.gr/~dimako/teaching/spring21.html", "https://ecourse.uoi.gr/course/view.php?id=890", "https://ecourse.uoi.gr/enrol/index.php?id=1043", "https://ecourse.uoi.gr/enrol/index.php?id=86", "https://www.cs.uoi.gr/~pvassil/courses/db_III/index.html", "https://ecourse.uoi.gr/enrol/index.php?id=1036", "https://www.cse.uoi.gr/~palios/comp_geom/", "https://www.cse.uoi.gr/~arly/courses/nn/nn.html", "https://www.cse.uoi.gr/~cnomikos/courses/cc/cc-main.htm", "https://ecourse.uoi.gr/course/view.php?id=573", "https://ecourse.uoi.gr/course/view.php?id=1040", "https://www.cs.uoi.gr/~stergios/teaching/mye042/", "https://ecourse.uoi.gr/enrol/index.php?id=2114", "https://ecourse.uoi.gr/enrol/index.php?id=1800", "https://ecourse.uoi.gr/enrol/index.php?id=1916", "https://ecourse.uoi.gr/enrol/index.php?id=3218", "https://ecourse.uoi.gr/enrol/index.php?id=3217" };

            courseDidaskon = new[] { "ΒΑΣΙΛΕΙΟΣ ΜΠΕΝΕΚΑΣ", "ΕΥΓΕΝΙΑ ΕΥΜΟΙΡΙΔΟΥ", "ΜΑΡΙΝΑ ΤΣΕΛΕΠΗ", "ΚΩΝΣΤΑΝΤΙΝΟΣ ΠΑΡΣΟΠΟΥΛΟΣ", "Μαμουλής Νικόλαος", "ΜΑΡΙΝΑ ΠΛΗΣΙΤΗ", "ΑΠΟΣΤΟΛΟΣ ΘΩΜΑ", "Τσιατούχας Γεώργιος", "Πολενάκης Ιωσήφ", "Τσαπάρας Παναγιώτης", "Βασιλειάδης Παναγιώτης", "Κοντογιάννης Σπυρίδων", "Γεωργιάδης Λουκάς", "Μπλέκας Κωνσταντίνος", "Καβουσιανός Χρυσοβαλάντης", "Χρήστος Νομικός", "Παρσόπουλος Κωνσταντίνος", "Τσιατούχας Γεώργιος", "Νικολόπουλος Σταύρος", "Καβουσιανός Χρυσοβαλάντης", "Παληός Λεωνίδας", "Δημακόπουλος Βασίλειος", "Νίκου Χριστόφορος", "Βλάχος Κώστας", "Ευθυμίου Αριστείδης", "Αναστασιάδης Στέργιος", "Αριστείδης Λύκας", "Κόντης Λυσίμαχος-Παύλος", "Ευαγγελία Πιτουρά", "Φούντος Ιωάννης", "Παπαπέτρου Ευάγγελος", "Χρήστος Λιάσκος", "Μανής Γεώργιος", "Ζάρρας Απόστολος", "Μανής Γεώργιος", "Φούντος Ιωάννης", "Μπλέκας Κωνσταντίνος", "Πιτουρά Ευαγγελία", "Ζάρρας Απόστολος", "Ευθυμίου Αριστείδης", "Παπαπέτρου Ευάγγελος", "Αναστασιάδης Στέργιος", "Παρσόπουλος Κωνσταντίνος", "Τενέντες Βασίλειος", "Σταμάτης-Άγγελος", "Τσαπάρας Παναγιώτης", "Πολενάκης Ιωσήφ", "Νίκου Χριστόφορος", "ΕΥΑΓΓΕΛΟΣ ΟΙΚΟΝΟΜΟΥ", "Τσιατούχας Γεώργιος", "Μανής Γεώργιος", "Δημακόπουλος Βασίλειος", "Κόντης Λυσίμαχος", "Γεωργιάδης Λουκάς", "Καππές Γεώργιος", "Βασιλειάδης Παναγιώτης", "Βλάχος Κώστας", "Λεωνίδας Παληός", "Αριστείδης Λύκας", "Χρήστος Νομικός", "Νίκου Χριστόφορος", "Μαμουλής Νικόλαος", "Αναστασιάδης Στέργιος", "Κοντογιάννης Σπυρίδων", "ΧΡΗΣΤΟΣ ΛΙΑΣΚΟΣ", "Χρόνη Μαρία", "Βασιλάκης Ανδρέας", "Βασιλάκης Ανδρέας" };

            courseDrive = new[] { "https://drive.google.com/drive/u/2/folders/1WR7_4GoVxVPKgoOpbIs7LyIPE50wA4Q9", "https://drive.google.com/drive/u/2/folders/1Np5v32jr-sDbQ4nXPFXUNK9NHD7SnIk8", "https://drive.google.com/drive/u/2/folders/1zxb8Xtn3Un8Zjp3qK7cG-KY8Cajdcj9V", "https://drive.google.com/drive/u/2/folders/1KpPXPnTst73Y36Sdx_BIDH5RFFgUhBWd", "https://drive.google.com/drive/u/2/folders/1Rm3b9eZ-JOqB55N048rWxy6oXHK9kuMe", "https://drive.google.com/drive/u/2/folders/1KM3_0m2p1Ui1ickdEoX5_Z12uzGV2rIx", "https://drive.google.com/drive/u/2/folders/1QPukz-2ngiPalE3xgArXiAns2n9xraDL", "https://drive.google.com/drive/u/2/folders/109QS93AHICFiFvNnEE49WQ3CV0AHSNwS", "https://drive.google.com/drive/u/2/folders/11QimZXXKieCZlcWQlQk-hI6fe0A5ATZf", "https://drive.google.com/drive/u/2/folders/1JxXtDEtev0A4SNswS5sLt3av71yY8mpV", "https://drive.google.com/drive/u/2/folders/1k3bQiDDccaY5lJzbZt30EVPmyZzmk3_R", "https://drive.google.com/drive/u/2/folders/1_x7lykf6X9XxlmkkA1eO1KXzFVfre6Q2", "https://drive.google.com/drive/u/2/folders/1uSUQiNthltjWss_eGWdjVoAjeGMnw_I2", "https://drive.google.com/drive/u/2/folders/1FXrk7SxLy_0LBLNEvuZZ16WIe-_XVmVP", "https://drive.google.com/drive/u/2/folders/1gwz3b-PEbpmzphCGDYflCP7iERz-hDup", "https://drive.google.com/drive/u/2/folders/15j0pDjjYDdr8uIFqpBqyTiF7lkJsm18M", "https://drive.google.com/drive/u/2/folders/1N9g_xvNF0GMZhfkXxCGBMt9bjvj-eUJM", "https://drive.google.com/drive/u/2/folders/1dLnO58GOLoNZ1FuyxBkMl0fRbTxZ0wqC", "https://drive.google.com/drive/u/2/folders/12vWqUqT9Bsv-uSwQX32qYf3RSlQk5iaD", "https://drive.google.com/drive/u/2/folders/1lcgZbgOM95NWOdGD9znuqoATdmmDsjSC", "https://drive.google.com/drive/u/2/folders/1FFx4C53-fWmgftai3wlL9qalg5mk7-LX", "https://drive.google.com/drive/u/2/folders/1UMPOSjlxXDkBVUhhIjHDpHU-QS1w84DX", "https://drive.google.com/drive/u/2/folders/16zK7j7W4bgzRnNc2b90RoxYQy46ZxCQy", "https://drive.google.com/drive/u/2/folders/15pNEYqkVBSnvQBZyWaQbzw7HfsTHqH9T", "https://drive.google.com/drive/u/2/folders/1JOs9p5XHvwHHb4otRXlwjstkS-NH9Bmw", "https://drive.google.com/drive/u/2/folders/1lmPfNZopO1aHH22qDOAR0rLkKmEqu7m9", "https://drive.google.com/drive/u/2/folders/19MRFo3nZPpNMPtnr4lR1LoC5Hdn3NBNI", "https://drive.google.com/drive/u/2/folders/14MnlspndQYEYv8dQb1_U0JwzJz13drXZ", "https://drive.google.com/drive/u/2/folders/1ffob36s_GmbVQv0k23DUCuOPQlfHO14o", "https://drive.google.com/drive/u/2/folders/1jAKlBT7AHxZinjDD0e4gMk5H-0ab-2Ee", "https://drive.google.com/drive/u/2/folders/1MEaGvrY1FGru9_OFbxyv0gUc_OtQ9fk_", "https://drive.google.com/drive/u/2/folders/1aRy5bPLC7w1pmW6xFRSe_mjZkPXl-t6i", "https://drive.google.com/drive/u/2/folders/1gY1Xg2jzuoyG6KQVGfJWdLIm9RDQ4a0u", "https://drive.google.com/drive/u/2/folders/1ni3rSjEFsr85-RWvrKsI8rTZrLAsbxB_", "https://drive.google.com/drive/u/2/folders/1aRy5bPLC7w1pmW6xFRSe_mjZkPXl-t6i", "https://drive.google.com/drive/u/2/folders/1dNJaRLmFoB8j3kn0ZknYK3H7ld8X3Pm6", "https://drive.google.com/drive/u/2/folders/1xxa-zPEeolpdehqZmnmSw3yUYFwFpZuA", "https://drive.google.com/drive/u/2/folders/1acnpQ6EVRy0VGH8Wz0lfV1lkH2aYnzDD", "https://drive.google.com/drive/u/2/folders/16RYZGfUlzIfvr8l2mm2S-0N9h_21kcX7", "https://drive.google.com/drive/u/2/folders/1F_Y3APG8OoPqHOyMKInUyUCsD7KfN6RJ", "https://drive.google.com/drive/u/2/folders/1Oxd_fP1RLNIPTMgRdieZPDkjoLSYl8-y", "https://drive.google.com/drive/u/2/folders/17KZATJiEwM3BeSZF2d23cqb1f-B2CCnU", "https://drive.google.com/drive/u/2/folders/127NEbZ3xwbvcu7XI3OJl12qak3ph_RbI", "https://drive.google.com/drive/u/2/folders/1Tcxp-jQSKJD3VtAWSOcXkfBn0KpeXqG-", "https://drive.google.com/drive/u/2/folders/1aBLGJyhtdlT23DHrbuywnxkvUsfA3q4J", "https://drive.google.com/drive/u/2/folders/1sEr-2ELpE6SSuu33yRn1d1FVgfaG3IoR", "https://drive.google.com/drive/u/2/folders/1rTm918OdzeOteG_OQX8NjwTMJw_0xopQ", "https://drive.google.com/drive/u/2/folders/1PmbOT_RpHY73hC5xMoWmMbvOBEqXrbJn", "https://drive.google.com/drive/u/2/folders/1OGyF9rDV_WFaUlEkVr8Rd_RRwgsi5lP9", "https://drive.google.com/drive/u/2/folders/1mWmnZyniTqh7G7KraMxVQFqU-TpuvOM7", "https://drive.google.com/drive/u/2/folders/1wXAyxCTKlTPw5nFiDpvbimL4lxJu9MrC", "https://drive.google.com/drive/u/2/folders/1dH3XliHAnMxHRkR5RENvfh4ftUNnhUv3", "https://drive.google.com/drive/u/2/folders/1XqPNXzj4Crq6FTnesyNnVSv-0gAbltUa", "https://drive.google.com/drive/u/2/folders/1dlt-nzBUN_G0Q8WU8h22E8J80dslkUoO", "https://drive.google.com/drive/u/2/folders/1RCKEbGMdyoQn6QNif-E6W_J9oYnCeM1C", "https://drive.google.com/drive/u/2/folders/16CPuspyOQq5QIGsm0H2MRBlffAh4RTlT", "https://drive.google.com/drive/u/2/folders/1GZmF3raPmHekoIHXvA5QWLUsOBbRoQt8", "https://drive.google.com/drive/u/2/folders/1nQ00-pSjbM3wrhneJSuF9dGcVFleplYJ", "https://drive.google.com/drive/u/2/folders/1yMCo4jRUuKgLiGW22nb2cBH6VHNjeuku", "https://drive.google.com/drive/u/2/folders/1fhdlk6w_-fk9v3rrsUo37MwSl6WNNXvY", "https://drive.google.com/drive/u/2/folders/1z3lLYWH3EdHZwiOMHOMRKwNftoqtvOlz", "https://drive.google.com/drive/u/2/folders/1WyVuyxot19HUJfvHGH1GrnFpVnM_lYZX", "https://drive.google.com/drive/u/2/folders/1zC1jT5Ks_bqDHPOUJecBrK1CDN4tMZFX", "https://drive.google.com/drive/u/2/folders/1rOXXMQ-Pe1d7kdZ3gA9P2KTDWCJYarVV", "https://drive.google.com/drive/u/2/folders/1Id0EjhMpYoIkQCV8MqLb-wcAM5RKIgMY", "https://drive.google.com/drive/u/2/folders/1xzCF0DRiAtWu8sU8d_NJIGpIAYYz8ZHy", "https://drive.google.com/drive/u/2/folders/1tobxdWZbHx4Fxssyop9BycJyWFdPdJMU", "https://drive.google.com/drive/u/2/folders/1RfniogVoQZAlwz7uukqZH3PbGyZCBNAA" };



            if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form4>().Any() | Application.OpenForms.OfType<Form2>().Any())
            {
                Form4 newForm = new Form4();
                this.openChildForm(newForm);
            }


            // 'GunaTransition1.ShowSync(GunaPanel15)
            // GunaTransition2.ShowSync(GunaPanel5)

            else
            {
                Form4 newForm = new Form4();
                this.openChildForm(newForm);

            }
            this.Label4.Text = DateTime.Now.ToString("dddd/dd/MM/yyyy HH:mm:ss");
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
            this.Panel1.Controls.Add(childForm);
            this.Panel1.Tag = childForm;
            childForm.BringToFront();


            childForm.Show();



        }
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton32_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Any())
            {
                // GunaTransition2.HideSync(GunaPanel5)
                Form2 obj = (Form2)Application.OpenForms["Form2"];
                obj.Close();
                Form2 newForm = new Form2();
                

                this.openChildForm(newForm);
            }
            // 'GunaTransition1.ShowSync(GunaPanel15)
            // GunaTransition2.ShowSync(GunaPanel5)
            else
            {
                Form2 newForm = new Form2();
                this.openChildForm(newForm);
                // 'GunaTransition1.ShowSync(GunaPanel15)
                // GunaTransition2.ShowSync(GunaPanel5)
            }
        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<courseMain>().Any() | Application.OpenForms.OfType<Form2>().Any())
            {

                // GunaTransition2.HideSync(GunaPanel5)
                Form2 obj = (Form2)Application.OpenForms["Form2"];
                obj.Close();
                courseMain obj1 = (courseMain)Application.OpenForms["courseMain"];
                obj1.Close();
                Form2 newForm = new Form2();
                this.openChildForm(newForm);
            }


            // 'GunaTransition1.ShowSync(GunaPanel15)
            // GunaTransition2.ShowSync(GunaPanel5)

            else
            {
                Form2 newForm = new Form2();
                this.openChildForm(newForm);

            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void GunaSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void GunaButton27_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Έκδοση : Beta 1" + Constants.vbNewLine + "Ημερομηνία :2021-2022 " + Constants.vbNewLine + "Δημιουργός : Χρήστος Κωνσταντινίδης", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nav_settings_Click_1(object sender, EventArgs e)
        {
            
                Form4 newForm = new Form4();
                this.openChildForm(newForm);
                this.GunaAdvenceTileButton1.Checked = true;
          

        }

        private void GunaButton23_Click_1(object sender, EventArgs e)
        {
            this.GunaButton23.Visible = false;
            this.GunaButton22.Visible = true;
            this.nav_settings.Visible = true;

            this.GunaAdvenceTileButton1.Visible = false;
            this.GunaAdvenceTileButton2.Visible = false;
            this.GunaAdvenceTileButton3.Visible = false;
            this.GunaAdvenceTileButton4.Visible = false;
            this.GunaAdvenceTileButton5.Visible = false;
            this.GunaAdvenceTileButton6.Visible = false;
            this.GunaAdvenceTileButton7.Visible = false;
            this.GunaAdvenceTileButton8.Visible = false;
            this.GunaAdvenceTileButton9.Visible = false;
            this.GunaAdvenceButton1.Visible = true;
            this.GunaAdvenceButton3.Visible = true;
            this.GunaAdvenceButton4.Visible = true;
            this.GunaAdvenceButton5.Visible = true;
            this.GunaAdvenceButton6.Visible = true;
            this.GunaAdvenceButton7.Visible = true;
            this.GunaButton27.Visible = true;
            this.GunaButton31.Visible = true;
            this.Timer1.Start();
        }

        private void GunaButton22_Click_1(object sender, EventArgs e)
        {
            this.GunaButton22.Visible = false;
            this.GunaButton23.Visible = true;
            this.nav_settings.Visible = false;
            this.GunaAdvenceButton1.Visible = false;
            this.GunaAdvenceButton3.Visible = false;
            this.GunaAdvenceButton4.Visible = false;
            this.GunaAdvenceButton5.Visible = false;
            this.GunaAdvenceButton6.Visible = false;
            this.GunaAdvenceButton7.Visible = false;
            this.GunaButton27.Visible = false;
            this.GunaButton31.Visible = false;
            this.GunaAdvenceTileButton1.Visible = true;
            this.GunaAdvenceTileButton2.Visible = true;
            this.GunaAdvenceTileButton3.Visible = true;
            this.GunaAdvenceTileButton4.Visible = true;
            this.GunaAdvenceTileButton5.Visible = true;
            this.GunaAdvenceTileButton6.Visible = true;
            this.GunaAdvenceTileButton7.Visible = true;
            this.GunaAdvenceTileButton8.Visible = true;
            this.GunaAdvenceTileButton9.Visible = true;
            // GunaPanel8.Visible = False
            this.Timer2.Start();
        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {

           // closeAllForms();
            Form2 newForm = new Form2();
            this.openChildForm(newForm);
            
            this.GunaAdvenceTileButton3.Checked = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.GunaPanel8.Width > 180)
            {
                this.Timer1.Stop();
            }
            this.GunaPanel8.Width += 7;  // this line will count the width of the form, and as long as it is smaller than 858 it will continue growing

        }

        private void GunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            //closeAllForms();
            setts newForm = new setts();
            this.openChildForm(newForm);
            
            this.GunaAdvenceTileButton7.Checked = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (this.GunaPanel8.Width < 88)
            {
                this.Timer2.Stop();
            }
            this.GunaPanel8.Width -= 7;  // this line will count the width of the form, and as long as it is smaller than 858 it will continue growing
        }

        private void GunaButton31_Click(object sender, EventArgs e)
        {
            var ask = Interaction.MsgBox("Θέλετε να πραγματοποιηθέι Αποσύνδεση?", MsgBoxStyle.YesNo);
            if (ask == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            //closeAllForms();
            calendar newForm = new calendar();
            this.openChildForm(newForm);
            
            this.GunaAdvenceTileButton1.Checked = true;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            //closeAllForms();
            agaphmena newForm = new agaphmena();
            this.openChildForm(newForm);
            this.GunaAdvenceTileButton4.Checked = true;
        }

        private void GunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            Form4 newForm = new Form4();
            this.openChildForm(newForm);
            this.nav_settings.Checked = true;

        }

        private void GunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            calendar newForm = new calendar();
            this.openChildForm(newForm);
            this.GunaAdvenceButton1.Checked = true;

        }
        public void closeAllForms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form4" && Application.OpenForms[i].Name != "loginForm")
                    Application.OpenForms[i].Close();
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {


        }

        private void GunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            apps newForm = new apps();
            this.openChildForm(newForm);

            this.GunaAdvenceButton3.Checked = true;
        }

        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            apps newForm = new apps();
            this.openChildForm(newForm);
            this.GunaAdvenceTileButton6.Checked = true;
        }

        private void GunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            //closeAllForms();
            agaphmena newForm = new agaphmena();
            this.openChildForm(newForm);
            this.GunaAdvenceButton4.Checked = true;
        }

        private void GunaAdvenceTileButton7_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            setts newForm = new setts();
            this.openChildForm(newForm);
            this.GunaAdvenceButton5.Checked = true;
        }

        private void GunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            Form2 newForm = new Form2();
            this.openChildForm(newForm);
            this.GunaAdvenceButton6.Checked = true;
        }

        private void GunaAdvenceTileButton8_Click(object sender, EventArgs e)
        {
            //closeAllForms();

            links newForm = new links();
            this.openChildForm(newForm);
            this.GunaAdvenceButton7.Checked = true;
        }

        private void GunaAdvenceButton7_Click_1(object sender, EventArgs e)
        {
            links newForm = new links();
            this.openChildForm(newForm);
            this.GunaAdvenceTileButton8.Checked = true;
        }

        private void GunaAdvenceTileButton9_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            MsgBoxResult ask = (MsgBoxResult)MessageBoxAdv.Show("Θέλετε να γίνει αποσύνδεση Χρήστη?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == MsgBoxResult.Yes)
            {
                loginForm newForm = new loginForm();
                newForm.Show();
                //this.Close();
                // Application.Exit()
            }
        }

        private void GunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.Show("Έκδοση : Beta 1" + Constants.vbNewLine + "Ημερομηνία :2021-2022 " + Constants.vbNewLine + "Δημιουργός : Χρήστος Κωνσταντινίδης", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void GunaPictureBox3_Click(object sender, EventArgs e)
        {
            // MsgBox(courseGrade.Length)
        }

        private void GunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GunaPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (IsInternetConnected() == true)
            {
                this.GunaPictureBox3.Visible = true;
                this.GunaPictureBox4.Visible = false;
            }
            else
            {
                this.GunaPictureBox4.Visible = true;
                this.GunaPictureBox3.Visible = false;
            }
        }

        private void GunaControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GunaPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GunaCircleProgressBar7_Click(object sender, EventArgs e)
        {

        }

        private void GunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void GunaControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void GunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void GunaControlBox2_Click_1(object sender, EventArgs e)
        {

        }
        public void setCloseBox(bool text)
        {
            GunaControlBox2.Visible = false;
        }
        public void setLabel(string text)
        {
            Label1.Text = text;
        }
    }
}
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

namespace telekocsiForm
{
    public partial class frmFo : Form
    {
        private List<Auto> autok = new List<Auto>();
        private List<Igeny> igenyek = new List<Igeny>();

        public frmFo()
        {
            InitializeComponent();
            lbKimenet.Items.Clear();
        }

        private void btnBeolvasas_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr1 = new StreamReader("autok.csv");
                sr1.ReadLine();
                while (!sr1.EndOfStream)
                {
                    autok.Add(new Auto(sr1.ReadLine()));
                }
                sr1.Close();

                StreamReader sr2 = new StreamReader("igenyek.csv");
                sr2.ReadLine();
                while (!sr2.EndOfStream)
                {
                    igenyek.Add(new Igeny(sr2.ReadLine()));
                }
                sr2.Close();

                btnSecond.Enabled = true;
                btnBeolvasas.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Add("2. Feladat: ");
            lbKimenet.Items.Add($"   {autok.Count()} hirdető adatát tartalmazza a fájl.");
            btnSecond.Enabled = false;
            btnThird.Enabled = true;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("\n3. Feladat: ");
            int sum = 0;
            foreach (var a in autok)
            {
                if (a.Utvonal=="Budapest-Miskolc")
                {
                    sum =sum + a.Ferohely;
                }
            }
            lbKimenet.Items.Add($"   Összesen {sum} férőhelyet hirdettek az autósok Budapestről Miskolcra.");
            btnThird.Enabled = false;
            btnFourth.Enabled = true;
        }

        private void btnFourth_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add($"\n4. Feladat: ");
            int max = 0;
            string utv = "";

            var utvonalak = from a in autok
                            orderby a.Utvonal
                            group a by a.Utvonal into temp
                            select temp;

            foreach (var ut in utvonalak)
            {
                int fh = ut.Sum(x => x.Ferohely);
                if (max < fh)
                {
                    max = fh;
                    utv = ut.Key;
                }
            }
            lbKimenet.Items.Add($"   A legtöbb férőhelyet ({max}-et)");
            lbKimenet.Items.Add($"   a {utv} útvonalon ajánlották fel a hirdetők.");
            btnFourth.Enabled = false;
            btnFifth.Enabled = true;
        }

        private void btnFifth_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("\n5. feladat:");

            foreach (var ig in igenyek)
            {

                int i = ig.VanAuto(autok);


                if (i > -1)
                {
                    lbKimenet.Items.Add($"   {ig.Azonosito} => {autok[i].Rendszam}");
                }
            }
            btnFifth.Enabled = false;
            btnSixth.Enabled = true;
        }

        private void btnSixth_Click(object sender, EventArgs e)
        {
            try
            {
                lbKimenet.Items.Clear();
                lbKimenet.Items.Add("6. feladat");
                StreamWriter sw = new StreamWriter("utasuzenetek.txt");

                foreach (var ig in igenyek)
                {

                    int i = ig.VanAuto(autok);
                    if (i > -1)
                    {
                        sw.WriteLine($"{ig.Azonosito}: Rendszám: {autok[i].Rendszam}, Telefonszám: {autok[i].Telefonszam}");
                    }
                    else
                    {
                        sw.WriteLine($"{ig.Azonosito}: Sajnos nem sikerült autót találni.");
                    }

                }
                sw.Close();
                lbKimenet.Items.Add("Adatok fájlba kiírása megtörtént");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

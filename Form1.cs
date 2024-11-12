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

namespace bevasarlolista
{
    public partial class Form1 : Form
    {
        List<Bevlista> lista = new List<Bevlista>();
        void betoltes()
        {
            rtbadatok.Clear();
            FileStream fs = new FileStream("..\\..\\src\\bevasarlolista.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                rtbadatok.Text =rtbadatok.Text+sor+"\n";
                Bevlista b=new Bevlista(sor);
                lista.Add(b);
            }
            sr.Close();
            fs.Close();
            lbadat1.Text = "Tételek száma: " + lista.Count.ToString() + "db";
            int osszeg = 0;
            int max = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg = osszeg + lista[i].tetelarszamitas();
                if (lista[i].Ear > lista[max].Ear)
                {
                    max = i;
                }
            }
            lbadat2.Text = "Fizetendő ár: " + osszeg.ToString() + " Ft";
            lbadat3.Text = "LEgdrágább termék: " + lista[max].Nev;
        }
        void tetelszamitas()
        {
            if(txar.TextLength>0 && xbmennyiseg.SelectedItem != null)
            {
                int ossz = Convert.ToInt32(txar.Text)*Convert.ToInt32(xbmennyiseg.Text);
                lbfizetendo.Text= ossz.ToString()+" Ft";
                lbfizetendo.Visible= true;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtermek.TextLength == 0)
            {
                MessageBox.Show("Nem adtál terméknevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtermek.Focus();
            }
            else if (txar.TextLength==0)
            {
                MessageBox.Show("Nem adtál termék egységárát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txar.Focus();
            }
            else if(xbmennyiseg.SelectedItem == null)
            {
                MessageBox.Show("Nem adtál termék darabszámát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                xbmennyiseg.Focus();
            }
            else
            {
                FileStream fs = new FileStream("..\\..\\src\\bevasarlolista.txt", FileMode.Append);
                StreamWriter sw= new StreamWriter(fs);
                sw.Write("\n"+txtermek.Text+";"+txar.Text+";"+xbmennyiseg.SelectedItem);
                sw.Close();
                fs.Close();
                MessageBox.Show("Sikeres adatok feltöltése!:D");
                txtermek.Clear();
                txar.Clear();
                xbmennyiseg.SelectedItem = null;
                lbfizetendo.Text = "";
                betoltes();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
            for (int i = 0;i < 5; i++)
            {
                xbmennyiseg.Items.Add((i+1).ToString());
            }
        }

        private void xbmennyiseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            tetelszamitas();
        }

        private void txar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txar.TextLength>0)
                {
                    int egyar = Convert.ToInt32(txar.Text);
                    tetelszamitas();
                }
            }
            catch
            {
                MessageBox.Show("Egységárnak számot adjon meg!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txar.Clear();
                txar.Focus();
            }
        }
    }
}

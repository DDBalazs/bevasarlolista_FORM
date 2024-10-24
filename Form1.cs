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
            FileStream fs = new FileStream("bevasarlolista.txt",FileMode.Open);
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btsave_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }
    }
}

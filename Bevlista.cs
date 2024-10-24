using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace bevasarlolista
{
    internal class Bevlista
    {
        string nev;
        int ear;
        int meny;

        public string Nev { get => nev; set => nev = value; }
        public int Ear { get => ear; set => ear = value; }
        public int Meny { get => meny; set => meny = value; }
        
        public Bevlista(string sor)
        {
            string[] darabok = sor.Split(';');
            nev = darabok[0];
            ear = Convert.ToInt16(darabok[1]);
            meny = Convert.ToInt16(darabok[2]);
        }

        public int tetelarszamitas()
        {
            return meny * ear;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktarApp.Model
{
    public class RaktarKeszlet
    {
        private string termeknev;
        private int mennyiseg;
        private string mennyisegmertek;
        private double egysegar;

        public RaktarKeszlet(string termeknev, int mennyiseg, string mennyisegmertek,double egysegar)
        {
            this.termeknev = termeknev;
            this.mennyiseg = mennyiseg;
            this.mennyisegmertek = mennyisegmertek;
            this.egysegar = egysegar;
        }

        public string Termeknev
        {
            get
            { return Termeknev; }
            set
            { Termeknev = value; }
        }

        public int Mennyiseg
        {
            get
            { return Mennyiseg; }
            set
            { Mennyiseg = value; }
        }

        public string Mennyisegmertek
        {
            get 
            { return Mennyisegmertek; }
            set
            { Mennyisegmertek = value; }
        }

        public double Egysegar
        {
            get
            { return egysegar; }
            set
            { egysegar = value; }
        }

        public void BeMennyiseg(int be)
        {
            this.mennyiseg += be;
        }

        public void KiMennyiseg(int ki)
        {
            this.mennyiseg -= ki;
        }

        public void ArEmeles20()
        {
            this.egysegar *= 1.2;
        }

        public override string ToString()
        {
            return "\nA termék neve: " + termeknev + "\nRaktáron lévő mennyiség: " + mennyiseg + " " + mennyisegmertek + "\nEgységára: " + egysegar + " Ft/" + mennyisegmertek;
        }

    }
}

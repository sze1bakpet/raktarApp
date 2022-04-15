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
        private int egysegar;

        public RaktarKeszlet(string termeknev, int mennyiseg, string mennyisegmertek,int egysegar)
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

        public int Egysegar
        {
            get
            { return egysegar; }
            set
            { egysegar = value; }
        }
    }
}

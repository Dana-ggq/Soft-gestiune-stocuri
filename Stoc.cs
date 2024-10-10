using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    [Serializable]
    public abstract class Stoc : ICloneable, IComparable, IOperatii
    {
        private int cod;
        private string denumire;
        private float cantitate;

        public Stoc()
        {
            cod = 0;
            denumire = "";
            cantitate = 0;
        }

        public Stoc(int cod, string denumire, float cantitate)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.cantitate = cantitate;
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        
        public float Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Stoc s = (Stoc)obj;
            return this.cantitate.CompareTo(s.cantitate);
        }

        public override string ToString()
        {
            return "Stocul " + denumire + " are codul " + cod + ", este in cantitate de " + cantitate;
        }

        public abstract string TipStoc();

        public void maresteCantitate()
        {
            cantitate ++;
         
        }

        public void micsoreazaCantitate()
        {
            cantitate--;
        }
    }
}

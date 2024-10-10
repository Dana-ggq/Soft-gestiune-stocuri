using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    [Serializable]
   public class MateriiPrime : Stoc
    {
        private float cost;
        
        public MateriiPrime() :base()
        {
            cost = 0;
        }

        public float Cost { get => cost; set => cost = value; }

        public MateriiPrime(float cost, int cod, string denumire, float cantitate) 
            : base(cod, denumire, cantitate)
        {
            this.cost = cost;
        }

        public override string TipStoc()
        {
            return "Materie Prima";
        }

        public override string ToString()
        {
            return base.ToString() + " este materie prima si are costul " + cost;
        }
    }
}

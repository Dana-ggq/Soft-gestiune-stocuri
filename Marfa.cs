using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneStocuri
{
    [Serializable]
    public class Marfa : Stoc
    {
        private float pret;

        public Marfa() :base()
        {
            pret = 0;
        }

        public Marfa(float pret, int cod, string denumire, float cantitate)
            :base(cod, denumire, cantitate)
        {
            this.pret = pret;
        }

        public float Pret { get => pret; set => pret = value; }


        public override string TipStoc()
        {
            return "Marfa";
        }

        public override string ToString()
        {
            return base.ToString() + " este marfa si are pretul " + pret;
        }

        public static float Cantitate_Maxima(List<Marfa> lst)
        {
            float max = lst[0].Cantitate;
            foreach (Stoc c in lst)
            {
                if (c.Cantitate > max)
                    max = c.Cantitate;
            }
            return max;
        }
    }
}

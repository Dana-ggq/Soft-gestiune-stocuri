using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    [Serializable]
    class ProductieNeterminata : Stoc
    {
        string dataFinalizarii;

        public ProductieNeterminata() : base()
        {
            dataFinalizarii = "";
        }

        public ProductieNeterminata(string data, int cod, string denumire, float cantitate)
            : base(cod, denumire, cantitate)
        {
            this.dataFinalizarii = data;
        }

        public string DataFinalizarii { get => dataFinalizarii; set => dataFinalizarii = value; }

        public override string TipStoc()
        {
            return "Productie neterminata.";
        }

        public override string ToString()
        {
            return base.ToString() + " este productie nefinalizata si va fi gata in data de  " + dataFinalizarii;
        }

    }
}

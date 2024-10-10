using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    [Serializable]
    public class Comanda
    {
        private String idClient;
        private int codComanda;
        string dataComanda;
        private List<Marfa> produse;
        private float valoare;

        public Comanda()
        {
            dataComanda = "";
            codComanda = 0;
            produse = null;
            valoare = 0;
        }

        public Comanda(string data, int cod, List<Marfa> marfa)
        {
            dataComanda = data;
            codComanda = cod;
            this.produse = new List<Marfa>();
            this.produse.AddRange(marfa);
            valoare = 0;
            foreach(Marfa m in marfa)
            {
                valoare += m.Cantitate * m.Pret;
            }
        }

        public String IdCliet
        {
            get { return idClient; }
            set { idClient = value; }
        }
        public String Data
        {
            get { return dataComanda; }
            set { dataComanda = value; }
        }
        public List<Marfa> Produse
        {
            get { return produse; }
            set { produse = value; }
        }

        public int CodComanda
        {
            get { return codComanda; }
            set { codComanda = value; }
        }

        public float Valoare
        {
            get { return valoare; }
            set { valoare = value; }
        }

        public void calculValoare()
        {
            valoare = 0;
            foreach (Marfa m in produse)
            {
                valoare += m.Cantitate * m.Pret;
            }
        }
        public override string ToString()
        {
            return "Comanda cu codul " + codComanda + " are valoare " + valoare + " si a fost data in data de " + dataComanda + " de clientul " + idClient;
        }
    }
}

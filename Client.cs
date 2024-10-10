using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    [Serializable]
   public class Client
    {
        private string id;
        private string nume;
        private string email;
        private List<Comanda> comenzi;

        public Client()
        {
            id = "";
            email = "";
            nume = "";
            comenzi = null;
        }
        public Client(string id, string num, string email, List<Comanda> com)
        {
            this.id = id;
            nume = num;
            this.email = email;
            this.comenzi = new List<Comanda>();
            this.comenzi.AddRange(com);
   
        }


        public List<Comanda> Comenzi
        {
            get { return comenzi; }
            set { comenzi = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            string msg = "Clientul " + nume + " are email-ul " + email + " si  a dat urmatoarele comenzi: ";
            foreach(Comanda c in comenzi)
            {
                msg += c.ToString() + Environment.NewLine;
            }
            return msg;
        }
    }
}

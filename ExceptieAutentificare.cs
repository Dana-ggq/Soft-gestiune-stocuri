using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneStocuri
{
    class ExceptieAutentificare : Exception
    {
        public override string Message
        {
            get { return "Utilizator sau parola incorecte."; }
        }
    }
}

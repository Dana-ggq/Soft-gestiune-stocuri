using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneStocuri
{
    public partial class FormComenziClient : Form
    {
        public FormComenziClient()
        {
            InitializeComponent();
        }

        private void FormComenziClient_Load(object sender, EventArgs e)
        {
            IDataObject o = Clipboard.GetDataObject();
            if (o.GetDataPresent(typeof(Client)))
            {
                Client client = (Client)o.GetData(typeof(Client));
               foreach(Comanda c in client.Comenzi)
                {
                    textBox1.Text += c.ToString() + Environment.NewLine;
                }


            }
            else
            {
                this.Close();
            }
        }
    }
}

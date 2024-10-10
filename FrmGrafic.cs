using GraficLibrary;
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
    public partial class FrmGrafic : Form
    {
        List<Chart> elemente;
        
        public FrmGrafic(List<Marfa> lstMarfa)
        {
            this.elemente = new List<Chart>();
            foreach(Marfa m in lstMarfa)
            {
                elemente.Add(new Chart((int)m.Cantitate, m.Denumire));
            }
            InitializeComponent();
        }

        private void FrmGrafic_Load(object sender, EventArgs e)
        {
            grafic1.Elemente = elemente;
        }
    }
}

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
    public partial class FrmMeniu : Form
    {
        List<Marfa> lstMArfa;
        List<Client> lstClienti;
        public FrmMeniu()
        {
            InitializeComponent();
            lstMArfa = new List<Marfa>();
            lstClienti = new List<Client>();
        }

        private void btnStoc_Click(object sender, EventArgs e)
        {
            FrmStoc frm = new FrmStoc(lstMArfa);
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            FrmClienti frm = new FrmClienti(lstClienti);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            FrmComenzi frm = new FrmComenzi(lstClienti, lstMArfa);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void delogareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void FrmMeniu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

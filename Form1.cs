using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneStocuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(180, Color.LightSkyBlue);
        }

        private void cbAfisareParola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfisareParola.Checked == true)
            {
                mtbParola.UseSystemPasswordChar = false;
            }
            else
            {
                mtbParola.UseSystemPasswordChar = true;

            }
        }

        bool utilizator_existent(string utilizator, string parola)
        {
            bool ok = false;
            StreamReader sr = new StreamReader("utilizatori.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                string ut = linie.Split(',')[0];
                string pa = linie.Split(',')[1];
                if (utilizator.Equals(ut) && parola.Equals(pa))
                    ok = true;
            }
            sr.Close();
            return ok;
            
        }
        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            try
            {
                if (utilizator_existent(tbUtilizator.Text, mtbParola.Text) == true)
                {
                    FrmMeniu frm = new FrmMeniu();
                    frm.Show();
                    this.Hide();
                    
                }
                else
                    throw new ExceptieAutentificare();
            }
            catch (ExceptieAutentificare ex)
            {
                MessageBox.Show(panel1, ex.Message);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(panel1, ex.Message);
            }
            finally
            {
                tbUtilizator.Clear();
                mtbParola.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneStocuri
{
    public partial class FrmComenzi : Form
    {
        List<Client> lstClienti;
        List<Marfa> lstMarfa;
        List<Comanda> lstComenzi;

        Comanda comandaCurenta;
        Marfa produsCurent;
        public FrmComenzi(List<Client> lstClienti, List<Marfa> lstMarfa)
        {
            this.lstClienti = lstClienti;
            this.lstMarfa = lstMarfa;
            lstComenzi = new List<Comanda>();
            foreach (Client c in lstClienti)
                foreach (Comanda com in c.Comenzi)
                {
                    com.IdCliet = c.Id;
                    lstComenzi.Add(com);
                }
            
            InitializeComponent();
            tbIdClient.AllowDrop = true;

            populare_listaClienti();
            populare_listaMarfa();

            comandaCurenta = new Comanda();
            comandaCurenta.Produse = new List<Marfa>();
        }

        public void populare_listaClienti()
        {
               listBoxClienti.Items.Clear();
           
                foreach (Client client in lstClienti)
                {
                    listBoxClienti.Items.Add(client.Id + "-" + client.Nume);
                    
                }
            
        }

        public void populare_listaMarfa()
        {
                lwMarfa.Items.Clear();
            foreach (Marfa marfa in lstMarfa)
            {
                ListViewItem item = new ListViewItem(marfa.Cod.ToString());
                item.SubItems.Add(marfa.Denumire);
                item.SubItems.Add(marfa.Cantitate.ToString());
                item.SubItems.Add(marfa.Pret.ToString());


                lwMarfa.Items.Add(item);
            }
        }

        public void populare_lista_ProduseComandate()
        {
            lwComanda.Items.Clear();
            float val= 0;
            foreach (Marfa marfa in comandaCurenta.Produse)
            {
                ListViewItem item = new ListViewItem(marfa.Cod.ToString());
                item.SubItems.Add(marfa.Denumire);
                item.SubItems.Add(marfa.Pret.ToString());
                item.SubItems.Add(marfa.Cantitate.ToString());
                item.SubItems.Add((marfa.Pret * marfa.Cantitate).ToString());
                val += marfa.Pret * marfa.Cantitate;

                lwComanda.Items.Add(item);
            }
            tbValoareTotala.Text = val.ToString();
        }

              
        private void btnMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmComenzi_KeyDown(object sender, KeyEventArgs e)
        {
            //control + x inchide aplicatia
            if (e.Control && e.KeyCode == Keys.X)
            {
                Dispose();
                //  Application.Exit();
                Environment.Exit(0);
            }

            //control + m revine la meniu
            if (e.Control && e.KeyCode == Keys.M)
            {
                this.Close();
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            tbCantitate.Text = "";
            tbCodComanda.Text = "";
            tbData.Text = "";
            lwComanda.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FrmIstoricComenzi frm = new FrmIstoricComenzi(lstComenzi);
            frm.Show();
        }

        private void lwMarfa_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(lwMarfa.SelectedItems[0] != null)
                {
                    int index = lwMarfa.SelectedItems[0].Index;
                    produsCurent = lstMarfa[index];
                    tbCantitate.Text = "1";
                    btnAdaugaProdus.Enabled = true;
                }
            }
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(tbCantitate.Text) > produsCurent.Cantitate)
                    throw new ExceptiePersonala("Stoc insuficient");
                Marfa prod = new Marfa(produsCurent.Pret, produsCurent.Cod, produsCurent.Denumire, Int32.Parse(tbCantitate.Text));
                produsCurent.Cantitate -= Int32.Parse(tbCantitate.Text);
                if (comandaCurenta.Produse.Count > 0)
                {
                    int ok = 0;
                    foreach (Marfa m in comandaCurenta.Produse)
                    {
                        if (m.Cod == produsCurent.Cod)
                        {
                            m.Cantitate += Int32.Parse(tbCantitate.Text);
                            ok = 1;
                        }
                       
                    }
                    if(ok==0)
                        comandaCurenta.Produse.Add(prod);
                }
                else
                {
                    comandaCurenta.Produse.Add(prod);
                }
                populare_listaMarfa();
                populare_lista_ProduseComandate();
            }
            catch(ExceptiePersonala ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "A aparut o eroare. Incercati din nou.");
            }
            finally
            {
                tbCantitate.Text = "";
            }
            btnAdaugaProdus.Enabled = false;
        }

        private void lwComanda_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void cresteCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwComanda.SelectedItems[0] != null)
            {
                ListViewItem item = lwComanda.SelectedItems[0];
                int index = item.Index;

                comandaCurenta.Produse[index].maresteCantitate();
                Marfa marfa = lstMarfa.Find(m => m.Cod == comandaCurenta.Produse[index].Cod);
                marfa.micsoreazaCantitate();

                populare_listaMarfa();
                populare_lista_ProduseComandate();
            }
        }
        private void scadeCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lwComanda.SelectedItems[0];
            int index = item.Index;

            comandaCurenta.Produse[index].micsoreazaCantitate();
            Marfa marfa = lstMarfa.Find(m => m.Cod == comandaCurenta.Produse[index].Cod);
            marfa.maresteCantitate();

            if (comandaCurenta.Produse[index].Cantitate ==0)
                comandaCurenta.Produse.RemoveAt(index);

            populare_listaMarfa();
            populare_lista_ProduseComandate();
        }

        private void eliminaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lwComanda.SelectedItems[0];
            int index = item.Index;

            Marfa marfa = lstMarfa.Find(m => m.Cod == comandaCurenta.Produse[index].Cod);
            marfa.Cantitate += comandaCurenta.Produse[index].Cantitate;
            comandaCurenta.Produse.RemoveAt(index);

            populare_listaMarfa();
            populare_lista_ProduseComandate();
        }

        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
               
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCodComanda.Text == "" || tbData.Text == "")
                    throw new ExceptiePersonala("Completati toate campurile.");
                else if (tbIdClient.Text == "")
                    throw new ExceptiePersonala("Selectati client.");
                else if (lstComenzi.Find(c => c.CodComanda == Int32.Parse(tbCodComanda.Text)) != null)
                    throw new ExceptiePersonala("Cod existent.");
                else
                {
                    comandaCurenta.IdCliet = tbIdClient.Text;
                    comandaCurenta.CodComanda = Int32.Parse(tbCodComanda.Text);
                    comandaCurenta.Data = tbData.Text;
                    comandaCurenta.Valoare = (float)Double.Parse(tbValoareTotala.Text);

                    Comanda c = new Comanda();
                    c.IdCliet = tbIdClient.Text;
                    c.CodComanda = Int32.Parse(tbCodComanda.Text);
                    c.Data = tbData.Text;
                    c.Valoare = (float)Double.Parse(tbValoareTotala.Text);
                    c.Produse = new List<Marfa>(comandaCurenta.Produse.ToArray());

                    lstComenzi.Add(c);
                    foreach (Client client in lstClienti)
                        if (client.Id == tbIdClient.Text)
                            client.Comenzi.Add(c);
                    
                    DialogResult dlg = MessageBox.Show("Doriti sa printati datele comenzii?", "Confirmare", MessageBoxButtons.YesNo);
                    if(dlg == DialogResult.Yes)
                    {
                        pageSetupDialog.Document = printDocument;
                        pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
                        if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;

                            printPreviewDialog.Document = printDocument;
                            printPreviewDialog.ShowDialog();
                        }
                        
                    }

                        comandaCurenta.Produse.Clear();
                        tbCodComanda.Text = "";
                        tbData.Text = "";
                        tbIdClient.Text = "";
                        lwComanda.Items.Clear();
                        tbValoareTotala.Text = "";
                    
                }
            }
            catch(ExceptiePersonala ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele nu sunt valide sau sunt incomplete.");
            }
           
            
        }

        private void FrmComenzi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(lwComanda.Items.Count>0)
            {
                MessageBox.Show("Comanda nefinalizata. Fianlizati comanda sau stergeti articolele din cos.");
                e.Cancel = true;
            }
        }

    
       private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics; 

            Font font = new Font("Times New Roman", 20);
            Brush brush = Brushes.Black; 
            Pen pen = new Pen(brush); 

            PageSettings pageSettings = printDocument.DefaultPageSettings;
            var totalWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            var totalHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;

        if (pageSettings.Landscape)
            {
                var aux = totalHeight;
                totalHeight = totalWidth;
                totalWidth = aux;
            }

            var cellW = 300;
            var cellH = 30;

            var x = pageSettings.Margins.Left;
            var y = pageSettings.Margins.Top;


            graphics.DrawRectangle(pen, x, y, cellW, 3 * cellH);
            graphics.DrawString("   Comanda: " + comandaCurenta.CodComanda.ToString(), font, brush, x, y);
            graphics.DrawString("   Client:  " + comandaCurenta.IdCliet.ToString(), font, brush, x, y+cellH);
            graphics.DrawString("   Data:    " + comandaCurenta.Data.ToString(), font, brush, x, y+2*cellH);

            y = y + 5 * cellH;
            cellW = 70;
            graphics.DrawString("   Produse: ", font, brush, x, y);
            y = y + 2 * cellH;

            font = new Font("Times New Roman", 18);
            foreach (Marfa m in comandaCurenta.Produse)
            {
                
                graphics.DrawString(m.Cod.ToString() + " ", font, brush, x, y);
                graphics.DrawString(m.Denumire + " ", font, brush, x + cellW, y);
                graphics.DrawString(m.Cantitate.ToString() + " X " + m.Pret.ToString() + " lei", font, brush, totalWidth - 2*cellW, y);

                y += cellH;
            }
            graphics.DrawLine(pen, new Point(totalWidth - 2 * cellW, y), new Point(totalWidth - 10, y));
            graphics.DrawString(tbValoareTotala.Text + " lei", font, brush, totalWidth - 2 * cellW, y+2);
    
        }

        private void listBoxClienti_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listBoxClienti.SelectedItem != null)
                    listBoxClienti.DoDragDrop((listBoxClienti.SelectedItem.ToString()).Split('-')[0], DragDropEffects.Copy);
            }
        }

        private void listBoxClienti_DragDrop(object sender, DragEventArgs e)
        {
            tbIdClient.Text = (string)e.Data.GetData(DataFormats.Text, true);
        }

        private void tbIdClient_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void copiazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxClienti.SelectedItems[0] != null)
            {
                Client s = lstClienti[listBoxClienti.SelectedIndex];
                Clipboard.SetDataObject(s);
                FormComenziClient form = new FormComenziClient();
                form.ShowDialog();
            }
        }

        private void listBoxClienti_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStripCLIENTI.Show(Cursor.Position);
            }
        }
    }
}


public class ExceptiePersonala : Exception
{
    string msg;
    public ExceptiePersonala(string msg) : base(msg) { }
}
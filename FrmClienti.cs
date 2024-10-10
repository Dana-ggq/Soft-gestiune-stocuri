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
using System.Xml;
using System.Xml.Serialization;

namespace GestiuneStocuri
{
    public partial class FrmClienti : Form
    {
        List<Client> lstClienti;
        Client client;
        public FrmClienti(List<Client> lstClienti)
        {
            InitializeComponent();
            this.lstClienti = lstClienti;
            // lstClienti = new List<Client>();
            afisareTreeView();
            
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (!tbId.Text.All(char.IsDigit))
            {
                errId.SetError((Control)sender, "Id invalid.");
                e.Cancel = true;
            }
        }

        private void tbId_Validated(object sender, EventArgs e)
        {
            errId.Clear();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                errNume.SetError((Control)sender, "Completati numele.");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errNume.Clear();
        }

        private void afisareTreeView()
        {
            
            treeViewClienti.Nodes.Clear();
            foreach (Client c in lstClienti)
            {
                //constructor implicit -> nodul nu are text
                //nodul parinte -> denumirea activitatii
                TreeNode parinte = new TreeNode(c.Id + "-" + c.Nume + "-" + c.Email);
                treeViewClienti.Nodes.Add(parinte);

                TreeNode copil = new TreeNode("Comenzi:");
               // copil.Text = "Comenzi: ";
                parinte.Nodes.Add(copil);

                if (c.Comenzi != null)
                {
                    for (int i = 0; i < c.Comenzi.Count(); i++)
                    {
                        TreeNode nepot = new TreeNode(c.Comenzi[i].CodComanda + "-" + c.Comenzi[i].Data + "-" + c.Comenzi[i].Valoare + " lei");
                        copil.Nodes.Add(nepot);

                    }
                }
            }

        }

        private void golireFormular()
        {
            tbEmail.Clear();
            tbId.Clear();
            tbNume.Clear();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            int ok = 0;
            foreach(Client c in lstClienti)
            {
                if (c.Id.Equals(tbId.Text))
                    ok = 1;
            }
            if (tbId.Text == "")
            {
                errId.SetError(tbId, "Introduceti Id-ul.");
            }
            else if(ok == 1)
            {
                errId.SetError(tbId, "Id existent.");
            }
            else
            {
                errId.Clear();
                cl.Id = tbId.Text;
                cl.Nume = tbNume.Text;
                cl.Email = tbEmail.Text;
                cl.Comenzi = new List<Comanda>();
                lstClienti.Add(cl);
                afisareTreeView();
                golireFormular();
                    
            }
             
        }

        private void importaTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                String linie = null;
                while ((linie = sr.ReadLine()) != null)
                {
                    Client a = new Client();
                    a.Id = linie.Split('-')[0];
                    a.Nume = linie.Split('-')[1];
                    a.Email = linie.Split('-')[2];
                    int nrComenzi = Convert.ToInt32(linie.Split('-')[3]);
                    a.Comenzi = new List<Comanda>();
                    for (int i = 0; i < nrComenzi; i++)
                    {
                        if ((linie = sr.ReadLine()) != null)
                        {
                            Comanda c = new Comanda();
                            c.CodComanda = Convert.ToInt32(linie.Split('-')[0]);
                            c.Data = linie.Split('-')[1];
                            c.Valoare = (float)Convert.ToDouble(linie.Split('-')[2]);
                            a.Comenzi.Add(c);
                        }
                    }
                    int ok = 0;
                    foreach (Client c in lstClienti)
                    {
                        if (c.Id.Equals(a.Id))
                            ok = 1;
                    }
                    if(ok == 0)
                        lstClienti.Add(a);
                }
                afisareTreeView();
                sr.Close();
                fileStream.Close();
            }
        }

        private void btnMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Clienti");
            foreach (TreeNode parinte in treeViewClienti.Nodes)
            {
                writer.WriteStartElement(parinte.Text);

                TreeNode copil = parinte.Nodes[0];
                {
                    writer.WriteStartElement(copil.Text);
                    foreach (TreeNode nepot in copil.Nodes)
                    {
                        writer.WriteStartElement(nepot.Text);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter("clienti.xml");
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("S-a exportat fisierul clienti.xml.");
        }

        private void treeViewClienti_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void actualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewClienti.SelectedNode != null)
            {
                TreeNode node = treeViewClienti.SelectedNode;
                int index = node.Index;
                client = lstClienti[index];
                tbId.Text = client.Id;
                tbEmail.Text = client.Email;
                tbNume.Text = client.Nume;
                btnActualizare.Enabled = true;
                btnAdaugare.Enabled = false;
                btnSterge.Enabled = false;



            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = treeViewClienti.SelectedNode;

            if (nodSelectat!=null && nodSelectat.Text.Equals("Comenzi:")==false)
            {
                if (nodSelectat.Parent == null)
                {
                    int index = nodSelectat.Index;
                    client = lstClienti[index];
                    tbId.Text = client.Id;
                    tbEmail.Text = client.Email;
                    tbNume.Text = client.Nume;

                    btnSterge.Enabled = true;
                    btnAdaugare.Enabled = false;
                    btnActualizare.Enabled = false;

                }
                else
                {
                    TreeNode parent = nodSelectat.Parent.Parent;
                    int index = parent.Index;
                    int CodComanda;
                    try
                    {
                        CodComanda = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);
                        lstClienti[index].Comenzi.RemoveAll(com => com.CodComanda == CodComanda);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        afisareTreeView();
                    }
                }
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            btnAdaugare.Enabled = false;

            client.Id = tbId.Text;
            client.Nume = tbNume.Text;
            client.Email = tbEmail.Text;
            golireFormular();
            afisareTreeView();
            btnActualizare.Enabled = false;
            btnAdaugare.Enabled = true;

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

            btnAdaugare.Enabled = false;

            lstClienti.RemoveAll(cl => cl.Id == tbId.Text && cl.Email == tbEmail.Text && client.Nume == tbNume.Text);
            afisareTreeView();
            btnSterge.Enabled = false;
            btnAdaugare.Enabled = true;
            golireFormular();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            golireFormular();
            btnActualizare.Enabled = false;
            btnSterge.Enabled = false;
            btnAdaugare.Enabled = true;
        }

        private void FrmClienti_KeyDown(object sender, KeyEventArgs e)
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
    }
 }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GestiuneStocuri
{
    public partial class FrmStoc : Form
    {
        
        String connectionString;
        OleDbConnection connection;


        List<Marfa> lstMArfa;
        List<MateriiPrime> lstMateriiPrime;
        List<ProductieNeterminata> lstProductieNeterminata;

        public FrmStoc(List<Marfa> lst)
        {
            InitializeComponent();
            //lstMArfa = new List<Marfa>();
            this.lstMArfa = lst;
            lstMateriiPrime = new List<MateriiPrime>();
            lstProductieNeterminata = new List<ProductieNeterminata>();

            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = stoc.accdb";
            connection = new OleDbConnection(connectionString);

            citire_materiiPrime_BD();
            populare_lista_materiiPrime();

            citire_productieNeterminata_BD();
            populare_lista_materiiPrime();
        }


        private void citire_materiiPrime_BD()
        { 
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM MateriiPrime";

                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MateriiPrime m = new MateriiPrime((float)Convert.ToDouble(dataReader["Cost"]), Convert.ToInt32(dataReader["Cod"]), dataReader["Denumire"].ToString(),
                        (float)Convert.ToDouble(dataReader["Cantitate"]));

                    lstMateriiPrime.Add(m);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void citire_productieNeterminata_BD()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM ProductieNeterminata";

                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ProductieNeterminata p = new ProductieNeterminata(dataReader["DataFinalizarii"].ToString(), Convert.ToInt32(dataReader["Cod"]), dataReader["Denumire"].ToString(),
                        (float)Convert.ToDouble(dataReader["Cantitate"]));

                    lstProductieNeterminata.Add(p);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void populare_lista_marfa()
        {
            golireLista();
            listView1.Columns[3].Text = "Pret";
            foreach (Marfa marfa in lstMArfa)
            {
                ListViewItem item = new ListViewItem(marfa.Cod.ToString());
                item.SubItems.Add(marfa.Denumire);
                item.SubItems.Add(marfa.Cantitate.ToString());
                item.SubItems.Add(marfa.Pret.ToString());


                listView1.Items.Add(item);
            }
            cbTipStoc.SelectedItem = cbTipStoc.Items[0];
        }

        private void populare_lista_materiiPrime()
        {
            golireLista();
            listView1.Columns[3].Text = "Cost";
            foreach (MateriiPrime mat in lstMateriiPrime)
            {
                ListViewItem item = new ListViewItem(mat.Cod.ToString());
                item.SubItems.Add(mat.Denumire);
                item.SubItems.Add(mat.Cantitate.ToString());
                item.SubItems.Add(mat.Cost.ToString());


                listView1.Items.Add(item);
            }
            cbTipStoc.SelectedItem = cbTipStoc.Items[2];
        }

        private void populare_lista_productieNeterminata()
        {
            golireLista();
            listView1.Columns[3].Text = "Data finalizarii";
            foreach (ProductieNeterminata prod in lstProductieNeterminata)
            {
                ListViewItem item = new ListViewItem(prod.Cod.ToString());
                item.SubItems.Add(prod.Denumire);
                item.SubItems.Add(prod.Cantitate.ToString());
                item.SubItems.Add(prod.DataFinalizarii);


                listView1.Items.Add(item);
            }
            cbTipStoc.SelectedItem = cbTipStoc.Items[1];
        }
        private void golireLista()
        {
            listView1.Items.Clear();
        }
        private void rbMarfa_CheckedChanged(object sender, EventArgs e)
        {
            labelMateriiPrime.Visible = false;
            tbMateriiPrime.Visible = false;

            labelProductieNeterminata.Visible = false;
            tbProductieNeterminata.Visible = false;

            labelMarfa.Visible = true;
            tbMarfa.Visible = true;

        }

        private void rbProductieNeterminata_CheckedChanged(object sender, EventArgs e)
        {
            labelMateriiPrime.Visible = false;
            tbMateriiPrime.Visible = false;

            labelProductieNeterminata.Visible = true;
            tbProductieNeterminata.Visible = true;

            labelMarfa.Visible = false;
            tbMarfa.Visible = false;

        }

        private void rbMateriiPrime_CheckedChanged(object sender, EventArgs e)
        {
            labelMateriiPrime.Visible = true;
            tbMateriiPrime.Visible = true;

            labelProductieNeterminata.Visible = false;
            tbProductieNeterminata.Visible = false;

            labelMarfa.Visible = false;
            tbMarfa.Visible = false;

        }

        private void FrmStoc_KeyDown(object sender, KeyEventArgs e)
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
            if (cbTipStoc.Text.Equals("Marfa"))
                populare_lista_marfa();
            else if (cbTipStoc.Text.Equals("Materii Prime"))
                populare_lista_materiiPrime();
            else if (cbTipStoc.Text.Equals("Productie Neterminata"))
                populare_lista_productieNeterminata();
        }

        private void golire_Formular()
        {
            tbCantiate.Text = "";
            tbCod.Text = "";
            tbDenumire.Text = "";
            tbMarfa.Text = "";
            tbMateriiPrime.Text = "";
            tbProductieNeterminata.Text = "";
            rbMarfa.Checked = false;
            rbMateriiPrime.Checked = false;
            rbProductieNeterminata.Checked = false;
        }

        private void adauga_marfa()
        {
            try
            {
                Marfa marfa = new Marfa();
                marfa.Denumire = tbDenumire.Text;
                marfa.Cod = Int32.Parse(tbCod.Text);
                int ok = 0;
                foreach (Marfa m in lstMArfa)
                {
                    if (m.Cod == marfa.Cod)
                        ok = 1;
                }
                if (ok == 1)
                    throw new ExceptiePersonala("Cod existent! Reintroduceti");
                marfa.Cantitate = Int32.Parse(tbCantiate.Text);
                marfa.Pret = Int32.Parse(tbMarfa.Text);
                lstMArfa.Add(marfa);
                populare_lista_marfa();
            }
            catch (ExceptiePersonala ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele introduse sunt invalide sau incomplete. Reintroduceti.");
            }
            finally
            {
                golire_Formular();
            }

        }
        private void adauga_MateriiPrime()
        {
            try
            {
                MateriiPrime mat = new MateriiPrime();
                mat.Denumire = tbDenumire.Text;
                mat.Cod = Int32.Parse(tbCod.Text);
                int ok = 0;
                foreach (MateriiPrime m in lstMateriiPrime)
                {
                    if (m.Cod == mat.Cod)
                        ok = 1;
                }
                if (ok == 1)
                    throw new ExceptiePersonala("Cod existent! Reintroduceti");
                mat.Cantitate = Int32.Parse(tbCantiate.Text);
                mat.Cost = Int32.Parse(tbMateriiPrime.Text);
                lstMateriiPrime.Add(mat);
                populare_lista_materiiPrime();
            }
            catch (ExceptiePersonala ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele introduse sunt invalide. Reintroduceti.");
            }
            finally
            {
                golire_Formular();
            }
        }
        private void adauga_productieNeterminata()
        {
            ProductieNeterminata prod = new ProductieNeterminata();
            try
            {
                prod.Denumire = tbDenumire.Text;
                prod.Cod = Int32.Parse(tbCod.Text);
                int ok = 0;
                foreach (ProductieNeterminata m in lstProductieNeterminata)
                {
                    if (m.Cod == prod.Cod)
                        ok = 1;
                }
                if (ok == 1)
                    throw new ExceptiePersonala("Cod existent! Reintroduceti");
                prod.Cantitate = Int32.Parse(tbCantiate.Text);
                prod.DataFinalizarii = tbProductieNeterminata.Text;
                lstProductieNeterminata.Add(prod);
                populare_lista_productieNeterminata();
            }
            catch (ExceptiePersonala ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele introduse sunt invalide. Reintroduceti.");
            }
            finally
            {
                golire_Formular();
            }

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errCod.SetError(tbCod, "Introduceti cod!");
            else if (tbDenumire.Text == "")
                errDenumire.SetError(tbDenumire, "Introduceti denumire!");
            else if (!rbMateriiPrime.Checked && !rbMarfa.Checked && !rbProductieNeterminata.Checked)
                errTipStoc.SetError(rbMateriiPrime, "Selectati tipul stocului!");
            else if (rbMarfa.Checked)
            {
                adauga_marfa();
                //cbTipStoc.Text = "Marfa";
            }
            else if (rbMateriiPrime.Checked)
            {
                adauga_MateriiPrime();
                // cbTipStoc.Text = "Materii Prime";
            }
            else if (rbProductieNeterminata.Checked)
            {
                adauga_productieNeterminata();
                // cbTipStoc.Text = "Productie Neterminata";
            }

        }

        private void btnMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;
                errCod.Clear();
            }
            else
            {
                e.Handled = true;
                errCod.SetError(tbCod, "Ati tastat o litera!");
            }
        }

        private void tbCantiate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;
                errCantitate.Clear();
            }
            else
            {
                e.Handled = true;
                errCantitate.SetError(tbCantiate, "Ati tastat o litera!");
            }
        }

        private void tbMateriiPrime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;
                errO.Clear();
            }
            else
            {
                e.Handled = true;
                errO.SetError(tbMateriiPrime, "Ati tastat o litera!");
            }
        }

        private void tbMarfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;
                errO.Clear();
            }
            else
            {
                e.Handled = true;
                errO.SetError(tbMarfa, "Ati tastat o litera!");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void cresteCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int index = item.Index;

                if (listView1.Columns[3].Text.Equals("Pret"))
                {
                    lstMArfa[index].maresteCantitate();
                    populare_lista_marfa();
                }
                else if (listView1.Columns[3].Text.Equals("Cost"))
                {
                    lstMateriiPrime[index].maresteCantitate();
                    populare_lista_materiiPrime();
                }
                else if (listView1.Columns[3].Text.Equals("Data finalizarii"))
                {
                    lstProductieNeterminata[index].maresteCantitate();
                    populare_lista_productieNeterminata();
                }

            }
        }

        private void scadeCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int index = item.Index;

                if (listView1.Columns[3].Text.Equals("Pret"))
                {
                    lstMArfa[index].micsoreazaCantitate();
                    populare_lista_marfa();
                }
                else if (listView1.Columns[3].Text.Equals("Cost"))
                {
                    lstMateriiPrime[index].micsoreazaCantitate();
                    populare_lista_materiiPrime();
                }
                else if (listView1.Columns[3].Text.Equals("Data finalizarii"))
                {
                    lstProductieNeterminata[index].micsoreazaCantitate();
                    populare_lista_productieNeterminata();
                }

            }
        }

        private void cbTipStoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelIndex = cbTipStoc.SelectedIndex;
            switch (SelIndex)
            {
                case 0:
                    rbMarfa.Checked = true;
                    break;
                case 1:
                    rbProductieNeterminata.Checked = true;
                    break;
                case 2:
                    rbMateriiPrime.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCantiate.Text = "";
            tbCod.Text = "";
            tbDenumire.Text = "";
            tbMarfa.Text = "";
            tbMateriiPrime.Text = "";
            tbProductieNeterminata.Text = "";
            rbMarfa.Checked = false;
            rbProductieNeterminata.Checked = false;
            rbMateriiPrime.Checked = false;
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0] != null)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int index = item.Index;

                if (listView1.Columns[3].Text.Equals("Pret"))
                {
                    lstMArfa.RemoveAt(index);
                    populare_lista_marfa();
                }
                else
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        if (listView1.Columns[3].Text.Equals("Cost"))
                        {
                            lstMateriiPrime.RemoveAt(index);
                            command.CommandText = "DELETE FROM MateriiPrime WHERE Cod = " + listView1.SelectedItems[0].SubItems[0].Text;
                            command.ExecuteNonQuery();
                            populare_lista_materiiPrime();

                        }
                        else if (listView1.Columns[3].Text.Equals("Data finalizarii"))
                        {
                            lstProductieNeterminata.RemoveAt(index);
                            command.CommandText = "DELETE FROM ProductieNeterminata WHERE Cod = " + listView1.SelectedItems[0].SubItems[0].Text;
                            command.ExecuteNonQuery();
                            populare_lista_productieNeterminata();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        //citiri txt
        private void materiiPrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                String linie = null;
                try
                {
                    while ((linie = sr.ReadLine()) != null)
                    {
                        MateriiPrime a = new MateriiPrime();
                        a.Cod = Int32.Parse(linie.Split('-')[0]);
                        a.Denumire = linie.Split('-')[1];
                        a.Cantitate = Int32.Parse(linie.Split('-')[2]);
                        a.Cost = Int32.Parse(linie.Split('-')[3]);

                        int ok = 0;
                        foreach (MateriiPrime m in lstMateriiPrime)
                            if (m.Cod == a.Cod)
                                ok = 1;
                        if (ok == 0)
                            lstMateriiPrime.Add(a);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formatul fisierului selectat nu este corect.");
                }
                finally
                {
                    populare_lista_materiiPrime();
                    sr.Close();
                    fileStream.Close();
                }
            }
        }

        private void productieNeterminataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                String linie = null;
                try
                {
                    while ((linie = sr.ReadLine()) != null)
                    {
                        ProductieNeterminata a = new ProductieNeterminata();
                        a.Cod = Int32.Parse(linie.Split('-')[0]);
                        a.Denumire = linie.Split('-')[1];
                        a.Cantitate = Int32.Parse(linie.Split('-')[2]);
                        a.DataFinalizarii = linie.Split('-')[3];

                        int ok = 0;
                        foreach (ProductieNeterminata m in lstProductieNeterminata)
                            if (m.Cod == a.Cod)
                                ok = 1;
                        if (ok == 0)
                            lstProductieNeterminata.Add(a);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formatul fisierului selectat nu este corect.");
                }
                finally
                {
                    populare_lista_productieNeterminata();
                    sr.Close();
                    fileStream.Close();
                }
            }
        }

        private void marfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                String linie = null;
                try
                {
                    while ((linie = sr.ReadLine()) != null)
                    {
                        Marfa a = new Marfa();

                        a.Cod = Int32.Parse(linie.Split('-')[0]);
                        a.Denumire = linie.Split('-')[1];
                        a.Cantitate = Int32.Parse(linie.Split('-')[2]);
                        a.Pret = Int32.Parse(linie.Split('-')[3]);

                        int ok = 0;
                        foreach (Marfa m in lstMArfa)
                            if (m.Cod == a.Cod)
                                ok = 1;
                        if (ok == 0)
                            lstMArfa.Add(a);


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formatul fisierului selectat nu este corect.");
                }
                finally
                {
                    populare_lista_marfa();
                    sr.Close();
                    fileStream.Close();
                }
            }
        }

        //salvari txt
        private void materiiPrimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                foreach (MateriiPrime m in lstMateriiPrime)
                    sw.WriteLine(m.ToString());
                sw.Close();

            }
        }

        private void productieNefinalizataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                foreach (ProductieNeterminata m in lstProductieNeterminata)
                    sw.WriteLine(m.ToString());
                sw.Close();

            }
        }

        private void marfaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                foreach (Marfa m in lstMArfa)
                    sw.WriteLine(m.ToString());
                sw.Close();

            }
        }

        //serializare binar MARFA
        private void marfaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("marfa.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, lstMArfa);
            file.Close();

            MessageBox.Show("S-a creat fisierul marfa.dat");
        }

        //deserializare binar MARFA
        private void marfaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("marfa.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Marfa> laux = (List<Marfa>)bf.Deserialize(file);
            foreach (Marfa m in laux)
            {
                int ok = 0;
                foreach (Marfa marfa in lstMArfa)
                    if (marfa.Cod == m.Cod)
                        ok = 1;
                if (ok == 0)
                    lstMArfa.Add(m);
            }
            populare_lista_marfa();
        }

        //serializare XML MATERII PRIME
        private void marfaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;


            writer.WriteStartDocument();
            writer.WriteStartElement("Stoc");
            writer.WriteAttributeString("stoc", "Materii_Prime");

            foreach (MateriiPrime m in lstMateriiPrime)
            {
                writer.WriteStartElement("Obiect");

                writer.WriteStartElement("Cod");
                writer.WriteValue(m.Cod);
                writer.WriteEndElement();

                writer.WriteStartElement("Denumire");
                writer.WriteValue(m.Denumire);
                writer.WriteEndElement();

                writer.WriteStartElement("Cantitate");
                writer.WriteValue(m.Cantitate);
                writer.WriteEndElement();

                writer.WriteStartElement("Cost");
                writer.WriteValue(m.Cost);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();

            string sr = Encoding.UTF8.GetString(ms.ToArray());
            StreamWriter sw = new StreamWriter("materii_prime.xml");
            sw.WriteLine(sr);
            sw.Close();
            MessageBox.Show("S-a generat fisierul materii_prime.xml");


        }

        //deserializare XML MATERII PRIME
        private void marfaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("materii_prime.xml");
            string str = sr.ReadToEnd();
            sr.Close();
            
            XmlReader reader = XmlReader.Create(new StringReader(str));
            string cod = "", denumire = "", cost = "", cantitate = "";
           // XmlTextReader reader = new XmlTextReader("materii_prime.xml");

            while (reader.Read())
            {

                if (reader.Name == "Cod" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    cod = reader.Value;
                }

                if (reader.Name == "Denumire" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    denumire = reader.Value;

                }
                if (reader.Name == "Cantitate" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    cantitate = reader.Value;

                }

                if (reader.Name == "Cost" && reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    cost = reader.Value;

                }

               if (cod != "" && cost != "" && denumire != "" && cantitate != "")
                {
                    int ok = 0;
                    foreach (MateriiPrime m in lstMateriiPrime)
                    {
                        if (m.Cod == Int32.Parse(cod))
                        ok = 1;
                    }
                    if (ok == 0)
                    {
                        lstMateriiPrime.Add(new MateriiPrime((float)Double.Parse(cost), Int32.Parse(cod), denumire, (float)Double.Parse(cantitate)));
                    }
                    cod = ""; denumire = ""; cost = ""; cantitate = "";
                }
            }
            populare_lista_materiiPrime();

        }

        private void graficStructuraMarfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrafic frm = new FrmGrafic(lstMArfa);
            frm.ShowDialog();
        }
    }
}

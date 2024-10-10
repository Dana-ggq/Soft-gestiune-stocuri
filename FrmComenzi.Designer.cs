
namespace GestiuneStocuri
{
    partial class FrmComenzi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComenzi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxClienti = new System.Windows.Forms.ListBox();
            this.tbCodComanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValoareTotala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lwMarfa = new System.Windows.Forms.ListView();
            this.chCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMeniu = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.lwComanda = new System.Windows.Forms.ListView();
            this.Hcod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HValoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cresteCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scadeCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStripCLIENTI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStripCLIENTI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestiune Comenzi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxClienti
            // 
            this.listBoxClienti.ContextMenuStrip = this.contextMenuStripCLIENTI;
            this.listBoxClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClienti.FormattingEnabled = true;
            this.listBoxClienti.ItemHeight = 29;
            this.listBoxClienti.Location = new System.Drawing.Point(12, 140);
            this.listBoxClienti.MultiColumn = true;
            this.listBoxClienti.Name = "listBoxClienti";
            this.listBoxClienti.Size = new System.Drawing.Size(367, 178);
            this.listBoxClienti.TabIndex = 41;
            this.listBoxClienti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxClienti_MouseClick);
            this.listBoxClienti.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxClienti_DragDrop);
            this.listBoxClienti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxClienti_MouseDown);
            // 
            // tbCodComanda
            // 
            this.tbCodComanda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodComanda.Location = new System.Drawing.Point(177, 393);
            this.tbCodComanda.Name = "tbCodComanda";
            this.tbCodComanda.Size = new System.Drawing.Size(142, 22);
            this.tbCodComanda.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cod Comanda";
            // 
            // tbIdClient
            // 
            this.tbIdClient.AllowDrop = true;
            this.tbIdClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdClient.Location = new System.Drawing.Point(177, 441);
            this.tbIdClient.Name = "tbIdClient";
            this.tbIdClient.ReadOnly = true;
            this.tbIdClient.Size = new System.Drawing.Size(142, 22);
            this.tbIdClient.TabIndex = 47;
            this.tbIdClient.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxClienti_DragDrop);
            this.tbIdClient.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbIdClient_DragEnter);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Id Client";
            // 
            // tbData
            // 
            this.tbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbData.Location = new System.Drawing.Point(177, 492);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(142, 22);
            this.tbData.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Data";
            // 
            // tbValoareTotala
            // 
            this.tbValoareTotala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbValoareTotala.Location = new System.Drawing.Point(718, 628);
            this.tbValoareTotala.Name = "tbValoareTotala";
            this.tbValoareTotala.ReadOnly = true;
            this.tbValoareTotala.Size = new System.Drawing.Size(142, 22);
            this.tbValoareTotala.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Valoare Totala";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCantitate.Location = new System.Drawing.Point(705, 349);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(142, 22);
            this.tbCantitate.TabIndex = 53;
            this.tbCantitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantitate_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Cantitate";
            // 
            // lwMarfa
            // 
            this.lwMarfa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwMarfa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCod,
            this.chDenumire,
            this.chCantitate,
            this.chPret});
            this.lwMarfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwMarfa.FullRowSelect = true;
            this.lwMarfa.GridLines = true;
            this.lwMarfa.HideSelection = false;
            this.lwMarfa.Location = new System.Drawing.Point(555, 140);
            this.lwMarfa.Name = "lwMarfa";
            this.lwMarfa.Size = new System.Drawing.Size(494, 193);
            this.lwMarfa.TabIndex = 54;
            this.lwMarfa.UseCompatibleStateImageBehavior = false;
            this.lwMarfa.View = System.Windows.Forms.View.Details;
            this.lwMarfa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lwMarfa_MouseClick);
            // 
            // chCod
            // 
            this.chCod.Text = "Cod";
            // 
            // chDenumire
            // 
            this.chDenumire.Text = "Denumire";
            this.chDenumire.Width = 80;
            // 
            // chCantitate
            // 
            this.chCantitate.Text = "Cantitate Disponibila";
            this.chCantitate.Width = 150;
            // 
            // chPret
            // 
            this.chPret.Text = "Pret";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Clienti";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(550, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Produse Disponibile";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnMeniu);
            this.groupBox1.Controls.Add(this.btnAdaugare);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 529);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 121);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optiuni";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Istoric Comenzi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMeniu
            // 
            this.btnMeniu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeniu.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMeniu.Location = new System.Drawing.Point(252, 73);
            this.btnMeniu.Name = "btnMeniu";
            this.btnMeniu.Size = new System.Drawing.Size(110, 42);
            this.btnMeniu.TabIndex = 18;
            this.btnMeniu.Text = "Meniu";
            this.btnMeniu.UseVisualStyleBackColor = false;
            this.btnMeniu.Click += new System.EventHandler(this.btnMeniu_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdaugare.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdaugare.Location = new System.Drawing.Point(12, 19);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(177, 42);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adauga Comanda";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdaugaProdus.Enabled = false;
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaProdus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdaugaProdus.Location = new System.Drawing.Point(872, 345);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(177, 33);
            this.btnAdaugaProdus.TabIndex = 59;
            this.btnAdaugaProdus.Text = "Adauga produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // lwComanda
            // 
            this.lwComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwComanda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hcod,
            this.hDenumire,
            this.hPret,
            this.HCantitate,
            this.HValoare});
            this.lwComanda.ContextMenuStrip = this.contextMenuStrip1;
            this.lwComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwComanda.FullRowSelect = true;
            this.lwComanda.GridLines = true;
            this.lwComanda.HideSelection = false;
            this.lwComanda.Location = new System.Drawing.Point(545, 432);
            this.lwComanda.Name = "lwComanda";
            this.lwComanda.Size = new System.Drawing.Size(519, 193);
            this.lwComanda.TabIndex = 60;
            this.lwComanda.UseCompatibleStateImageBehavior = false;
            this.lwComanda.View = System.Windows.Forms.View.Details;
            this.lwComanda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lwComanda_MouseClick);
            // 
            // Hcod
            // 
            this.Hcod.Text = "Cod";
            // 
            // hDenumire
            // 
            this.hDenumire.Text = "Denumire";
            this.hDenumire.Width = 80;
            // 
            // hPret
            // 
            this.hPret.Text = "Pret";
            this.hPret.Width = 40;
            // 
            // HCantitate
            // 
            this.HCantitate.Text = "Cantitate Comandata";
            this.HCantitate.Width = 150;
            // 
            // HValoare
            // 
            this.HValoare.Text = "Valoare";
            this.HValoare.Width = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cresteCantitateToolStripMenuItem,
            this.scadeCantitateToolStripMenuItem,
            this.eliminaProdusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 76);
            // 
            // cresteCantitateToolStripMenuItem
            // 
            this.cresteCantitateToolStripMenuItem.Name = "cresteCantitateToolStripMenuItem";
            this.cresteCantitateToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.cresteCantitateToolStripMenuItem.Text = "Creste Cantitate";
            this.cresteCantitateToolStripMenuItem.Click += new System.EventHandler(this.cresteCantitateToolStripMenuItem_Click);
            // 
            // scadeCantitateToolStripMenuItem
            // 
            this.scadeCantitateToolStripMenuItem.Name = "scadeCantitateToolStripMenuItem";
            this.scadeCantitateToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.scadeCantitateToolStripMenuItem.Text = "Scade Cantitate";
            this.scadeCantitateToolStripMenuItem.Click += new System.EventHandler(this.scadeCantitateToolStripMenuItem_Click);
            // 
            // eliminaProdusToolStripMenuItem
            // 
            this.eliminaProdusToolStripMenuItem.Name = "eliminaProdusToolStripMenuItem";
            this.eliminaProdusToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.eliminaProdusToolStripMenuItem.Text = "Elimina Produs";
            this.eliminaProdusToolStripMenuItem.Click += new System.EventHandler(this.eliminaProdusToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(550, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "Produse Comandate";
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // contextMenuStripCLIENTI
            // 
            this.contextMenuStripCLIENTI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripCLIENTI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiazaToolStripMenuItem});
            this.contextMenuStripCLIENTI.Name = "contextMenuStripCLIENTI";
            this.contextMenuStripCLIENTI.Size = new System.Drawing.Size(133, 28);
            // 
            // copiazaToolStripMenuItem
            // 
            this.copiazaToolStripMenuItem.Name = "copiazaToolStripMenuItem";
            this.copiazaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.copiazaToolStripMenuItem.Text = "Copiaza";
            this.copiazaToolStripMenuItem.Click += new System.EventHandler(this.copiazaToolStripMenuItem_Click);
            // 
            // FrmComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 662);
            this.Controls.Add(this.lwMarfa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lwComanda);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbValoareTotala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIdClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCodComanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxClienti);
            this.Controls.Add(this.panel1);
            this.Name = "FrmComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmComenzi_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmComenzi_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStripCLIENTI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxClienti;
        private System.Windows.Forms.TextBox tbCodComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValoareTotala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lwMarfa;
        private System.Windows.Forms.ColumnHeader chCod;
        private System.Windows.Forms.ColumnHeader chDenumire;
        private System.Windows.Forms.ColumnHeader chCantitate;
        private System.Windows.Forms.ColumnHeader chPret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMeniu;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.ListView lwComanda;
        private System.Windows.Forms.ColumnHeader Hcod;
        private System.Windows.Forms.ColumnHeader hDenumire;
        private System.Windows.Forms.ColumnHeader hPret;
        private System.Windows.Forms.ColumnHeader HValoare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader HCantitate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cresteCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scadeCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaProdusToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCLIENTI;
        private System.Windows.Forms.ToolStripMenuItem copiazaToolStripMenuItem;
    }
}
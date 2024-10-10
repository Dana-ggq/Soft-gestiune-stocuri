
namespace GestiuneStocuri
{
    partial class FrmStoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantiate = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMarfa = new System.Windows.Forms.RadioButton();
            this.rbProductieNeterminata = new System.Windows.Forms.RadioButton();
            this.rbMateriiPrime = new System.Windows.Forms.RadioButton();
            this.tbMarfa = new System.Windows.Forms.TextBox();
            this.labelMarfa = new System.Windows.Forms.Label();
            this.tbProductieNeterminata = new System.Windows.Forms.TextBox();
            this.labelProductieNeterminata = new System.Windows.Forms.Label();
            this.tbMateriiPrime = new System.Windows.Forms.TextBox();
            this.labelMateriiPrime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTipStoc = new System.Windows.Forms.ComboBox();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.cHDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHOptional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnMeniu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTipStoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCantitate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errO = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniSerializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marfaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marfaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniDeserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marfaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marfaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiiPrimeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productieNefinalizataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marfaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importaFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiiPrimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productieNeterminataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficStructuraMarfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cresteCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scadeCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDenumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTipStoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errO)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestiune Stocuri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantitate";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Denumire";
            // 
            // tbCantiate
            // 
            this.tbCantiate.AllowDrop = true;
            this.tbCantiate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCantiate.Location = new System.Drawing.Point(129, 96);
            this.tbCantiate.Name = "tbCantiate";
            this.tbCantiate.Size = new System.Drawing.Size(143, 22);
            this.tbCantiate.TabIndex = 19;
            this.tbCantiate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantiate_KeyPress);
            // 
            // tbDenumire
            // 
            this.tbDenumire.AllowDrop = true;
            this.tbDenumire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDenumire.Location = new System.Drawing.Point(130, 52);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(143, 22);
            this.tbDenumire.TabIndex = 18;
            // 
            // tbCod
            // 
            this.tbCod.AllowDrop = true;
            this.tbCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCod.Location = new System.Drawing.Point(129, 11);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(142, 22);
            this.tbCod.TabIndex = 17;
            this.tbCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCod_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cod";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tip Stoc";
            // 
            // rbMarfa
            // 
            this.rbMarfa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMarfa.AutoSize = true;
            this.rbMarfa.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarfa.Location = new System.Drawing.Point(157, 280);
            this.rbMarfa.Name = "rbMarfa";
            this.rbMarfa.Size = new System.Drawing.Size(67, 22);
            this.rbMarfa.TabIndex = 24;
            this.rbMarfa.TabStop = true;
            this.rbMarfa.Text = "Marfa";
            this.rbMarfa.UseVisualStyleBackColor = true;
            this.rbMarfa.CheckedChanged += new System.EventHandler(this.rbMarfa_CheckedChanged);
            // 
            // rbProductieNeterminata
            // 
            this.rbProductieNeterminata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbProductieNeterminata.AutoSize = true;
            this.rbProductieNeterminata.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProductieNeterminata.Location = new System.Drawing.Point(158, 308);
            this.rbProductieNeterminata.Name = "rbProductieNeterminata";
            this.rbProductieNeterminata.Size = new System.Drawing.Size(177, 22);
            this.rbProductieNeterminata.TabIndex = 25;
            this.rbProductieNeterminata.TabStop = true;
            this.rbProductieNeterminata.Text = "Productie Neterminata";
            this.rbProductieNeterminata.UseVisualStyleBackColor = true;
            this.rbProductieNeterminata.CheckedChanged += new System.EventHandler(this.rbProductieNeterminata_CheckedChanged);
            // 
            // rbMateriiPrime
            // 
            this.rbMateriiPrime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMateriiPrime.AutoSize = true;
            this.rbMateriiPrime.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMateriiPrime.Location = new System.Drawing.Point(158, 336);
            this.rbMateriiPrime.Name = "rbMateriiPrime";
            this.rbMateriiPrime.Size = new System.Drawing.Size(116, 22);
            this.rbMateriiPrime.TabIndex = 26;
            this.rbMateriiPrime.TabStop = true;
            this.rbMateriiPrime.Text = "Materii Prime";
            this.rbMateriiPrime.UseVisualStyleBackColor = true;
            this.rbMateriiPrime.CheckedChanged += new System.EventHandler(this.rbMateriiPrime_CheckedChanged);
            // 
            // tbMarfa
            // 
            this.tbMarfa.AllowDrop = true;
            this.tbMarfa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMarfa.Location = new System.Drawing.Point(173, 275);
            this.tbMarfa.Name = "tbMarfa";
            this.tbMarfa.Size = new System.Drawing.Size(142, 22);
            this.tbMarfa.TabIndex = 28;
            this.tbMarfa.Visible = false;
            this.tbMarfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMarfa_KeyPress);
            // 
            // labelMarfa
            // 
            this.labelMarfa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMarfa.AutoSize = true;
            this.labelMarfa.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarfa.Location = new System.Drawing.Point(95, 275);
            this.labelMarfa.Name = "labelMarfa";
            this.labelMarfa.Size = new System.Drawing.Size(51, 25);
            this.labelMarfa.TabIndex = 27;
            this.labelMarfa.Text = "Pret";
            this.labelMarfa.Visible = false;
            // 
            // tbProductieNeterminata
            // 
            this.tbProductieNeterminata.AllowDrop = true;
            this.tbProductieNeterminata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductieNeterminata.Location = new System.Drawing.Point(173, 275);
            this.tbProductieNeterminata.Name = "tbProductieNeterminata";
            this.tbProductieNeterminata.Size = new System.Drawing.Size(142, 22);
            this.tbProductieNeterminata.TabIndex = 30;
            this.tbProductieNeterminata.Visible = false;
            // 
            // labelProductieNeterminata
            // 
            this.labelProductieNeterminata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductieNeterminata.AutoSize = true;
            this.labelProductieNeterminata.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductieNeterminata.Location = new System.Drawing.Point(-5, 275);
            this.labelProductieNeterminata.Name = "labelProductieNeterminata";
            this.labelProductieNeterminata.Size = new System.Drawing.Size(153, 25);
            this.labelProductieNeterminata.TabIndex = 29;
            this.labelProductieNeterminata.Text = "Data Finalizarii";
            this.labelProductieNeterminata.Visible = false;
            // 
            // tbMateriiPrime
            // 
            this.tbMateriiPrime.AllowDrop = true;
            this.tbMateriiPrime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMateriiPrime.Location = new System.Drawing.Point(173, 275);
            this.tbMateriiPrime.Name = "tbMateriiPrime";
            this.tbMateriiPrime.Size = new System.Drawing.Size(142, 22);
            this.tbMateriiPrime.TabIndex = 32;
            this.tbMateriiPrime.Visible = false;
            this.tbMateriiPrime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMateriiPrime_KeyPress);
            // 
            // labelMateriiPrime
            // 
            this.labelMateriiPrime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMateriiPrime.AutoSize = true;
            this.labelMateriiPrime.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMateriiPrime.Location = new System.Drawing.Point(95, 275);
            this.labelMateriiPrime.Name = "labelMateriiPrime";
            this.labelMateriiPrime.Size = new System.Drawing.Size(53, 25);
            this.labelMateriiPrime.TabIndex = 31;
            this.labelMateriiPrime.Text = "Cost";
            this.labelMateriiPrime.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tbProductieNeterminata);
            this.panel2.Controls.Add(this.tbMateriiPrime);
            this.panel2.Controls.Add(this.tbMarfa);
            this.panel2.Controls.Add(this.labelMateriiPrime);
            this.panel2.Controls.Add(this.labelProductieNeterminata);
            this.panel2.Controls.Add(this.labelMarfa);
            this.panel2.Controls.Add(this.tbCod);
            this.panel2.Controls.Add(this.tbDenumire);
            this.panel2.Controls.Add(this.tbCantiate);
            this.panel2.Location = new System.Drawing.Point(9, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 310);
            this.panel2.TabIndex = 34;
            // 
            // cbTipStoc
            // 
            this.cbTipStoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipStoc.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipStoc.FormattingEnabled = true;
            this.cbTipStoc.Items.AddRange(new object[] {
            "Marfa",
            "Productie Neterminata",
            "Materii Prime"});
            this.cbTipStoc.Location = new System.Drawing.Point(599, 137);
            this.cbTipStoc.Name = "cbTipStoc";
            this.cbTipStoc.Size = new System.Drawing.Size(313, 33);
            this.cbTipStoc.TabIndex = 35;
            this.cbTipStoc.SelectedIndexChanged += new System.EventHandler(this.cbTipStoc_SelectedIndexChanged);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnuleaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnuleaza.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnuleaza.Location = new System.Drawing.Point(929, 132);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(109, 42);
            this.btnAnuleaza.TabIndex = 36;
            this.btnAnuleaza.Text = "Afiseaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // cHDenumire
            // 
            this.cHDenumire.Text = "Denumire";
            this.cHDenumire.Width = 140;
            // 
            // cHCod
            // 
            this.cHCod.Text = "Cod";
            this.cHCod.Width = 105;
            // 
            // cHCantitate
            // 
            this.cHCantitate.Text = "Cantitate";
            this.cHCantitate.Width = 105;
            // 
            // cHOptional
            // 
            this.cHOptional.Text = "";
            this.cHOptional.Width = 115;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHCod,
            this.cHDenumire,
            this.cHCantitate,
            this.cHOptional});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(459, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 344);
            this.listView1.TabIndex = 33;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAdaugare);
            this.groupBox1.Controls.Add(this.btnMeniu);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 146);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optiuni";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdaugare.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdaugare.Location = new System.Drawing.Point(0, 30);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(115, 42);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnMeniu
            // 
            this.btnMeniu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeniu.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMeniu.Location = new System.Drawing.Point(130, 30);
            this.btnMeniu.Name = "btnMeniu";
            this.btnMeniu.Size = new System.Drawing.Size(115, 42);
            this.btnMeniu.TabIndex = 18;
            this.btnMeniu.Text = "Meniu";
            this.btnMeniu.UseVisualStyleBackColor = false;
            this.btnMeniu.Click += new System.EventHandler(this.btnMeniu_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(34, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "&Golire Formular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errCod
            // 
            this.errCod.ContainerControl = this;
            // 
            // errDenumire
            // 
            this.errDenumire.ContainerControl = this;
            // 
            // errTipStoc
            // 
            this.errTipStoc.ContainerControl = this;
            // 
            // errCantitate
            // 
            this.errCantitate.ContainerControl = this;
            // 
            // errO
            // 
            this.errO.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniSerializareToolStripMenuItem,
            this.optiuniDeserializareToolStripMenuItem,
            this.exportaFisierTextToolStripMenuItem,
            this.importaFisierTextToolStripMenuItem,
            this.graficStructuraMarfaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 30);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniSerializareToolStripMenuItem
            // 
            this.optiuniSerializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinarToolStripMenuItem,
            this.serializareXMLToolStripMenuItem});
            this.optiuniSerializareToolStripMenuItem.Name = "optiuniSerializareToolStripMenuItem";
            this.optiuniSerializareToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.optiuniSerializareToolStripMenuItem.Text = "Optiuni serializare";
            // 
            // serializareBinarToolStripMenuItem
            // 
            this.serializareBinarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marfaToolStripMenuItem2});
            this.serializareBinarToolStripMenuItem.Name = "serializareBinarToolStripMenuItem";
            this.serializareBinarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareBinarToolStripMenuItem.Text = "serializare binar";
            // 
            // marfaToolStripMenuItem2
            // 
            this.marfaToolStripMenuItem2.Name = "marfaToolStripMenuItem2";
            this.marfaToolStripMenuItem2.Size = new System.Drawing.Size(131, 26);
            this.marfaToolStripMenuItem2.Text = "marfa";
            this.marfaToolStripMenuItem2.Click += new System.EventHandler(this.marfaToolStripMenuItem2_Click);
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marfaToolStripMenuItem3});
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareXMLToolStripMenuItem.Text = "serializare XML";
            // 
            // marfaToolStripMenuItem3
            // 
            this.marfaToolStripMenuItem3.Name = "marfaToolStripMenuItem3";
            this.marfaToolStripMenuItem3.Size = new System.Drawing.Size(182, 26);
            this.marfaToolStripMenuItem3.Text = "materii prime";
            this.marfaToolStripMenuItem3.Click += new System.EventHandler(this.marfaToolStripMenuItem3_Click);
            // 
            // optiuniDeserializareToolStripMenuItem
            // 
            this.optiuniDeserializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deserializareBinarToolStripMenuItem,
            this.deserializareXmlToolStripMenuItem});
            this.optiuniDeserializareToolStripMenuItem.Name = "optiuniDeserializareToolStripMenuItem";
            this.optiuniDeserializareToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.optiuniDeserializareToolStripMenuItem.Text = "Optiuni deserializare";
            // 
            // deserializareBinarToolStripMenuItem
            // 
            this.deserializareBinarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marfaToolStripMenuItem4});
            this.deserializareBinarToolStripMenuItem.Name = "deserializareBinarToolStripMenuItem";
            this.deserializareBinarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareBinarToolStripMenuItem.Text = "deserializare binar";
            // 
            // marfaToolStripMenuItem4
            // 
            this.marfaToolStripMenuItem4.Name = "marfaToolStripMenuItem4";
            this.marfaToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.marfaToolStripMenuItem4.Text = "marfa";
            this.marfaToolStripMenuItem4.Click += new System.EventHandler(this.marfaToolStripMenuItem4_Click);
            // 
            // deserializareXmlToolStripMenuItem
            // 
            this.deserializareXmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marfaToolStripMenuItem5});
            this.deserializareXmlToolStripMenuItem.Name = "deserializareXmlToolStripMenuItem";
            this.deserializareXmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareXmlToolStripMenuItem.Text = "deserializare xml";
            // 
            // marfaToolStripMenuItem5
            // 
            this.marfaToolStripMenuItem5.Name = "marfaToolStripMenuItem5";
            this.marfaToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.marfaToolStripMenuItem5.Text = "materii prime";
            this.marfaToolStripMenuItem5.Click += new System.EventHandler(this.marfaToolStripMenuItem5_Click);
            // 
            // exportaFisierTextToolStripMenuItem
            // 
            this.exportaFisierTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiiPrimeToolStripMenuItem1,
            this.productieNefinalizataToolStripMenuItem,
            this.marfaToolStripMenuItem1});
            this.exportaFisierTextToolStripMenuItem.Name = "exportaFisierTextToolStripMenuItem";
            this.exportaFisierTextToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exportaFisierTextToolStripMenuItem.Text = "Exporta fisier text";
            // 
            // materiiPrimeToolStripMenuItem1
            // 
            this.materiiPrimeToolStripMenuItem1.Name = "materiiPrimeToolStripMenuItem1";
            this.materiiPrimeToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.materiiPrimeToolStripMenuItem1.Text = "Materii Prime";
            this.materiiPrimeToolStripMenuItem1.Click += new System.EventHandler(this.materiiPrimeToolStripMenuItem1_Click);
            // 
            // productieNefinalizataToolStripMenuItem
            // 
            this.productieNefinalizataToolStripMenuItem.Name = "productieNefinalizataToolStripMenuItem";
            this.productieNefinalizataToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.productieNefinalizataToolStripMenuItem.Text = "Productie Nefinalizata";
            this.productieNefinalizataToolStripMenuItem.Click += new System.EventHandler(this.productieNefinalizataToolStripMenuItem_Click);
            // 
            // marfaToolStripMenuItem1
            // 
            this.marfaToolStripMenuItem1.Name = "marfaToolStripMenuItem1";
            this.marfaToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.marfaToolStripMenuItem1.Text = "Marfa";
            this.marfaToolStripMenuItem1.Click += new System.EventHandler(this.marfaToolStripMenuItem1_Click);
            // 
            // importaFisierTextToolStripMenuItem
            // 
            this.importaFisierTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiiPrimeToolStripMenuItem,
            this.productieNeterminataToolStripMenuItem,
            this.marfaToolStripMenuItem});
            this.importaFisierTextToolStripMenuItem.Name = "importaFisierTextToolStripMenuItem";
            this.importaFisierTextToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.importaFisierTextToolStripMenuItem.Text = "Importa fisier text";
            // 
            // materiiPrimeToolStripMenuItem
            // 
            this.materiiPrimeToolStripMenuItem.Name = "materiiPrimeToolStripMenuItem";
            this.materiiPrimeToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.materiiPrimeToolStripMenuItem.Text = "Materii Prime";
            this.materiiPrimeToolStripMenuItem.Click += new System.EventHandler(this.materiiPrimeToolStripMenuItem_Click);
            // 
            // productieNeterminataToolStripMenuItem
            // 
            this.productieNeterminataToolStripMenuItem.Name = "productieNeterminataToolStripMenuItem";
            this.productieNeterminataToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.productieNeterminataToolStripMenuItem.Text = "Productie Neterminata";
            this.productieNeterminataToolStripMenuItem.Click += new System.EventHandler(this.productieNeterminataToolStripMenuItem_Click);
            // 
            // marfaToolStripMenuItem
            // 
            this.marfaToolStripMenuItem.Name = "marfaToolStripMenuItem";
            this.marfaToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.marfaToolStripMenuItem.Text = "Marfa";
            this.marfaToolStripMenuItem.Click += new System.EventHandler(this.marfaToolStripMenuItem_Click);
            // 
            // graficStructuraMarfaToolStripMenuItem
            // 
            this.graficStructuraMarfaToolStripMenuItem.Name = "graficStructuraMarfaToolStripMenuItem";
            this.graficStructuraMarfaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.graficStructuraMarfaToolStripMenuItem.Text = "Grafic Structura Marfa";
            this.graficStructuraMarfaToolStripMenuItem.Click += new System.EventHandler(this.graficStructuraMarfaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 39;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem,
            this.actualizareCantitateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 52);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // actualizareCantitateToolStripMenuItem
            // 
            this.actualizareCantitateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cresteCantitateToolStripMenuItem,
            this.scadeCantitateToolStripMenuItem});
            this.actualizareCantitateToolStripMenuItem.Name = "actualizareCantitateToolStripMenuItem";
            this.actualizareCantitateToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.actualizareCantitateToolStripMenuItem.Text = "Actualizare Cantitate";
            // 
            // cresteCantitateToolStripMenuItem
            // 
            this.cresteCantitateToolStripMenuItem.Name = "cresteCantitateToolStripMenuItem";
            this.cresteCantitateToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.cresteCantitateToolStripMenuItem.Text = "Creste Cantitate";
            this.cresteCantitateToolStripMenuItem.Click += new System.EventHandler(this.cresteCantitateToolStripMenuItem_Click);
            // 
            // scadeCantitateToolStripMenuItem
            // 
            this.scadeCantitateToolStripMenuItem.Name = "scadeCantitateToolStripMenuItem";
            this.scadeCantitateToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.scadeCantitateToolStripMenuItem.Text = "Scade Cantitate";
            this.scadeCantitateToolStripMenuItem.Click += new System.EventHandler(this.scadeCantitateToolStripMenuItem_Click);
            // 
            // FrmStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1076, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.cbTipStoc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbMateriiPrime);
            this.Controls.Add(this.rbProductieNeterminata);
            this.Controls.Add(this.rbMarfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "FrmStoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStoc_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDenumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTipStoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errO)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCantiate;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMarfa;
        private System.Windows.Forms.RadioButton rbProductieNeterminata;
        private System.Windows.Forms.RadioButton rbMateriiPrime;
        private System.Windows.Forms.TextBox tbMarfa;
        private System.Windows.Forms.Label labelMarfa;
        private System.Windows.Forms.TextBox tbProductieNeterminata;
        private System.Windows.Forms.Label labelProductieNeterminata;
        private System.Windows.Forms.TextBox tbMateriiPrime;
        private System.Windows.Forms.Label labelMateriiPrime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTipStoc;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ColumnHeader cHDenumire;
        private System.Windows.Forms.ColumnHeader cHCod;
        private System.Windows.Forms.ColumnHeader cHCantitate;
        private System.Windows.Forms.ColumnHeader cHOptional;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnMeniu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errCod;
        private System.Windows.Forms.ErrorProvider errDenumire;
        private System.Windows.Forms.ErrorProvider errTipStoc;
        private System.Windows.Forms.ErrorProvider errCantitate;
        private System.Windows.Forms.ErrorProvider errO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniSerializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiuniDeserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaFisierTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cresteCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scadeCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marfaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem marfaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem marfaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem marfaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem materiiPrimeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productieNefinalizataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marfaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importaFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiiPrimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productieNeterminataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficStructuraMarfaToolStripMenuItem;
    }
}
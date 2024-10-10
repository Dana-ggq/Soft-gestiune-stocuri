
namespace GestiuneStocuri
{
    partial class FrmClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienti));
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.treeViewClienti = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnMeniu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonXML = new System.Windows.Forms.ToolStripDropDownButton();
            this.importaTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Client";
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.Location = new System.Drawing.Point(194, 225);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(142, 22);
            this.tbId.TabIndex = 6;
            this.tbId.Validating += new System.ComponentModel.CancelEventHandler(this.tbId_Validating);
            this.tbId.Validated += new System.EventHandler(this.tbId_Validated);
            // 
            // tbNume
            // 
            this.tbNume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNume.Location = new System.Drawing.Point(194, 265);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(143, 22);
            this.tbNume.TabIndex = 7;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Location = new System.Drawing.Point(193, 309);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(143, 22);
            this.tbEmail.TabIndex = 8;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdaugare.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdaugare.Location = new System.Drawing.Point(12, 30);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(97, 42);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // treeViewClienti
            // 
            this.treeViewClienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeViewClienti.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeViewClienti.ContextMenuStrip = this.contextMenuStrip1;
            this.treeViewClienti.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewClienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewClienti.FullRowSelect = true;
            this.treeViewClienti.Location = new System.Drawing.Point(461, 225);
            this.treeViewClienti.Name = "treeViewClienti";
            this.treeViewClienti.Size = new System.Drawing.Size(565, 357);
            this.treeViewClienti.TabIndex = 13;
            this.treeViewClienti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewClienti_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizareToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 52);
            // 
            // actualizareToolStripMenuItem
            // 
            this.actualizareToolStripMenuItem.Name = "actualizareToolStripMenuItem";
            this.actualizareToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.actualizareToolStripMenuItem.Text = "Actualizare";
            this.actualizareToolStripMenuItem.Click += new System.EventHandler(this.actualizareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nume Client";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email Client";
            // 
            // btnActualizare
            // 
            this.btnActualizare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizare.Enabled = false;
            this.btnActualizare.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizare.Location = new System.Drawing.Point(133, 30);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(129, 42);
            this.btnActualizare.TabIndex = 16;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSterge.Enabled = false;
            this.btnSterge.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSterge.Location = new System.Drawing.Point(283, 30);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(115, 42);
            this.btnSterge.TabIndex = 17;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnMeniu
            // 
            this.btnMeniu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeniu.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMeniu.Location = new System.Drawing.Point(142, 98);
            this.btnMeniu.Name = "btnMeniu";
            this.btnMeniu.Size = new System.Drawing.Size(115, 42);
            this.btnMeniu.TabIndex = 18;
            this.btnMeniu.Text = "Meniu";
            this.btnMeniu.UseVisualStyleBackColor = false;
            this.btnMeniu.Click += new System.EventHandler(this.btnMeniu_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(662, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lista Clienti";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonXML});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 31);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonXML
            // 
            this.toolStripDropDownButtonXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaTXTToolStripMenuItem,
            this.exportaXMLToolStripMenuItem});
            this.toolStripDropDownButtonXML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonXML.Image")));
            this.toolStripDropDownButtonXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonXML.Name = "toolStripDropDownButtonXML";
            this.toolStripDropDownButtonXML.Size = new System.Drawing.Size(137, 28);
            this.toolStripDropDownButtonXML.Text = "Import/Export";
            // 
            // importaTXTToolStripMenuItem
            // 
            this.importaTXTToolStripMenuItem.Name = "importaTXTToolStripMenuItem";
            this.importaTXTToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.importaTXTToolStripMenuItem.Text = "importa TXT";
            this.importaTXTToolStripMenuItem.Click += new System.EventHandler(this.importaTXTToolStripMenuItem_Click);
            // 
            // exportaXMLToolStripMenuItem
            // 
            this.exportaXMLToolStripMenuItem.Name = "exportaXMLToolStripMenuItem";
            this.exportaXMLToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.exportaXMLToolStripMenuItem.Text = "exporta XML";
            this.exportaXMLToolStripMenuItem.Click += new System.EventHandler(this.exportaXMLToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestiune Clienti";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errNume
            // 
            this.errNume.ContainerControl = this;
            // 
            // errId
            // 
            this.errId.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAdaugare);
            this.groupBox1.Controls.Add(this.btnActualizare);
            this.groupBox1.Controls.Add(this.btnSterge);
            this.groupBox1.Controls.Add(this.btnMeniu);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 146);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optiuni";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnuleaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnuleaza.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnuleaza.Location = new System.Drawing.Point(51, 551);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(109, 42);
            this.btnAnuleaza.TabIndex = 24;
            this.btnAnuleaza.Text = "&Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // FrmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 662);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeViewClienti);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClienti";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmClienti_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TreeView treeViewClienti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnMeniu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonXML;
        private System.Windows.Forms.ToolStripMenuItem importaTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaXMLToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errNume;
        private System.Windows.Forms.ErrorProvider errId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem actualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}
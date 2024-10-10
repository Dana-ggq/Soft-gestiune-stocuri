
namespace GestiuneStocuri
{
    partial class FrmMeniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeniu));
            this.btnStoc = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.delogareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStoc
            // 
            this.btnStoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStoc.AutoSize = true;
            this.btnStoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStoc.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStoc.Location = new System.Drawing.Point(344, 120);
            this.btnStoc.Name = "btnStoc";
            this.btnStoc.Size = new System.Drawing.Size(184, 95);
            this.btnStoc.TabIndex = 0;
            this.btnStoc.Text = "Stoc";
            this.btnStoc.UseVisualStyleBackColor = false;
            this.btnStoc.Click += new System.EventHandler(this.btnStoc_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClienti.AutoSize = true;
            this.btnClienti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClienti.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClienti.Location = new System.Drawing.Point(187, 265);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(184, 95);
            this.btnClienti.TabIndex = 1;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = false;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComenzi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnComenzi.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnComenzi.Location = new System.Drawing.Point(510, 265);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(184, 95);
            this.btnComenzi.TabIndex = 2;
            this.btnComenzi.Text = "Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = false;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delogareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // delogareToolStripMenuItem
            // 
            this.delogareToolStripMenuItem.Name = "delogareToolStripMenuItem";
            this.delogareToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.delogareToolStripMenuItem.Text = "Delogare";
            this.delogareToolStripMenuItem.Click += new System.EventHandler(this.delogareToolStripMenuItem_Click);
            // 
            // FrmMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnStoc);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMeniu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStoc;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delogareToolStripMenuItem;
    }
}
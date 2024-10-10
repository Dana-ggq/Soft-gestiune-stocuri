
namespace GestiuneStocuri
{
    partial class FrmGrafic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafic));
            this.grafic1 = new GraficLibrary.Grafic();
            this.SuspendLayout();
            // 
            // grafic1
            // 
            this.grafic1.Elemente = ((System.Collections.Generic.List<GraficLibrary.Chart>)(resources.GetObject("grafic1.Elemente")));
            this.grafic1.Location = new System.Drawing.Point(56, 12);
            this.grafic1.Name = "grafic1";
            this.grafic1.Size = new System.Drawing.Size(929, 514);
            this.grafic1.TabIndex = 0;
            // 
            // FrmGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 563);
            this.Controls.Add(this.grafic1);
            this.Name = "FrmGrafic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmGrafic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GraficLibrary.Grafic grafic1;
    }
}
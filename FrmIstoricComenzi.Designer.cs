
namespace GestiuneStocuri
{
    partial class FrmIstoricComenzi
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
            this.lbComenzi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbComenzi
            // 
            this.lbComenzi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbComenzi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbComenzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComenzi.FormattingEnabled = true;
            this.lbComenzi.ItemHeight = 22;
            this.lbComenzi.Location = new System.Drawing.Point(0, 0);
            this.lbComenzi.Name = "lbComenzi";
            this.lbComenzi.Size = new System.Drawing.Size(800, 450);
            this.lbComenzi.TabIndex = 0;
            // 
            // FrmIstoricComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbComenzi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmIstoricComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IstoricComenzi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbComenzi;
    }
}
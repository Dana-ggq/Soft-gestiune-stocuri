
namespace GestiuneStocuri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbParola = new System.Windows.Forms.MaskedTextBox();
            this.cbAfisareParola = new System.Windows.Forms.CheckBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.tbUtilizator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.mtbParola);
            this.panel1.Controls.Add(this.cbAfisareParola);
            this.panel1.Controls.Add(this.btnAutentificare);
            this.panel1.Controls.Add(this.tbUtilizator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 252);
            this.panel1.TabIndex = 0;
            // 
            // mtbParola
            // 
            this.mtbParola.Location = new System.Drawing.Point(146, 120);
            this.mtbParola.Name = "mtbParola";
            this.mtbParola.Size = new System.Drawing.Size(175, 22);
            this.mtbParola.TabIndex = 1;
            this.mtbParola.UseSystemPasswordChar = true;
            // 
            // cbAfisareParola
            // 
            this.cbAfisareParola.AutoSize = true;
            this.cbAfisareParola.Font = new System.Drawing.Font("Adobe Fangsong Std R", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAfisareParola.Location = new System.Drawing.Point(268, 183);
            this.cbAfisareParola.Name = "cbAfisareParola";
            this.cbAfisareParola.Size = new System.Drawing.Size(120, 22);
            this.cbAfisareParola.TabIndex = 6;
            this.cbAfisareParola.Text = "Afisare Parola";
            this.cbAfisareParola.UseVisualStyleBackColor = true;
            this.cbAfisareParola.CheckedChanged += new System.EventHandler(this.cbAfisareParola_CheckedChanged);
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAutentificare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAutentificare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAutentificare.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutentificare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutentificare.Location = new System.Drawing.Point(47, 177);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(106, 35);
            this.btnAutentificare.TabIndex = 5;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = false;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // tbUtilizator
            // 
            this.tbUtilizator.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.tbUtilizator.Location = new System.Drawing.Point(146, 62);
            this.tbUtilizator.Name = "tbUtilizator";
            this.tbUtilizator.Size = new System.Drawing.Size(175, 22);
            this.tbUtilizator.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilizator";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autentificare";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(545, 434);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem pentru Gestiunea Stocuri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.TextBox tbUtilizator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAfisareParola;
        private System.Windows.Forms.MaskedTextBox mtbParola;
    }
}


namespace Stevec_klikov
{
    partial class Okno
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
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Napis = new System.Windows.Forms.Label();
            this.Koliko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Napis
            // 
            this.Napis.AutoSize = true;
            this.Napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Napis.Location = new System.Drawing.Point(26, 118);
            this.Napis.Name = "Napis";
            this.Napis.Size = new System.Drawing.Size(351, 48);
            this.Napis.TabIndex = 0;
            this.Napis.Text = "ŠTEVEC KLIKOV";
            this.Napis.Click += new System.EventHandler(this.Napis_Click);
            // 
            // Koliko
            // 
            this.Koliko.AutoSize = true;
            this.Koliko.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Koliko.Location = new System.Drawing.Point(431, 118);
            this.Koliko.Name = "Koliko";
            this.Koliko.Size = new System.Drawing.Size(0, 48);
            this.Koliko.TabIndex = 1;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 332);
            this.Controls.Add(this.Koliko);
            this.Controls.Add(this.Napis);
            this.Name = "Okno";
            this.Text = "Števec klikov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Napis;
        private System.Windows.Forms.Label Koliko;
    }
}


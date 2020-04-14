namespace Semafor
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
            this.PrviGumb = new System.Windows.Forms.Button();
            this.DrugiGumb = new System.Windows.Forms.Button();
            this.TretjiGumb = new System.Windows.Forms.Button();
            this.Napis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrviGumb
            // 
            this.PrviGumb.Location = new System.Drawing.Point(34, 60);
            this.PrviGumb.Name = "PrviGumb";
            this.PrviGumb.Size = new System.Drawing.Size(113, 40);
            this.PrviGumb.TabIndex = 0;
            this.PrviGumb.Text = "Rdeča";
            this.PrviGumb.UseVisualStyleBackColor = true;
            this.PrviGumb.Click += new System.EventHandler(this.PrviGumb_Click);
            // 
            // DrugiGumb
            // 
            this.DrugiGumb.Location = new System.Drawing.Point(34, 126);
            this.DrugiGumb.Name = "DrugiGumb";
            this.DrugiGumb.Size = new System.Drawing.Size(113, 38);
            this.DrugiGumb.TabIndex = 1;
            this.DrugiGumb.Text = "Rumena";
            this.DrugiGumb.UseVisualStyleBackColor = true;
            this.DrugiGumb.Click += new System.EventHandler(this.DrugiGumb_Click);
            // 
            // TretjiGumb
            // 
            this.TretjiGumb.Location = new System.Drawing.Point(34, 190);
            this.TretjiGumb.Name = "TretjiGumb";
            this.TretjiGumb.Size = new System.Drawing.Size(113, 40);
            this.TretjiGumb.TabIndex = 2;
            this.TretjiGumb.Text = "Zelena";
            this.TretjiGumb.UseVisualStyleBackColor = true;
            this.TretjiGumb.Click += new System.EventHandler(this.TretjiGumb_Click);
            // 
            // Napis
            // 
            this.Napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Napis.Location = new System.Drawing.Point(227, 60);
            this.Napis.Name = "Napis";
            this.Napis.Size = new System.Drawing.Size(178, 177);
            this.Napis.TabIndex = 3;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 382);
            this.Controls.Add(this.Napis);
            this.Controls.Add(this.TretjiGumb);
            this.Controls.Add(this.DrugiGumb);
            this.Controls.Add(this.PrviGumb);
            this.Name = "Okno";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrviGumb;
        private System.Windows.Forms.Button DrugiGumb;
        private System.Windows.Forms.Button TretjiGumb;
        private System.Windows.Forms.TextBox Napis;
    }
}


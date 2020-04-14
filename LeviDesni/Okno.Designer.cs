namespace LeviDesni
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
            this.LeviGumb = new System.Windows.Forms.Button();
            this.Napis = new System.Windows.Forms.Label();
            this.DesniGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeviGumb
            // 
            this.LeviGumb.Location = new System.Drawing.Point(67, 119);
            this.LeviGumb.Name = "LeviGumb";
            this.LeviGumb.Size = new System.Drawing.Size(115, 40);
            this.LeviGumb.TabIndex = 0;
            this.LeviGumb.Text = "Levi";
            this.LeviGumb.UseVisualStyleBackColor = true;
            this.LeviGumb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeviGumb_MouseDown);
            this.LeviGumb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeviGumb_MouseUp);
            // 
            // Napis
            // 
            this.Napis.AutoSize = true;
            this.Napis.Location = new System.Drawing.Point(226, 131);
            this.Napis.Name = "Napis";
            this.Napis.Size = new System.Drawing.Size(0, 17);
            this.Napis.TabIndex = 1;
            // 
            // DesniGumb
            // 
            this.DesniGumb.Location = new System.Drawing.Point(357, 119);
            this.DesniGumb.Name = "DesniGumb";
            this.DesniGumb.Size = new System.Drawing.Size(119, 40);
            this.DesniGumb.TabIndex = 2;
            this.DesniGumb.Text = "Desni";
            this.DesniGumb.UseVisualStyleBackColor = true;
            this.DesniGumb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DesniGumb_MouseDown);
            this.DesniGumb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DesniGumb_MouseUp);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 318);
            this.Controls.Add(this.DesniGumb);
            this.Controls.Add(this.Napis);
            this.Controls.Add(this.LeviGumb);
            this.Name = "Okno";
            this.Text = "Levi in desni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeviGumb;
        private System.Windows.Forms.Label Napis;
        private System.Windows.Forms.Button DesniGumb;
    }
}


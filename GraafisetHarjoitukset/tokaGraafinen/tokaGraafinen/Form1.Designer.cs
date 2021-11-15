namespace tokaGraafinen
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
            this.PainikeBT = new System.Windows.Forms.Button();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.OhjetekstiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainikeBT
            // 
            this.PainikeBT.Location = new System.Drawing.Point(45, 56);
            this.PainikeBT.Name = "PainikeBT";
            this.PainikeBT.Size = new System.Drawing.Size(87, 23);
            this.PainikeBT.TabIndex = 0;
            this.PainikeBT.Text = "Vaihda teksti";
            this.PainikeBT.UseVisualStyleBackColor = true;
            this.PainikeBT.Click += new System.EventHandler(this.PainikeBT_Click);
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(11, 82);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(162, 13);
            this.OtsikkoLB.TabIndex = 1;
            this.OtsikkoLB.Text = "TÄHÄN ILMESTYY TEKSTIÄ :D";
            this.OtsikkoLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(23, 30);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(133, 20);
            this.TekstiTB.TabIndex = 2;
            this.TekstiTB.TextChanged += new System.EventHandler(this.TekstiTB_TextChanged);
            // 
            // OhjetekstiLB
            // 
            this.OhjetekstiLB.AutoSize = true;
            this.OhjetekstiLB.Location = new System.Drawing.Point(20, 14);
            this.OhjetekstiLB.Name = "OhjetekstiLB";
            this.OhjetekstiLB.Size = new System.Drawing.Size(141, 13);
            this.OhjetekstiLB.TabIndex = 3;
            this.OhjetekstiLB.Text = "Kirjoita jotain ja painanappia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 207);
            this.Controls.Add(this.OhjetekstiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.PainikeBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PainikeBT;
        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label OhjetekstiLB;
    }
}


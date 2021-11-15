namespace ekaGraafinen
{
    partial class LomakeFORM
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.PainikeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(13, 13);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(0, 13);
            this.OtsikkoLB.TabIndex = 0;
            // 
            // PainikeBT
            // 
            this.PainikeBT.Location = new System.Drawing.Point(12, 38);
            this.PainikeBT.Name = "PainikeBT";
            this.PainikeBT.Size = new System.Drawing.Size(90, 23);
            this.PainikeBT.TabIndex = 1;
            this.PainikeBT.Text = "Vaihda teksti";
            this.PainikeBT.UseVisualStyleBackColor = true;
            this.PainikeBT.Click += new System.EventHandler(this.PainikeBT_Click);
            // 
            // LomakeFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 178);
            this.Controls.Add(this.PainikeBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "LomakeFORM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LomakeFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button PainikeBT;
    }
}


namespace neljasGraafinenIKA
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
            this.AikavalitsinDTP = new System.Windows.Forms.DateTimePicker();
            this.VuodetLB = new System.Windows.Forms.Label();
            this.KuukaudetLB = new System.Windows.Forms.Label();
            this.PaivatLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AikavalitsinDTP
            // 
            this.AikavalitsinDTP.Location = new System.Drawing.Point(308, 93);
            this.AikavalitsinDTP.Name = "AikavalitsinDTP";
            this.AikavalitsinDTP.Size = new System.Drawing.Size(200, 20);
            this.AikavalitsinDTP.TabIndex = 0;
            // 
            // VuodetLB
            // 
            this.VuodetLB.AutoSize = true;
            this.VuodetLB.Location = new System.Drawing.Point(305, 202);
            this.VuodetLB.Name = "VuodetLB";
            this.VuodetLB.Size = new System.Drawing.Size(35, 13);
            this.VuodetLB.TabIndex = 1;
            this.VuodetLB.Text = "label1";
            this.VuodetLB.Visible = false;
            // 
            // KuukaudetLB
            // 
            this.KuukaudetLB.AutoSize = true;
            this.KuukaudetLB.Location = new System.Drawing.Point(305, 234);
            this.KuukaudetLB.Name = "KuukaudetLB";
            this.KuukaudetLB.Size = new System.Drawing.Size(35, 13);
            this.KuukaudetLB.TabIndex = 2;
            this.KuukaudetLB.Text = "label2";
            this.KuukaudetLB.Visible = false;
            this.KuukaudetLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // PaivatLB
            // 
            this.PaivatLB.AutoSize = true;
            this.PaivatLB.Location = new System.Drawing.Point(305, 265);
            this.PaivatLB.Name = "PaivatLB";
            this.PaivatLB.Size = new System.Drawing.Size(35, 13);
            this.PaivatLB.TabIndex = 3;
            this.PaivatLB.Text = "label3";
            this.PaivatLB.Visible = false;
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Location = new System.Drawing.Point(473, 202);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(35, 13);
            this.TunnitLB.TabIndex = 4;
            this.TunnitLB.Text = "label4";
            this.TunnitLB.Visible = false;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Location = new System.Drawing.Point(473, 233);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(35, 13);
            this.MinuutitLB.TabIndex = 5;
            this.MinuutitLB.Text = "label5";
            this.MinuutitLB.Visible = false;
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Location = new System.Drawing.Point(473, 265);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(35, 13);
            this.SekunnitLB.TabIndex = 6;
            this.SekunnitLB.Text = "label6";
            this.SekunnitLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(308, 133);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(200, 41);
            this.LaskeBT.TabIndex = 7;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.PaivatLB);
            this.Controls.Add(this.KuukaudetLB);
            this.Controls.Add(this.VuodetLB);
            this.Controls.Add(this.AikavalitsinDTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AikavalitsinDTP;
        private System.Windows.Forms.Label VuodetLB;
        private System.Windows.Forms.Label KuukaudetLB;
        private System.Windows.Forms.Label PaivatLB;
        private System.Windows.Forms.Label TunnitLB;
        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label SekunnitLB;
        private System.Windows.Forms.Button LaskeBT;
    }
}


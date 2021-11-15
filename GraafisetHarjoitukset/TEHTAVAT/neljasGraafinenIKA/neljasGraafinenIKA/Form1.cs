using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neljasGraafinenIKA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = AikavalitsinDTP.Value;
            double erotus = Math.Round(nyt - synttarit).TotalDays;
            PaivatLB.Text = erotus + "";
            PaivatLB.Visible = true;

            //365.25

            /*
            float vuodet = (DateTime.Now.Year - AikavalitsinDTP.Value.Year);
            float kuukaudet = (DateTime.Now.Month - AikavalitsinDTP.Value.Month);
            float paivat = (DateTime.Now.Day - AikavalitsinDTP.Value.Day);
            float tunnit = (DateTime.Now.Hour - AikavalitsinDTP.Value.Hour);
            float minuutit = (DateTime.Now.Minute - AikavalitsinDTP.Value.Minute);
            float sekunnit = (DateTime.Now.Second - AikavalitsinDTP.Value.Second);

            VuodetLB.Text = vuodet.ToString();
            VuodetLB.Visible = true;
            KuukaudetLB.Text = kuukaudet.ToString();
            KuukaudetLB.Visible = true;
            PaivatLB.Text = paivat.ToString();
            PaivatLB.Visible = true;
            TunnitLB.Text = tunnit.ToString();
            TunnitLB.Visible = true;
            MinuutitLB.Text = minuutit.ToString();
            MinuutitLB.Visible = true;
            SekunnitLB.Text = sekunnit.ToString();
            SekunnitLB.Visible = true;
            */
        }
    }
}

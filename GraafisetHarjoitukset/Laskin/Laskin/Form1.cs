using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Nelilaskin : Form
    {
        public Nelilaskin()
        {
            InitializeComponent();
        }

        private void LaskutoimitusCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(LukuYksiTB.Text);
            float luku2 = float.Parse(LukuKaksiTB.Text);
            string merkki = LaskutoimitusCB.Text;
            float lasku = 0;

            

            switch (merkki)
            {

                case ("+"):
                    lasku = luku1 + luku2;
                    
                    break;

                case ("-"):
                    lasku = luku1 - luku2;
                    
                    break;

                case ("*"):
                    lasku = luku1 * luku2;
                    
                    break;

                case ("/"):
                    if (luku2 == 0 || luku1 == 0)
                    {
                        VastausLB.Text = "0:lla ei voi jakaa";
                        goto hyppy;
                    }
                    else
                    {
                        lasku = luku1 / luku2;
                    }
                    
                    break;


                default:
                    VastausLB.Text = "Jokin meni pieleen :(";
                    goto hyppy;
                    break;



            }
            VastausLB.Text = "" + lasku + "";

            hyppy:
            VastausLB.Visible = true;

        }
    }
}

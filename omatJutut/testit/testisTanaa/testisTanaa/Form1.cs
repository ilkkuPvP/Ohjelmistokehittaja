using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testisTanaa
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void AloitaBT_Click(object sender, EventArgs e)
        {
            SpamTimerT.Interval = int.Parse(TimerIntTB.Text);
            SpamTimerT.Enabled = true;
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            SpamTimerT.Enabled = false;
        }

        private void SpamTimerT_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
            SendKeys.Send(SpamTextTB.Text);
        }

        private void OhjeBT_Click(object sender, EventArgs e)
        {
            OhjePanel.Visible = true;
        }

        private void OhjePoisBT_Click(object sender, EventArgs e)
        {
            OhjePanel.Visible = false;
        }
    }
}

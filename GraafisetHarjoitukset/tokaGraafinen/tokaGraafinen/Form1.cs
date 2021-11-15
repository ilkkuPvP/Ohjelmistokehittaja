using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokaGraafinen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TekstiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PainikeBT_Click(object sender, EventArgs e)
        {
            OtsikkoLB.Text = TekstiTB.Text;
            OtsikkoLB.Visible = true;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OtsikkoLB.Visible = false;
        }
    }
}

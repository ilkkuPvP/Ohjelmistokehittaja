using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekaGraafinen
{
    public partial class LomakeFORM : Form
    {
        public LomakeFORM()
        {
            InitializeComponent();
        }

        private void PainikeBT_Click(object sender, EventArgs e)
        {
            OtsikkoLB.Text = "Heippa maailma... YEET!";
        }

        private void LomakeFORM_Load(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBT_Click(object sender, EventArgs e)
        {
            string message = "EI!";
            string message2 = "NYT LOPPU!!";
            string message3 = "IHA OIKEESTI!";
            string message4 = ">:(";
            string message5 = "IHA SAMA SITTE!";
            string message6 = "MÄ HÄIVYN NYT!!1!!11!!";

            string title = ">:(";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                message = message2;
                result = MessageBox.Show(message, title, buttons);
            }

            if (result == DialogResult.OK)
            {
                message = message3;
                result = MessageBox.Show(message, title, buttons);
            }

            if (result == DialogResult.OK)
            {
                message = message4;
                result = MessageBox.Show(message, title, buttons);
            }

            if (result == DialogResult.OK)
            {
                message = message5;
                result = MessageBox.Show(message, title, buttons);
            }

            if (result == DialogResult.OK)
            {
                message = message6;
                result = MessageBox.Show(message, title, buttons);
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}

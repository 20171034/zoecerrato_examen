using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoeCerrato_Examen
{
    public partial class Multiplos : Form
    {
        public Multiplos()
        {
            InitializeComponent();
        }

        private void calcularbutton_Click(object sender, EventArgs e)
        {

            digital();      
        }
        public void digital()
        {
            

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    MultiploslistBox.Items.Add("Zoe");
                }
                if (i % 5 == 0)
                {
                    MultiploslistBox.Items.Add("Cerrato");
                }
                if (i%3 ==0 && i% 5 ==0)
                {
                    MultiploslistBox.Items.Add("Zoe Cerrato");
                }
                MultiploslistBox.Items.Add(i.ToString());
            }
            



        }

private void ResultadotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void digitetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            digitetextBox.Clear();
            MultiploslistBox.Text = "";
        }
    }
}

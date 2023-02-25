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
    public partial class interes : Form
    {
        

        private decimal deposito = 200000.00m;
        private decimal Interes = 0.015m;
        private int tiempo = 12;

        private List<String> valores;
        public interes()
        {
            InitializeComponent();
        }
       
        private void inicializar()
        {
            valores = new List<string>();
            for (int i = 1; i <= tiempo; i++)
            {

            }
        }
        




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
        }
        private void interes_load (object sender, EventArgs e)

        { 
            
            listamesesBox.Items.Add("Enero");
            listamesesBox.Items.Add("Febrero");
            listamesesBox.Items.Add("Marzo");
            listamesesBox.Items.Add("Abril");
            listamesesBox.Items.Add("Mayo");
            listamesesBox.Items.Add("Junio");
            listamesesBox.Items.Add("Julio");
            listamesesBox.Items.Add("Agosto");
            listamesesBox.Items.Add("Septiembre");
            listamesesBox.Items.Add("Octubre");
            listamesesBox.Items.Add("Noviembre");
            listamesesBox.Items.Add("Enero");





        }
    }
}

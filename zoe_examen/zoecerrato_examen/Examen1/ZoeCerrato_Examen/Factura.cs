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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private async void calcular_Click(object sender, EventArgs e)
        {
            string producto= productostextbox.Text;
            decimal precio = decimal.Parse( preciotextBox.Text);
            int cantidad = int.Parse(cantidadtextBox.Text);


            decimal subtotal = precio * cantidad;
            decimal descuento = await calculardescuentoAsync(subtotal);

            MessageBox.Show($"descuento: {descuento:c}\nTotal a Pagar: {subtotal - descuento:c}");
        }
        private async Task<decimal> calculardescuentoAsync(decimal subtotal)
        {
            await Task.Delay(1000);

            decimal descuento = subtotal * 0.15m;

            return descuento;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Farmacia_Compras.Formularios;

namespace TP_Farmacia_Compras
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();  
            compra.StartPosition = FormStartPosition.CenterScreen;
            compra.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.StartPosition = FormStartPosition.CenterScreen;
            venta.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Farmacia_Compras.Formularios
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void chReceta_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chReceta.Checked)
            {
                pnNumeroReceta.Visible = true;
                txtNumeroReceta.Focus();

            }
            else
            {
                pnNumeroReceta.Visible = false;
                txtNumeroReceta.Clear();
            }
        }
    }
}

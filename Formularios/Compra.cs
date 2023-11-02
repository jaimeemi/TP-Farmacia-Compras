using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Farmacia_Compras.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_Farmacia_Compras.Formularios
{
    public partial class Compra : Form
    {
        DataTable dtProductos = ProductosDAO.ListaDeProductos();
        DataTable dtProveedores = ProveedoresDAO.ListaDeProveedores();
        DataTable dtTransportes = TransportesDAO.ListaTransportes();
        DataTable dtFomrasPago = FormasPagoDAO.ListaFormasDePago();

        ComprasDAO NuevaCompra = new ComprasDAO();
        
        public Compra()
        {
            InitializeComponent();

            CargarProductos();
            CargarProveedores();
            CargarFormasPago();
            CargarTransportes();

            lblNumeroCOmpra.Text = "Compra N°: "+  NuevaCompra.ID_Compra.ToString();
            mskFecha.Text = DateTime.Now.ToString();

            Grilla.DataSource = NuevaCompra.detalles;
        }

        private void CargarProductos()
        {
            cbArticulos.DataSource = dtProductos;
            cbArticulos.DisplayMember = "Descripcion";
            cbArticulos.ValueMember = "ID_Producto";
        }
        private void CargarProveedores()
        {
            cbProveedor.DataSource = dtProveedores;
            cbProveedor.DisplayMember = "RazonSocial";
            cbProveedor.ValueMember = "ID_Proveedor";
        }
        private void CargarFormasPago()
        {
            cbFormaPago.DataSource = dtFomrasPago;
            cbFormaPago.DisplayMember = "descripcion";
            cbFormaPago.ValueMember = "ID_FormaPago";
            cbFormaPago.SelectedIndex = 2;
        }
        private void CargarTransportes()
        {
            cbTransporte.DataSource = dtTransportes;
            cbTransporte.DisplayMember = "Descripcion_Transporte";
            cbTransporte.ValueMember = "ID_Transporte";
        }

        private void cbArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.Equals(Keys.Enter)) && (cbArticulos.SelectedIndex != 0))  
            {
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Equals(""))
            {
                MessageBox.Show("Debe ingresar un valor valido y superior a 0");
                txtCantidad.Text = "";
                txtCantidad.Focus();
                return;
            }
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            try
            {
                int resultado = int.Parse(txtCantidad.Text);
            }
            catch { txtCantidad.Text = "";  }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (NuevaCompra.detalles.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos 1 producto");
                return;
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView proveedor = (DataRowView)cbProveedor.SelectedItem;
            NuevaCompra.ID_Proveedor = Convert.ToInt32(proveedor.Row.ItemArray[0]);
            NuevaCompra.ID_TipoComprobante = Convert.ToInt32(proveedor.Row.ItemArray[1]);
        }

        private void cbFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView formaPago = (DataRowView) cbFormaPago.SelectedItem;
            NuevaCompra.ID_FormaPago = Convert.ToInt32(formaPago.Row.ItemArray[0]);
            NuevaCompra.ID_CuentaBancaria = Convert.ToInt32(formaPago.Row.ItemArray[2]);
        }

        private void cbTransporte_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView Transporte = (DataRowView) cbTransporte.SelectedItem;
            NuevaCompra.ID_Transporte = Convert.ToInt32(Transporte.Row.ItemArray[1]);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (NuevaCompra.detalles != null)
            {
                if (NuevaCompra.detalles.Count == 0)
                {
                    MessageBox.Show("No puede cerrar una compra si haber seleccionado algun producto para comprar");
                    return;
                }
            }
            if (NuevaCompra.YaTieneProducto(Convert.ToInt32(((DataRowView)cbArticulos.SelectedItem).Row.ItemArray[0]), NuevaCompra))
            {
                MessageBox.Show("Producto: " + cbArticulos.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DetalleComprasDAO Detalle = new DetalleComprasDAO();
                DataRowView producto = (DataRowView)cbArticulos.SelectedItem;
                Detalle.ID_Compra = NuevaCompra.ID_Compra;
                Detalle.ID_Producto = Convert.ToInt32(producto.Row.ItemArray[0]);
                Detalle.ID_Descuento = 0;
                Detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                NuevaCompra.AgregarDetalle(Detalle);

                Grilla.Rows.Add(new object[] {
                    producto.Row.ItemArray[0],//ID_Producto
                    producto.Row.ItemArray[1], //Descripcion
                    producto.Row.ItemArray[2].ToString() , //Precio Unitario
                    txtCantidad.Text,         //Cantidad
                    0,                                          //Bonificacion
                    (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(producto.Row.ItemArray[2])).ToString(),// Total
                    });
            }

        }
    }
}

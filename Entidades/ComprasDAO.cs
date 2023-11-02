using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TP_Farmacia_Compras.Formularios;

namespace TP_Farmacia_Compras.Entidades
{
    internal class ComprasDAO
    {
        public int ID_Compra {  get; set; }
        public string nro_compra {  get; set; }
        public int ID_TipoComprobante { get; set; }
        public int ID_Proveedor {  get; set; }
        public DateTime  Fecha { get; set; }
        public int ID_FormaPago { get; set; }
        public int ID_CuentaBancaria {  get; set; }
        public int ID_Transporte { get; set; }
        public List<DetalleComprasDAO> detalles {  get; set; }
        


        public ComprasDAO()
        {
            this.ID_Compra = NuevoNumeroCompra();
            this.Fecha = DateTime.Now;
        }


        private int NuevoNumeroCompra()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select MAx(ID_Compra) as 'Cantidad' From Compras", con);
                SqlParameter resultado = new SqlParameter("Cantidad", System.Data.SqlDbType.Int);
                resultado.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(resultado);
                int resu = cmd.ExecuteNonQuery();
                this.ID_Compra = resu;
                return resu;
            }
            catch 
            { 
                return 00001;
            }
            
        }

        public void AgregarDetalle(DetalleComprasDAO detalle)
        {

            if (detalles != null)
            {
                detalles.Add(detalle);
            }
            
        }

        public bool YaTieneProducto(int idProducto, ComprasDAO compra)
        {
            if (compra.detalles != null)
            {
                List<DetalleComprasDAO> de = compra.detalles;
                foreach (DetalleComprasDAO detalle in de)
                {
                    if (detalle.ID_Producto.Equals(idProducto))
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
    }
}

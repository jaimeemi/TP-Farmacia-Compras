using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia_Compras.Entidades
{
	internal class ProductosDAO
	{

		int ID_Producto { get; set; }
		String Descripcion { get; set; }
		float PrecioUnitario { get; set; }
		bool estado {  get; set; }
		DateTime Fec_Vencimiento {  get; set; }
		int StockActual {  get; set; }
		int StockMinimo {  get; set; }
		String CodigoBarra {  get; set; }
		bool BajoReceta {  get; set; }
		int ID_Unidad {  get; set; }
		int ID_TipoProducto {  get; set; }
		float Descuento_producto {  get; set; }


        public static DataTable ListaDeProductos()
        {
            /*
            List<Productos> lista = new List<Productos>();
			SqlDataReader dr = null;
            SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select * from vProductos", con);
            con.Open();
			dr = cm.ExecuteReader();
            while (dr.HasRows)
            {
				Productos p = new Productos();
				p.ID_Producto = (int)dr.GetValue(0);
                p.Descripcion = dr.GetString(1);
                p.PrecioUnitario = (float)dr.GetDouble(2); 
                p.estado = dr.GetBoolean(3);
                p.Fec_Vencimiento = dr.GetDateTime(4);
                p.StockActual = (int)dr.GetValue(5);
                p.StockMinimo = (int)dr.GetValue(6);
                p.CodigoBarra = dr.GetString(7);
                p.BajoReceta = dr.GetBoolean(8);
                p.ID_Unidad = (int)dr.GetValue(9);
                p.ID_TipoProducto = (int)dr.GetValue(10);
                p.Descuento_producto = (float)dr.GetDouble(11);
                lista.Add(p);
                dr.NextResult();
            }
            con.Close();
            return dt;
             */
            DataTable dt    = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select * from vProductos order by Descripcion", con);
            con.Open();
            dt.Load(cm.ExecuteReader());
            con.Close();
            return dt;
            
        }
        
    }

}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia_Compras.Entidades
{
    internal class ProveedoresDAO
    {

        int ID_Proveedor { get; set; }
        int ID_TipoProveedor { get; set; }
	    int ID_Persona { get; set; }
        String Cuit { get; set; }
        String RazonSocial { get; set; }
        int ID_Transporte { get; set; }
        int id_condicion_iva { get; set; }


        public ProveedoresDAO() { }

        public static DataTable ListaDeProveedores()
        {
            /*
            List<Proveedores> lista = new List<Proveedores>();
            SqlDataReader dr = null;
            SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select * from vProveedores", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.HasRows)
            {
                Proveedores p = new Proveedores();
                p.ID_Proveedor = (int)dr.GetValue(0);
                p.ID_TipoProveedor = (int)dr.GetValue(1);
                p.Cuit = dr.GetString(3);
                p.RazonSocial = dr.GetString(4);
                p.ID_Transporte = (int)dr.GetValue(5);
                p.id_condicion_iva = (int)dr.GetValue(6);
                lista.Add(p);
                dr.NextResult();
            }
            con.Close();
            return lista;
             */
            DataTable lista = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select * from vProveedores order by RazonSocial", con);
            con.Open();
            lista.Load(cm.ExecuteReader());
            return lista;
        }


    }
}

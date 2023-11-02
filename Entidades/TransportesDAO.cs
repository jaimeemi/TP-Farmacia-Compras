using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia_Compras.Entidades
{
    internal class TransportesDAO
    {

        public int ID_Transporte { get; set; }
        public string Descripcion_Transporte {  get; set; }
        

        public static DataTable ListaTransportes()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select Descripcion_Transporte, ID_Transporte from Transportes  order by  Descripcion_Transporte", con);
            con.Open();
            dt.Load(cm.ExecuteReader());
            con.Close();
            return dt;
        }
    }
}

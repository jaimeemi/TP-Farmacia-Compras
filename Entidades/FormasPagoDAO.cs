using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia_Compras.Entidades
{
    internal class FormasPagoDAO
    {
        public int ID_FormaPago {  get; set; }
        public string Descripcion {  get; set; }
        public int ID_CuentaBancaria { get; set; }

        public static  DataTable ListaFormasDePago()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select ID_FormaPago, descripcion, ID_CuentaBancaria from FormasPagos Order By Descripcion", con);
            con.Open();
            dt.Load(cm.ExecuteReader());
            con.Close();
            return dt;
        }

    }
}

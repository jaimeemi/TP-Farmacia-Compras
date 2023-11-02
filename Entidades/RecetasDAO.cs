using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia_Compras.Entidades
{
    internal class RecetasDAO
    {
		public int ID_Receta {  get; set; }
		public string NROReceta {  get; set; }
		public int ID_ObraSocial {  get; set; }
		public int ID_Cliente {  get; set; }
		public int ID_Medico {  get; set; }
		public int ID_Solicitud {  get; set; }
		public DateTime Fecha_Emision {  get; set; }
		public DateTime Fecha_Vencimiento {  get; set; }

		public RecetasDAO() { }		
    }
}

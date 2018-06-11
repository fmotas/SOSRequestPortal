using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSRequestPortal.Models
{
    public class ItemRequest
    {
		public int RequestID { get; set; }
		public DateTime Data { get; set; }
		public string Ticket { get; set; }
		public string Item { get; set; }
		public string TipoDeImagem { get; set; }
		public string Colaborador { get; set; }
		public string Time { get; set; }
		public string Gestor { get; set; }
		public string Requisitante { get; set; }
		public DateTime HorarioDaRequisicao { get; set; }
		public DateTime HorarioDaRetirada { get; set; }
		public string Status { get; set; }
	}
}

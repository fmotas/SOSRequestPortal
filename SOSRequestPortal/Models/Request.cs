using System;
using System.ComponentModel;

namespace SOSRequestPortal.Models
{
	public class Request : IRequest
	{
		[DisplayName("ID")]
		public int RequestID { get; set; }
		public string Data { get; set; }
		public string Ticket { get; set; }
		public string Item { get; set; }
		[DisplayName("Tipo De Imagem")]
		public string TipoDeImagem { get; set; }
		public string Colaborador { get; set; }
		public string Time { get; set; }
		public string Gestor { get; set; }
		public string Requisitante { get; set; }
		[DisplayName("Horário Da Requisição")]
		public string HorarioDaRequisicao { get; set; }
		[DisplayName("Horário Da Retirada")]
		public string HorarioDaRetirada { get; set; }
		public string Status { get; set; }
		[DisplayName("Patrimônio")]
		public string Patrimonio { get; set; }
		[DisplayName("Número de Série")]
		public string NumeroDeSerie { get; set; }
		[DisplayName("Retirado Por")]
		public string RetiradoPor { get; set; }
		[DisplayName("Entregue Por")]
		public string EntreguePor { get; set; }
		[DisplayName("Observação")]
		public string Observacao { get; set; }
	}
}

using System.ComponentModel;

namespace SOSRequestPortal.Models
{
	public interface IRequest
	{
		[DisplayName("ID")]
		int RequestID { get; set; }
		string Data { get; set; }
		string Ticket { get; set; }
		string Item { get; set; }
		[DisplayName("Tipo De Imagem")]
		string TipoDeImagem { get; set; }
		string Colaborador { get; set; }
		string Time { get; set; }
		string Gestor { get; set; }
		string Requisitante { get; set; }
		[DisplayName("Horário Da Requisição")]
		string HorarioDaRequisicao { get; set; }
		[DisplayName("Horário Da Retirada")]
		string HorarioDaRetirada { get; set; }
		string Status { get; set; }
		[DisplayName("Patrimônio")]
		string Patrimonio { get; set; }
		[DisplayName("Número de Série")]
		string NumeroDeSerie { get; set; }
		[DisplayName("Retirado Por")]
		string RetiradoPor { get; set; }
		[DisplayName("Entregue Por")]
		string EntreguePor { get; set; }
		[DisplayName("Observação")]
		string Observacao { get; set; }
	}
}
using SOSRequestPortal.Models;
using System;
using System.Collections.Generic;

namespace SOSRequestPortal.Repository
{
	public class RequestRepository
    {
		private static RequestRepository instance = null;

		public List<Request> requests = new List<Request>();/*
		{ new Request()
			{
			Data = DateTime.Now.ToString("dd/MM/yyyy"),
			Ticket = "123456",
			Item = "Adaptador DVI/VGA",
			TipoDeImagem = "NSA",
			Colaborador = "Joana da Silva",
			Time = "RC",
			Gestor = "Amanda Ribeiro",
			Requisitante = "Alex",
			HorarioDaRequisicao = DateTime.Now.ToString("HH:mm:ss"),
			HorarioDaRetirada = "15h",
			Status = "Devolvido por defeito",
			Patrimonio = "NSA",
			NumeroDeSerie = "NSA"
			}
		};*/


		private RequestRepository()
		{

		}

		public static RequestRepository GetInstance()
		{
			if (instance == null)
			{
				instance = new RequestRepository();
				return instance;
			}
			return instance;
		}
	}
}

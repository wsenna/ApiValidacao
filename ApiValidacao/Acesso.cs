using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ApiValidacao
{
    public static class Acesso
    {
        //public void acessoTeste()
        //{
            
        //}

        //public static void Consultar()
        //{
        //    var ctx = new Context(Constants.db_connection);

        //    try
        //    {
        //        IQueryable<ApiModel.Antecipacao> consultaAntecipacoes;

        //        consultaAntecipacoes = ctx.Antecipacoes.Include(x => x.Token.Usuario);

        //        //ANTECIPACOES DO USUARIO
        //        if (request.UsuarioId != null)
        //            consultaAntecipacoes = consultaAntecipacoes.Where(x => x.Token.UsuarioId == request.UsuarioId);

        //        if (!string.IsNullOrEmpty(request.DataInicio))
        //        {
        //            var dataInicio = Convert.ToDateTime(request.DataInicio);

        //            consultaAntecipacoes = consultaAntecipacoes.Where(x => x.DataCadastro.Date >= dataInicio.Date);
        //        }

        //        if (!string.IsNullOrEmpty(request.DataFim))
        //        {
        //            var dataFim = Convert.ToDateTime(request.DataFim);

        //            consultaAntecipacoes = consultaAntecipacoes.Where(x => x.DataCadastro.Date <= dataFim.Date);
        //        }

        //        if (!string.IsNullOrEmpty(request.Status))
        //        {
        //            consultaAntecipacoes = consultaAntecipacoes.Where(x => x.Status == request.Status);
        //        }

        //        if (!string.IsNullOrEmpty(request.CpfCnpj))
        //        {
        //            consultaAntecipacoes = consultaAntecipacoes.Where(x => x.Token.Usuario.CpfCnpj == request.CpfCnpj);
        //        }

        //        consultaAntecipacoes = consultaAntecipacoes.OrderByDescending(x => x.DataCadastro);

        //        var relatorio = new List<object>();

        //        foreach (var antecipacao in consultaAntecipacoes.ToList())
        //        {
        //            relatorio.Add(new
        //            {
        //                Id = antecipacao.Id,
        //                DataCadastro = antecipacao.DataCadastro,
        //                TokenId = antecipacao.TokenId,
        //                Valor = antecipacao.Valor,
        //                Taxas = antecipacao.Taxas,
        //                Status = antecipacao.Status,
        //                BloqueadoAte = antecipacao.BloqueadoAte,
        //                Compensado = antecipacao.Compensado,
        //                MotivoCancelamento = antecipacao.MotivoCancelamento,
        //                NomeRazao = antecipacao.Token.Usuario.NomeRazao,
        //                CpfCnpj = antecipacao.Token.Usuario.CpfCnpj
        //            });
        //        }

        //        var qtdPorPagina = 0;

        //        qtdPorPagina = request.Paginacao.RegistrosPorPagina > 0
        //            ? request.Paginacao.RegistrosPorPagina
        //            : relatorio.Count();

        //        var result = relatorio.AsQueryable().GetPaged(request.Paginacao.PaginaAtual, qtdPorPagina);

        //        Default retorno = new Default(result);

        //        retorno.Requisicao.Add(Constants.Retornos._200);

        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
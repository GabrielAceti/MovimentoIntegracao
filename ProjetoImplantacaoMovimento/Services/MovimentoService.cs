using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoImplantacaoMovimento.Services
{
    public class MovimentoService
    {
        public void AdicionaMovimento(Movimento movimento)
        {
            var fs = new FileService();
            fs.WriteFile(ParseMovimentoTxt(movimento), MovimentoDefaults.MovimentoPath);

            new ItemMovimentoService().AdicionaItensMovimento(movimento.ItensMovimento);
        }

        public void EditaMovimento(Movimento movimento)
        {
            ExcluiMovimento(movimento);
            AdicionaMovimento(movimento);
        }

        public void ExcluiMovimento(Movimento movimento)
        {
            var movimentos = GetMovimentos();
            movimentos.RemoveAll(x => x.IdMovimento == movimento.IdMovimento);

            List<string> data = ParseMovimentosTxt(movimentos);

            var fileService = new FileService();
            fileService.WriteAllLines(data, MovimentoDefaults.MovimentoPath);

            new ItemMovimentoService().ExcluiItensMovimento(movimento.ItensMovimento);
        }

        public List<Movimento> GetMovimentos()
        {
            var movimentos = new List<Movimento>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.MovimentoPath);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                movimentos.Add(MapearMovimento(fileLines[i].Split('|')));
            }
            return movimentos;
        }

        public List<Movimento> GetMovimentosById(string idMovimento)
        {
            var movimentos = new List<Movimento>();

            var fileService = new FileService();
            IEnumerable<string> fileLines = fileService.ReadFile(MovimentoDefaults.MovimentoPath).Where(x => x.StartsWith(idMovimento));

            foreach (string line in fileLines)
            {
                var movimentoMapeado = MapearMovimento(line.Split('|'));
                movimentoMapeado.ItensMovimento = new ItemMovimentoService().GetItensMovimentoByIdMovimento(movimentoMapeado.IdMovimento);

                movimentos.Add(movimentoMapeado);
            }
            return movimentos;
        }

        private string ParseMovimentoTxt(Movimento movimento)
        {
            return String.Format($@"{movimento.IdMovimento}|{movimento.NumeroMovimento}|{movimento.Descricao}|{movimento.Observacao}|{movimento.CriadoPor}|{movimento.CriadoEm}|{movimento.ModificadoPor}|{movimento.ModificadoEm}");
        }

        private List<string> ParseMovimentosTxt(List<Movimento> movimentos)
        {
            List<string> data = new List<string>();
            foreach (Movimento movimento in movimentos)
            {
                data.Add(String.Format($@"{movimento.IdMovimento}|{movimento.NumeroMovimento}|{movimento.Descricao}|{movimento.Observacao}|{movimento.CriadoPor}|{movimento.CriadoEm}|{movimento.ModificadoPor}|{movimento.ModificadoEm}"));
            }
            return data;
        }

        private Movimento MapearMovimento(string[] movimentos)
        {
            if (string.IsNullOrEmpty(movimentos[0]))
                return null;

            return new Movimento()
            {
                IdMovimento = movimentos[0],
                NumeroMovimento = movimentos[1],
                Descricao = movimentos[2],
                Observacao = movimentos[3],
                CriadoPor = movimentos[4],
                CriadoEm = movimentos[5],
                ModificadoPor = movimentos[6],
                ModificadoEm = movimentos[7]
            };
        }

        public int GerarNovoId()
        {
            var movimentos = GetMovimentos();
            return movimentos.Count() == 0 ? 1 : int.Parse(movimentos.Max(x => x.IdMovimento)) + 1;
        }
    }
}

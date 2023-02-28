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
            var movimentos = GetMovimentos();

            int newId = movimentos.Count() == 0 ? 1 : int.Parse(movimentos.Max(x => x.IdMovimento)) + 1;
            movimento.IdMovimento = newId.ToString();

            var fs = new FileService();
            fs.WriteFile(ParseMovimentoTxt(movimento), MovimentoDefaults.MovimentoPath);
        }

        public void EditaMovimento(Movimento movimento)
        {
            var movimentos = GetMovimentos();
            ExcluiMovimento(movimento.IdMovimento);

            AdicionaMovimento(movimento);
        }

        public void ExcluiMovimento(string idMovimento)
        {
            var movimentos = GetMovimentos();
            movimentos.RemoveAll(x => x.IdMovimento == idMovimento);

            List<string> data = ParseMovimentosTxt(movimentos);

            var fileService = new FileService();
            fileService.WriteAllLines(data, MovimentoDefaults.MovimentoPath);
        }

        public List<Movimento> GetMovimentos()
        {
            var movimentos = new List<Movimento>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.MovimentoPath);

            for(int i=0; i< fileLines.Count(); i++)
            {
                movimentos.Add(MapearMovimento(fileLines[i].Split('|')));
            }
            return movimentos;
        }

        private string ParseMovimentoTxt(Movimento movimento)
        {
            return String.Format($@"{movimento.IdMovimento}|{movimento.NumeroMovimento}|{movimento.Descricao}|{movimento.CriadoPor}|{movimento.CriadoEm}|{movimento.ModificadoPor}|{movimento.ModificadoEm}");
        }

        private List<string> ParseMovimentosTxt(List<Movimento> movimentos)
        {
            List<string> data = new List<string>();
            foreach(Movimento movimento in movimentos)
            {
                data.Add(String.Format($@"{movimento.IdMovimento}|{movimento.NumeroMovimento}|{movimento.Descricao}|{movimento.CriadoPor}|{movimento.CriadoEm}|{movimento.ModificadoPor}|{movimento.ModificadoEm}"));
            }
            return data;
        }

        private Movimento MapearMovimento(string[] movimento)
        {
            return new Movimento()
            {
                IdMovimento = movimento[0],
                NumeroMovimento = movimento[1],
                Descricao = movimento[2],
                CriadoPor = movimento[3],
                CriadoEm = movimento[4],
                ModificadoPor = movimento[5],
                ModificadoEm = movimento[6]
            };
        }
    }
}

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

            int newId = int.Parse(movimentos.Max(x => x.IdMovimento)) + 1;
            movimento.IdMovimento = newId.ToString();

            var fs = new FileService();
            fs.WriteFile(ParseMovimentoTxt(movimento), MovimentoDefaults.MovimentoPath);
        }

        public List<Movimento> GetMovimentos()
        {
            var movimentos = new List<Movimento>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.MovimentoPath);

            for(int i=0; i< fileLines.Count(); i++)
            {
                movimentos.Add(MapMovimento(fileLines[i].Split('|')));
            }
            return movimentos;
        }

        private string ParseMovimentoTxt(Movimento movimento)
        {
            return String.Format($@"{movimento.IdMovimento}|{movimento.NumeroMovimento}|{movimento.Descricao}|{movimento.CriadoPor}|{movimento.CriadoEm}|{movimento.ModificadoPor}|{movimento.ModificadoEm}");
        }

        private Movimento MapMovimento(string[] movimento)
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

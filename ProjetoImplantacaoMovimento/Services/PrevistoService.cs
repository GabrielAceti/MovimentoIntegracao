using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoImplantacaoMovimento.Services
{
    public class PrevistoService
    {
        public void AdicionaPrevisto(Previsto previsto)
        {
            var previstos = GetPrevistos();

            int newId = previstos.Count() == 0 ? 1 : int.Parse(previstos.Max(x => x.IdPrevisto)) + 1;
            previsto.IdPrevisto = newId.ToString();

            var fs = new FileService();
            fs.WriteFile(ParsePrevistoTxt(previsto), MovimentoDefaults.PrevistoPath);
        }

        public List<Previsto> GetPrevistos()
        {
            var previstos = new List<Previsto>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.PrevistoPath);

            for(int i=0; i< fileLines.Count(); i++)
            {
                previstos.Add(MapPrevisto(fileLines[i].Split('|')));
            }
            return previstos;
        }

        private string ParsePrevistoTxt(Previsto previsto)
        {
            return String.Format($@"{previsto.IdPrevisto}|{previsto.Descricao}|{previsto.CriadoPor}|{previsto.CriadoEm}|{previsto.ModificadoPor}|{previsto.ModificadoEm}");
        }

        private Previsto MapPrevisto(string[] previsto)
        {
            return new Previsto()
            {
                IdPrevisto = previsto[0],
                Descricao = previsto[1],
                CriadoPor = previsto[2],
                CriadoEm = previsto[3],
                ModificadoPor = previsto[4],
                ModificadoEm = previsto[5]
            };
        }
    }
}

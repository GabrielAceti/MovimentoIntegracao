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
            var fs = new FileService();
            fs.WriteFile(ParsePrevistoTxt(previsto), MovimentoDefaults.PrevistoPath);
        }

        public void EditaPrevisto(Previsto previsto)
        {
            var previstos = GetPrevistos();
            ExcluiPrevisto(previsto.IdPrevisto);

            AdicionaPrevisto(previsto);
        }

        public void ExcluiPrevisto(string idPrevisto)
        {
            var previstos = GetPrevistos();
            previstos.RemoveAll(x => x.IdPrevisto == idPrevisto);

            List<string> data = ParsePrevistosTxt(previstos);

            var fileService = new FileService();
            fileService.WriteAllLines(data, MovimentoDefaults.PrevistoPath);
        }

        public List<Previsto> GetPrevistos()
        {
            var previstos = new List<Previsto>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.PrevistoPath);

            for(int i=0; i< fileLines.Count(); i++)
            {
                previstos.Add(MapearPrevisto(fileLines[i].Split('|')));
            }
            return previstos;
        }

        public Previsto GetPrevistoById(string idPrevisto)
        {
            var previstos = new List<Previsto>();

            var fileService = new FileService();
            IEnumerable<string> fileLines = fileService.ReadFile(MovimentoDefaults.PrevistoPath).Where(x => x.StartsWith(idPrevisto));

            foreach (string line in fileLines)
            {
                previstos.Add(MapearPrevisto(line.Split('|')));
            }
            return previstos.FirstOrDefault();
        }

        private string ParsePrevistoTxt(Previsto previsto)
        {
            return String.Format($@"{previsto.IdPrevisto}|{previsto.Descricao}|{previsto.CriadoPor}|{previsto.CriadoEm}|{previsto.ModificadoPor}|{previsto.ModificadoEm}");
        }

        private List<string> ParsePrevistosTxt(List<Previsto> previstos)
        {
            List<string> data = new List<string>();
            foreach (Previsto previsto in previstos)
            {
                data.Add(String.Format($@"{previsto.IdPrevisto}|{previsto.Descricao}|{previsto.CriadoPor}|{previsto.CriadoEm}|{previsto.ModificadoPor}|{previsto.ModificadoEm}"));
            }
            return data;
        }

        private Previsto MapearPrevisto(string[] previsto)
        {
            if (string.IsNullOrEmpty(previsto[0]))
                return null;

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

        public int GerarNovoId()
        {
            var previstos = GetPrevistos();
            return previstos.Count() == 0 ? 1 : int.Parse(previstos.Max(x => x.IdPrevisto)) + 1;
        }
    }
}

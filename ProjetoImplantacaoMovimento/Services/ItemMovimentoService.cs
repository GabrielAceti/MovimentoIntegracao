using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Services;
using ProjetoImplantacaoMovimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoImplantacaoMovimento.Services
{
    public class ItemMovimentoService
    {
        public void AdicionaItensMovimento(List<ItemMovimento> itensMovimento)
        {
            foreach(ItemMovimento itemMovimento in itensMovimento)
            {
                var fs = new FileService();
                fs.WriteFile(ParseItemMovimentoTxt(itemMovimento), MovimentoDefaults.ItemMovimentoPath);
            }
            
        }

        public void ExcluiItensMovimento(List<ItemMovimento> itensMovimento)
        {
            foreach (ItemMovimento itemMovimento in itensMovimento)
            {
                var itens = GetItensMovimento();
                itens.RemoveAll(x => x.IdItemMovimento == itemMovimento.IdItemMovimento);

                List<string> data = ParseItensMovimentoTxt(itens);

                var fileService = new FileService();
                fileService.WriteAllLines(data, MovimentoDefaults.ItemMovimentoPath);
            }               
        }

        public List<ItemMovimento> GetItensMovimento()
        {
            var itens = new List<ItemMovimento>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.ItemMovimentoPath);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                itens.Add(MapearItemMovimento(fileLines[i].Split('|')));
            }
            return itens;
        }

        public List<ItemMovimento> GetItensMovimentoByIdMovimento(string idMovimento)
        {
            var itens = new List<ItemMovimento>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.ItemMovimentoPath);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                itens.Add(MapearItemMovimento(fileLines[i].Split('|')));
            }

            return itens.Where(x => x.IdMovimento == idMovimento).ToList();
        }

        public List<ItemMovimento> GetItensMovimentoById(string idItemMovimento)
        {
            var itens = new List<ItemMovimento>();

            var fileService = new FileService();
            IEnumerable<string> fileLines = fileService.ReadFile(MovimentoDefaults.ItemMovimentoPath).Where(x => x.StartsWith(idItemMovimento));

            foreach (string line in fileLines)
            {
                itens.Add(MapearItemMovimento(line.Split('|')));
            }
            return itens;
        }

        private string ParseItemMovimentoTxt(ItemMovimento itemMovimento)
        {
            return String.Format($@"{itemMovimento.IdItemMovimento}|{itemMovimento.IdItem}|{itemMovimento.IdMovimento}|{itemMovimento.IdPrevisto}|{itemMovimento.Observacao}|{itemMovimento.CriadoPor}|{itemMovimento.CriadoEm}|{itemMovimento.ModificadoPor}|{itemMovimento.ModificadoEm}");
        }

        private List<string> ParseItensMovimentoTxt(List<ItemMovimento> itensMovimento)
        {
            List<string> data = new List<string>();
            foreach (ItemMovimento itemMovimento in itensMovimento)
            {
                data.Add(String.Format($@"{itemMovimento.IdItemMovimento}|{itemMovimento.IdItem}|{itemMovimento.IdMovimento}|{itemMovimento.IdPrevisto}|{itemMovimento.Observacao}|{itemMovimento.CriadoPor}|{itemMovimento.CriadoEm}|{itemMovimento.ModificadoPor}|{itemMovimento.ModificadoEm}"));
            }
            return data;
        }

        private ItemMovimento MapearItemMovimento(string[] itemMovimento)
        {
            if (string.IsNullOrEmpty(itemMovimento[0]))
                return null;

            return new ItemMovimento()
            {
                IdItemMovimento = itemMovimento[0],
                IdItem = itemMovimento[1],
                IdMovimento = itemMovimento[2],
                IdPrevisto = itemMovimento[3],
                Observacao = itemMovimento[4],
                CriadoPor = itemMovimento[5],
                CriadoEm = itemMovimento[6],
                ModificadoPor = itemMovimento[7],
                ModificadoEm = itemMovimento[8]
            };
        }

        public int GerarNovoId()
        {
            var itens = GetItensMovimento();
            return itens.Count() == 0 ? 1 : int.Parse(itens.Max(x => x.IdItemMovimento)) + 1;
        }
    }
}

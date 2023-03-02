using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Services;
using ProjetoImplantacaoMovimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoImplantacaoMovimento.Services
{
    public class ItemService
    {
        public void AdicionaItem(Item item)
        {
            var fs = new FileService();
            fs.WriteFile(ParseItemTxt(item), MovimentoDefaults.ItemPath);
        }

        public void EditaItem(Item item)
        {
            ExcluiItem(item.IdItem);

            AdicionaItem(item);
        }

        public void ExcluiItem(string idItem)
        {
            var itens = GetItens();
            itens.RemoveAll(x => x.IdItem == idItem);

            List<string> data = ParseItensTxt(itens);

            var fileService = new FileService();
            fileService.WriteAllLines(data, MovimentoDefaults.ItemPath);
        }

        public List<Item> GetItens()
        {
            var itens = new List<Item>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.ItemPath);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                itens.Add(MapearItem(fileLines[i].Split('|')));
            }
            return itens;
        }

        public List<Item> GetItensById(string idItem)
        {
            var itens = new List<Item>();

            var fileService = new FileService();
            IEnumerable<string> fileLines = fileService.ReadFile(MovimentoDefaults.ItemPath).Where(x => x.StartsWith(idItem));

            foreach (string line in fileLines)
            {
                itens.Add(MapearItem(line.Split('|')));
            }
            return itens;
        }

        private string ParseItemTxt(Item item)
        {
            return String.Format($@"{item.IdItem}|{item.IdMovimento}|{item.IdPrevisto}|{item.Descricao}|{item.CriadoPor}|{item.CriadoEm}|{item.ModificadoPor}|{item.ModificadoEm}");
        }

        private List<string> ParseItensTxt(List<Item> Itenss)
        {
            List<string> data = new List<string>();
            foreach (Item item in Itenss)
            {
                data.Add(String.Format($@"{item.IdItem}|{item.IdMovimento}|{item.IdPrevisto}|{item.Descricao}|{item.CriadoPor}|{item.CriadoEm}|{item.ModificadoPor}|{item.ModificadoEm}"));
            }
            return data;
        }

        private Item MapearItem(string[] itens)
        {
            if (string.IsNullOrEmpty(itens[0]))
                return null;

            return new Item()
            {
                IdItem = itens[0],
                IdMovimento = itens[1],
                IdPrevisto = itens[2],
                Descricao = itens[3],
                CriadoPor = itens[4],
                CriadoEm = itens[5],
                ModificadoPor = itens[6],
                ModificadoEm = itens[7]
            };
        }

        public int GerarNovoId()
        {
            var itens = GetItens();
            return itens.Count() == 0 ? 1 : int.Parse(itens.Max(x => x.IdItem)) + 1;
        }
    }
}

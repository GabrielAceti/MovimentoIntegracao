using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProjetoImplantacaoMovimento
{
    internal class ClienteService
    {
        public void AdicionaCliente(Cliente cliente)
        {
            var fs = new FileService();
            var parseCliente = ParseClienteTxt(cliente);
            fs.WriteFile(parseCliente, MovimentoDefaults.ClientePath);
        }

        public void EditaMovimento(Cliente cliente)
        {
            ExcluiCliente(cliente);
            AdicionaCliente(cliente);
        }


        internal object Clientes => throw new NotImplementedException();

        

        public void ExcluiCliente(Cliente cliente)
        {
            var clientes = GetClientes();
            clientes.RemoveAll(x => x.IdCliente == cliente.IdCliente);

            List<string> data = ParseMovimentosTxt(clientes);

            var fileService = new FileService();
            fileService.WriteAllLines(data, MovimentoDefaults.ClientePath);

        }

        public ClienteService()
        {
            
        }

        public List<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>();

            var fileService = new FileService();
            string[] fileLines = fileService.ReadFile(MovimentoDefaults.ClientePath);

            foreach (string line in fileLines)
            {
                var clienteMapeado = MapearCliente(line.Split('|'));

                clientes.Add(clienteMapeado);
            }
            return clientes;
        }

        public Cliente GetClienteById(string id)
        {
            var fileService = new FileService();

            string fileLine = fileService.ReadFile(MovimentoDefaults.ClientePath)[0];

            return MapearCliente(fileLine.Split('|'));
        }

        internal void EditaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        private string ParseClienteTxt(Cliente cliente)
        {
            return String.Format($@"{cliente.IdCliente}|{cliente.Nome}|{cliente.Telefone}|{cliente.CPF}|{cliente.Rua}|{cliente.Bairro}|{cliente.Número}|{cliente.CEP}|{cliente.Cidade}|{cliente.CriadoPor}|{cliente.CriadoEm}|{cliente.ModificadoPor}|{cliente.ModificadoEm}");
        }

        private List<string> ParseMovimentosTxt(List<Cliente> clientes)
        {
            List<string> data = new List<string>();
            foreach (Cliente cliente in clientes)
            {
                data.Add(String.Format($@"{cliente.Nome}|{cliente.Telefone}|{cliente.CPF}|{cliente.Rua}|{cliente.Bairro}|{cliente.Número}|{cliente.CEP}|{cliente.Cidade}|{cliente.CriadoPor}|{cliente.CriadoEm}|{cliente.ModificadoPor}|{cliente.ModificadoEm}"));
            }
            return data;
        }

        private Cliente MapearCliente(string[] clientes)
        {
            if (string.IsNullOrEmpty(clientes[0]))
                return null;

            return new Cliente()
            {
                IdCliente = clientes[0],
                Nome = clientes[1],
                Telefone = clientes[2],
                CPF = clientes[3],
                Rua = clientes[4],
                Bairro = clientes[5],
                Número = clientes[6],
                CEP = clientes[7],
                Cidade = clientes[8],
                CriadoPor = clientes[9],
                CriadoEm = clientes[10],
                ModificadoPor = clientes[11],
                ModificadoEm = clientes[12]
            };
        }
        public int GerarNovoId()
        {
            var clientes = GetClientes();
            return clientes.Count() == 0 ? 1 : int.Parse(clientes.Max(x => x.IdCliente)) + 1;
        }
    }
}
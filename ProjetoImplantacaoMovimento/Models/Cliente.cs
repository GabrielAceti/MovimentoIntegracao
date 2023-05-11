using System.Collections.Generic;

namespace ProjetoImplantacaoMovimento.Models

{
    public class Cliente
    {
        

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Número { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string ModificadoPor { get; set; }
        public string ModificadoEm { get; set; }
        public string CriadoPor { get; set; }
        public string CriadoEm { get; set; }
        public string IdCliente { get; set; }
    }
}
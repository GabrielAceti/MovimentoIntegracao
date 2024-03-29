﻿using System.Collections.Generic;

namespace ProjetoImplantacaoMovimento.Models
{
    public class Movimento
    {
        public string IdMovimento { get; set; }
        public string NumeroMovimento { get; set; }
        public string Descricao { get; set; }
        public List<ItemMovimento> ItensMovimento { get; set; }
        public string Observacao { get; set; }
        public string CriadoPor { get; set; }
        public string CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public string ModificadoEm { get; set; }
    }
}

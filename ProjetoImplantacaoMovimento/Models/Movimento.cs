using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImplantacaoMovimento.Models
{
    public class Movimento
    {
        public int IdMovimento { get; set; }
        public string NumeroMovimento { get; set; }
        public string Descricao { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime ModificadoEm { get; set; }
    }
}

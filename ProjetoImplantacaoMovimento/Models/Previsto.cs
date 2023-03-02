using System.Collections.Generic;

namespace ProjetoImplantacaoMovimento.Models
{
    public class Previsto
    {
        public string IdPrevisto { get; set; }
        public string Descricao { get; set; }
        public List<Movimento> Movimentos { get; set; }
        public string CriadoPor { get; set; }
        public string CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public string ModificadoEm { get; set; }
    }
}

namespace ProjetoImplantacaoMovimento.Models
{
    public class Item
    {
        public string IdItem { get; set; }
        public string IdMovimento { get; set; }
        public string IdPrevisto { get; set; }
        public string Descricao { get; set; }
        public string CriadoPor { get; set; }
        public string CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public string ModificadoEm { get; set; }
    }
}

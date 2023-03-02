using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormItemCadastro : Form
    {
        private Global.Types.Acao _acao;
        private Item _item;   

        public FormItemCadastro()
        {
            InitializeComponent();
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            var itemService = new ItemService();
            var item = new Item()
            {
                IdItem = string.IsNullOrEmpty(textBoxIDITEM.Text) ? itemService.GerarNovoId().ToString() : textBoxIDITEM.Text,
                Descricao = textBoxDESCRICAO.Text,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };
            
            if(_acao == Global.Types.Acao.Novo)
            {
                item.CriadoPor = Usuario.Nome;
                item.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");

                itemService.AdicionaItem(item);
            }
            else if(_acao == Global.Types.Acao.Editar)
            {
                item.CriadoPor = _item.CriadoPor;
                item.CriadoEm = _item.CriadoEm;

                itemService.EditaItem(item);
            }
            
            this.Close();
        }

        public void Editar(Item item)
        {
            _acao = Global.Types.Acao.Editar;
            _item = item;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = Global.Types.Acao.Novo;
            this.ShowDialog();
        }

        private void FormItemCadastro_Load(object sender, EventArgs e)
        {
            if(_acao == Global.Types.Acao.Editar)
            {
                textBoxDATACADASTRO.Text = _item.CriadoEm;
                textBoxIDITEM.Text = _item.IdItem;
                textBoxDESCRICAO.Text = _item.Descricao;
            }
            else if(_acao == Global.Types.Acao.Novo)
            {
                textBoxDATACADASTRO.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }
    }
}

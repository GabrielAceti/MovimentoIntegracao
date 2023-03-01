using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormMovimentoCadastro : Form
    {
        private Global.Types.Acao _acao;
        private Movimento _movimento;   

        public FormMovimentoCadastro()
        {
            InitializeComponent();
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            var movimentoService = new MovimentoService();
            var movimento = new Movimento()
            {
                IdMovimento = string.IsNullOrEmpty(textBoxIDMOVIMENTO.Text) ? movimentoService.GerarNovoId().ToString() : textBoxIDMOVIMENTO.Text,
                NumeroMovimento = maskedTextBoxNUMEROMOVIMENTO.Text,
                Descricao = textBoxDESCRICAO.Text,
                Observacao = textBoxOBSERVACAO.Text,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };
            
            if(_acao == Global.Types.Acao.Novo)
            {
                movimento.CriadoPor = Usuario.Nome;
                movimento.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");

                movimentoService.AdicionaMovimento(movimento);
            }
            else if(_acao == Global.Types.Acao.Editar)
            {
                movimento.CriadoPor = _movimento.CriadoPor;
                movimento.CriadoEm = _movimento.CriadoEm;

                movimentoService.EditaMovimento(movimento);
            }
            
            this.Close();
        }

        public void Editar(Movimento movimento)
        {
            _acao = Global.Types.Acao.Editar;
            _movimento = movimento;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = Global.Types.Acao.Novo;
            this.ShowDialog();
        }

        private void FormMovimentoCadastro_Load(object sender, EventArgs e)
        {
            if(_acao == Global.Types.Acao.Editar)
            {
                textBoxIDMOVIMENTO.Text = _movimento.IdMovimento;
                maskedTextBoxNUMEROMOVIMENTO.Text = _movimento.NumeroMovimento;
                textBoxDESCRICAO.Text = _movimento.Descricao;
                textBoxOBSERVACAO.Text = _movimento.Observacao;
            }
        }
    }
}

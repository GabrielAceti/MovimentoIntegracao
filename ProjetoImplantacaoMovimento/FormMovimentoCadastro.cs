using ProjetoImplantacaoMovimento.Enums;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormMovimentoCadastro : Form
    {
        private AcaoEnum _acao;
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
            var movimento = new Movimento()
            {
                IdMovimento = string.IsNullOrEmpty(textBoxIDMOVIMENTO.Text) ? string.Empty : textBoxIDMOVIMENTO.Text,
                NumeroMovimento = maskedTextBoxNUMEROMOVIMENTO.Text,
                Descricao = textBoxDESCRICAO.Text,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };
            
            if(_acao == AcaoEnum.Novo)
            {
                movimento.CriadoPor = Usuario.Nome;
                movimento.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");
                new MovimentoService().AdicionaMovimento(movimento);
            }
            else if(_acao == AcaoEnum.Editar)
            {
                new MovimentoService().EditaMovimento(movimento);
            }
            
            this.Close();
        }

        public void Editar(Movimento movimento)
        {
            _acao = AcaoEnum.Editar;
            _movimento = movimento;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = AcaoEnum.Novo;
            this.ShowDialog();
        }

        private void FormMovimentoCadastro_Load(object sender, EventArgs e)
        {
            if(_acao == AcaoEnum.Editar)
            {
                textBoxIDMOVIMENTO.Text = _movimento.IdMovimento;
                maskedTextBoxNUMEROMOVIMENTO.Text = _movimento.NumeroMovimento;
                textBoxDESCRICAO.Text = _movimento.Descricao;
            }
        }
    }
}

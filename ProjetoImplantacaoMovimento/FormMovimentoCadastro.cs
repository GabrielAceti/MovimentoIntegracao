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
                NumeroMovimento = maskedTextBoxNUMEROMOVIMENTO.Text,
                Descricao = textBoxDESCRICAO.Text,
                CriadoPor = Usuario.Nome,
                CriadoEm = DateTime.Now.ToString("yyyy-MM-dd"),
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };
            
            new MovimentoService().AdicionaMovimento(movimento);
            this.Close();
        }

        public void Editar(Movimento movimento)
        {
            _acao = AcaoEnum.Editar;
            _movimento = movimento;

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

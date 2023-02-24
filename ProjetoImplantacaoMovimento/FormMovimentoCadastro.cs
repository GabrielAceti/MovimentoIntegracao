using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormMovimentoCadastro : Form
    {
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

            var movimentoService = new MovimentoService();
            movimentoService.AdicionaMovimento(movimento);
            this.Close();
        }
    }
}

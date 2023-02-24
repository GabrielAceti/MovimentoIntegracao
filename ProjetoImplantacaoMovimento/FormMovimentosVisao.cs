using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormMovimentosVisao : Form
    {
        public FormMovimentosVisao()
        {
            InitializeComponent();
        }

        private void toolStripButtonNOVO_Click(object sender, EventArgs e)
        {
            FormMovimentoCadastro frm = new FormMovimentoCadastro();
            frm.ShowDialog();
            AtualizaGrid();
        }

        private void FormMovimentosVisao_Load(object sender, EventArgs e)
        {
            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
            var movimentoService = new MovimentoService();
            var movimentos = movimentoService.GetMovimentos();

            gridControlMOVIMENTOS.DataSource = movimentos;
        }
    }
}

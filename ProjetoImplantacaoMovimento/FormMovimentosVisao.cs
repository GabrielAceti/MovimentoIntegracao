using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
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
            new FormMovimentoCadastro().Novo();
            AtualizaGrid();
        }

        private void FormMovimentosVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            var movimentos = new MovimentoService().GetMovimentos();
            gridControlMOVIMENTOS.DataSource = movimentos;

            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
        }

        private void toolStripButtonEDITAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Movimento movimento = (Movimento)gridView1.GetRow(index);

            new FormMovimentoCadastro().Editar(movimento);
            AtualizaGrid();
        }

        private void toolStripButtonEXCLUIR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Movimento movimento = (Movimento)gridView1.GetRow(index);

            if (DialogResult.Yes == MessageBox.Show($"Deseja realmente excluir o movimento '{movimento.IdMovimento}'?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var movimentoService = new MovimentoService();
                movimentoService.ExcluiMovimento(movimento.IdMovimento);
                AtualizaGrid();
            }            
        }
    }
}

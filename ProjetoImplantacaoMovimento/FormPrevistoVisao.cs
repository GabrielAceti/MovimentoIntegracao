using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPrevistoVisao : Form
    {
        public FormPrevistoVisao()
        {
            InitializeComponent();
        }

        private void toolStripButtonNOVO_Click(object sender, EventArgs e)
        {
            new FormPrevistoCadastro().Novo();
            AtualizaGrid();
        }

        private void FormPrevistosVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            var movimentos = new PrevistoService().GetPrevistos();
            gridControlPREVISTO.DataSource = movimentos;

            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
        }

        private void toolStripButtonEDITAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Previsto previsto = (Previsto)gridView1.GetRow(index);

            new FormPrevistoCadastro().Editar(previsto);
            AtualizaGrid();
        }

        private void toolStripButtonEXCLUIR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Previsto previsto = (Previsto)gridView1.GetRow(index);

            if (DialogResult.Yes == MessageBox.Show($"Deseja realmente excluir o previsto '{previsto.IdPrevisto}'?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var previstoService = new PrevistoService();
                previstoService.ExcluiPrevisto(previsto.IdPrevisto);
                AtualizaGrid();
            }
        }
    }
}

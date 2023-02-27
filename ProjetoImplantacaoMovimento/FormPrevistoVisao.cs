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
            FormPrevistoCadastro frm = new FormPrevistoCadastro();
            frm.ShowDialog();
            AtualizaGrid();
        }

        private void FormPrevistosVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
            var movimentos = new PrevistoService().GetPrevistos();

            gridControlPREVISTO.DataSource = movimentos;
        }

        private void toolStripButtonEDITAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Previsto previsto = (Previsto)gridView1.GetRow(index);

            new FormPrevistoCadastro().Editar(previsto);
        }
    }
}

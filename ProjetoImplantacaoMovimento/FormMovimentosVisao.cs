using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Enums;
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
            FormMovimentoCadastro frm = new FormMovimentoCadastro();
            frm.ShowDialog();
            AtualizaGrid();
        }

        private void FormMovimentosVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
            var movimentos = new MovimentoService().GetMovimentos();

            gridControlMOVIMENTOS.DataSource = movimentos;
        }

        private void toolStripButtonEDITAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Movimento movimento = (Movimento)gridView1.GetRow(index);

            new FormMovimentoCadastro().Editar(movimento);
        }
    }
}

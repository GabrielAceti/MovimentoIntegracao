using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormItensVisao : Form
    {
        public FormItensVisao()
        {
            InitializeComponent();
        }

        private void toolStripButtonNOVO_Click(object sender, EventArgs e)
        {
            new FormItemCadastro().Novo();
            AtualizaGrid();
        }

        private void FormItensVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            var itens = new ItemService().GetItens();
            gridControlITENS.DataSource = itens;

            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
        }

        private void toolStripButtonEDITAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Item item = (Item)gridView1.GetRow(index);

            new FormItemCadastro().Editar(item);
            AtualizaGrid();
        }

        private void toolStripButtonEXCLUIR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Item item = (Item)gridView1.GetRow(index);

            if (DialogResult.Yes == MessageBox.Show($"Deseja realmente excluir o item '{item.IdItem}'?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var itemService = new ItemService();
                itemService.ExcluiItem(item.IdItem);
                AtualizaGrid();
            }            
        }
    }
}

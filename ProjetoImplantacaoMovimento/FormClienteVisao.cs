using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetoImplantacaoMovimento
{
    public partial class FormClienteVisao : Form
    {
        public FormClienteVisao()
        {
            InitializeComponent();
        }

        private void toolStripButtonNOVO_Click(object sender, EventArgs e)
        {
            new FormClienteCadastro().Novo();
            AtualizaGrid();
        }

        private void FormClienteVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            var clientes = new ClienteService().GetClientes();
            gridControlMOVIMENTOS.DataSource = clientes;

            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
        }

        private void toolStripButtonEDITAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Cliente cliente = (Cliente)gridView1.GetRow(index);
           
            new FormClienteCadastro().Editar(cliente);
            AtualizaGrid();
        }

        private void toolStripButtonEXCLUIR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Cliente cliente = (Cliente)gridView1.GetRow(index);

            if (DialogResult.Yes == MessageBox.Show($"Deseja realmente excluir o movimento '{cliente.IdCliente}'?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var clienteService = new ClienteService();
                clienteService.ExcluiCliente(cliente);
                AtualizaGrid();
            }
        }
    }
}

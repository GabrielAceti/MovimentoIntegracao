using ProjetoImplantacaoMovimento.Services;
using ProjetoImplantacaoMovimento.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoImplantacaoMovimento.Constant;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormSelecionaItemVisao : Form
    {
        public Item Item { get; set; }
        public Global.Types.Acao Acao { get; set; }

        public FormSelecionaItemVisao()
        {
            InitializeComponent();
        }

        private void FormSelecionaItemVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            gridControlITENSMOVIMENTO.DataSource = new ItemService().GetItens();
            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            Acao = Global.Types.Acao.Cancelar;
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Item = (Item)gridView1.GetRow(index);

            this.Close();
        }
    }
}

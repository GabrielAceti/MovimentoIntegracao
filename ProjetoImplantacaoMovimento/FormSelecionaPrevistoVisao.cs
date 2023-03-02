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

namespace ProjetoImplantacaoMovimento
{
    public partial class FormSelecionaPrevistoVisao : Form
    {
        public Previsto Previsto { get; set; }

        public FormSelecionaPrevistoVisao()
        {
            InitializeComponent();
        }

        private void FormSelecionaPrevistoVisao_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            gridControlPREVISTOSMOVIMENTO.DataSource = new PrevistoService().GetPrevistos();
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            Previsto = (Previsto)gridView1.GetRow(index);

            this.Close();
        }
    }
}

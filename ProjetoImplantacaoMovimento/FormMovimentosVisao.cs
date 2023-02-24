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
        }
    }
}

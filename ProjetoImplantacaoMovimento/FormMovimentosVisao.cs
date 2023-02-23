using ProjetoImplantacaoMovimento.Data;
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
        private AppDbContext _context;
        public FormMovimentosVisao(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void toolStripButtonNOVO_Click(object sender, EventArgs e)
        {
            FormMovimentoCadastro frm = new FormMovimentoCadastro(_context);
            frm.ShowDialog();
        }
    }
}

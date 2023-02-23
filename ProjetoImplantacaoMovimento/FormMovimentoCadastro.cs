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
    public partial class FormMovimentoCadastro : Form
    {
        private AppDbContext _context;

        public FormMovimentoCadastro(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {

        }
    }
}

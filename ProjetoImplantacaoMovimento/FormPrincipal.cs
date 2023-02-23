using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ProjetoImplantacaoMovimento.Data;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private AppDbContext _context;
        public FormPrincipal(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormMovimentosVisao frm = new FormMovimentosVisao(_context);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
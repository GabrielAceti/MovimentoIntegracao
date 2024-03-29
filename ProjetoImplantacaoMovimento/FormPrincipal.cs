﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void barButtonItemMOVIMENTOS_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormMovimentosVisao frm = new FormMovimentosVisao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemPREVISTO_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormPrevistoVisao frm = new FormPrevistoVisao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormItensVisao frm = new FormItensVisao();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
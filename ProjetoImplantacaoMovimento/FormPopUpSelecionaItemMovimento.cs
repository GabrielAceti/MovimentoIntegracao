using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoImplantacaoMovimento.Models;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPopUpSelecionaItemMovimento : Form
    {
        public Item Item { get; set; }
        public Previsto Previsto { get; set; }
        public string Observacao { get; set; }
        public Global.Types.Acao Acao { get; set; }

        public FormPopUpSelecionaItemMovimento()
        {
            InitializeComponent();
        }

        private void simpleButtonSelecionaItem_Click(object sender, EventArgs e)
        {
            FormSelecionaItemVisao frm = new FormSelecionaItemVisao();
            frm.ShowDialog();

            Item = frm.Item;
            textBoxIDITEM.Text = Item.IdItem;
            textBoxDESCRICAOITEM.Text = Item.Descricao;
        }

        private void simpleButtonSelecionaPrevisto_Click(object sender, EventArgs e)
        {
            FormSelecionaPrevistoVisao frm = new FormSelecionaPrevistoVisao();
            frm.ShowDialog();

            Previsto = frm.Previsto;
            textBoxIDPREVISTO.Text = Previsto.IdPrevisto;
            textBoxDESCRICAOPREVISTO.Text = Previsto.Descricao;
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            if (ValidarSalvar())
            {
                Observacao = textBoxOBSERVACAO.Text;
                this.Close();
            }
        }

        private bool ValidarSalvar()
        {
            if (string.IsNullOrEmpty(textBoxIDITEM.Text))
            {
                MessageBox.Show("Selecione um Item", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxIDPREVISTO.Text))
            {
                MessageBox.Show("Selecione um Previsto", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            Acao = Global.Types.Acao.Cancelar;
            this.Close();
        }
    }
}

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
using ProjetoImplantacaoMovimento.Services;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPopUpSelecionaItemMovimento : Form
    {
        public Item Item { get; set; }
        public Previsto Previsto { get; set; }
        public string Observacao { get; set; }
        public Global.Types.Acao Acao { get; set; }
        public ItemMovimento ItemMovimento { get; set; }

        public FormPopUpSelecionaItemMovimento()
        {
            InitializeComponent();
        }

        private void simpleButtonSelecionaItem_Click(object sender, EventArgs e)
        {
            FormSelecionaItemVisao frm = new FormSelecionaItemVisao();
            frm.ShowDialog();

            if(frm.Acao != Global.Types.Acao.Cancelar)
            {
                Item = frm.Item;
                textBoxIDITEM.Text = Item.IdItem;
                textBoxDESCRICAOITEM.Text = Item.Descricao;
            }            
        }

        private void simpleButtonSelecionaPrevisto_Click(object sender, EventArgs e)
        {
            FormSelecionaPrevistoVisao frm = new FormSelecionaPrevistoVisao();
            frm.ShowDialog();

            if (frm.Acao != Global.Types.Acao.Cancelar)
            {
                Previsto = frm.Previsto;
                textBoxIDPREVISTO.Text = Previsto.IdPrevisto;
                textBoxDESCRICAOPREVISTO.Text = Previsto.Descricao;
            }
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            if (ValidarSalvar())
            {
                var itemMovimento = new ItemMovimento
                {                    
                    IdItem = Item.IdItem,
                    IdPrevisto = Previsto.IdPrevisto,
                    Observacao = textBoxOBSERVACAO.Text,
                    ModificadoPor = Usuario.Nome,
                    ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
                };

                if (Acao == Global.Types.Acao.Novo)
                {
                    itemMovimento.IdItemMovimento = new ItemMovimentoService().GerarNovoId().ToString(); 
                    itemMovimento.CriadoPor = Usuario.Nome;
                    itemMovimento.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");
                }

                if (Acao == Global.Types.Acao.Editar)
                {
                    itemMovimento.IdItemMovimento = ItemMovimento.IdItemMovimento;
                    itemMovimento.CriadoPor = ItemMovimento.CriadoPor;
                    itemMovimento.CriadoEm = ItemMovimento.CriadoEm;
                }
                
                ItemMovimento = itemMovimento;

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

        public void Editar(ItemMovimento itemMovimento)
        {
            Acao = Global.Types.Acao.Editar;
            ItemMovimento = itemMovimento;

            this.ShowDialog();
        }

        public void Novo()
        {
            Acao = Global.Types.Acao.Novo;
            this.ShowDialog();
        }

        private void FormPopUpSelecionaItemMovimento_Load(object sender, EventArgs e)
        {
            if(Acao == Global.Types.Acao.Editar)
            {
                Item = new ItemService().GetItemById(ItemMovimento.IdItem);
                textBoxIDITEM.Text = ItemMovimento.IdItem;
                textBoxDESCRICAOITEM.Text = Item.Descricao;

                Previsto = new PrevistoService().GetPrevistoById(ItemMovimento.IdPrevisto);
                textBoxIDPREVISTO.Text = ItemMovimento.IdPrevisto;
                textBoxDESCRICAOPREVISTO.Text = Previsto.Descricao;

                textBoxOBSERVACAO.Text = ItemMovimento.Observacao;
            }
        }
    }
}

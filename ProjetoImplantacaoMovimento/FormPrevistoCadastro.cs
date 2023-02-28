using DevExpress.XtraGrid;
using ProjetoImplantacaoMovimento.Enums;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPrevistoCadastro : Form
    {
        private AcaoEnum _acao;
        private Previsto _previsto;

        public FormPrevistoCadastro ()
        {
            InitializeComponent();
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            var previsto = new Previsto()
            {
                IdPrevisto = string.IsNullOrEmpty(textBoxIDPREVISTO.Text) ? string.Empty : textBoxIDPREVISTO.Text,
                Descricao = textBoxDESCRICAO.Text,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };

            if (_acao == AcaoEnum.Novo)
            {
                previsto.CriadoPor = Usuario.Nome;
                previsto.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");
                new PrevistoService().AdicionaPrevisto(previsto);
            }
            else if (_acao == AcaoEnum.Editar)
            {
                new PrevistoService().EditaPrevisto(previsto);
            }

            this.Close();
        }

        private void FormPrevistoCadastro_Load(object sender, EventArgs e)
        {
            var movimentos = new MovimentoService().GetMovimentos();

            int count = 1;
            foreach(Movimento movimento in movimentos)
            {
                GridControl gridControl = new GridControl();
                tabControl1.TabPages.Add(movimento.Descricao);

                gridControl.Width = tabControl1.TabPages[count].Width;
                gridControl.Height = tabControl1.TabPages[count].Height;

                tabControl1.TabPages[count].Controls.Add(gridControl);
                count++;
            }

            if(_acao == AcaoEnum.Editar)
            {
                textBoxDATACADASTRO.Text = _previsto.CriadoEm;
                textBoxIDPREVISTO.Text = _previsto.IdPrevisto;
                textBoxDESCRICAO.Text = _previsto.Descricao;
            }
        }

        public void Editar(Previsto previsto)
        {
            _acao = AcaoEnum.Editar;
            _previsto = previsto;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = AcaoEnum.Novo;
            this.ShowDialog();
        }
    }
}

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormPrevistoCadastro : Form
    {
        private Global.Types.Acao _acao;
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
            var previstoService = new PrevistoService();
            var previsto = new Previsto()
            {
                IdPrevisto = string.IsNullOrEmpty(textBoxIDPREVISTO.Text) ? previstoService.GerarNovoId().ToString() : textBoxIDPREVISTO.Text,
                Descricao = textBoxDESCRICAO.Text,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };

            if (_acao == Global.Types.Acao.Novo)
            {
                previsto.CriadoPor = Usuario.Nome;
                previsto.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");

                previstoService.AdicionaPrevisto(previsto);
            }
            else if (_acao == Global.Types.Acao.Editar)
            {
                previsto.CriadoPor = _previsto.CriadoPor;
                previsto.CriadoEm = _previsto.CriadoEm;

                previstoService.EditaPrevisto(previsto);
            }

            this.Close();
        }

        private void FormPrevistoCadastro_Load(object sender, EventArgs e)
        {
            var movimentoService = new MovimentoService();
            var movimentos = movimentoService.GetMovimentos();

            int count = 1;
            foreach(Movimento movimento in movimentos)
            {
                GridControl gridControl = new GridControl();
                GridView gridView = new GridView();

                tabControl1.TabPages.Add(movimento.Descricao);

                gridControl.Width = tabControl1.TabPages[count].Width;
                gridControl.Height = tabControl1.TabPages[count].Height;

                gridControl.MainView = gridView;
                gridControl.DataSource = movimentoService.GetMovimentosById(movimento.IdMovimento);

                tabControl1.TabPages[count].Controls.Add(gridControl);
                gridView = GridViewDefaults.GridViewConfigurationDefaults(gridView);

                count++;
            }

            if(_acao == Global.Types.Acao.Editar)
            {
                textBoxDATACADASTRO.Text = _previsto.CriadoEm;
                textBoxIDPREVISTO.Text = _previsto.IdPrevisto;
                textBoxDESCRICAO.Text = _previsto.Descricao;
            }
        }

        public void Editar(Previsto previsto)
        {
            _acao = Global.Types.Acao.Editar;
            _previsto = previsto;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = Global.Types.Acao.Novo;
            this.ShowDialog();
        }
    }
}

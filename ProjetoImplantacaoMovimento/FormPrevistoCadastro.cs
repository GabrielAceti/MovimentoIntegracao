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
                Descricao = textBoxDESCRICAO.Text,
                CriadoPor = Usuario.Nome,
                CriadoEm = DateTime.Now.ToString("yyyy-MM-dd"),
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };
            
            new PrevistoService().AdicionaPrevisto(previsto);
            this.Close();
        }

        private void FormPrevistoCadastro_Load(object sender, EventArgs e)
        {
            var movimentos = new MovimentoService().GetMovimentos();

            foreach(Movimento movimento in movimentos)
            {
                tabControl1.TabPages.Add(movimento.Descricao); 
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
    }
}

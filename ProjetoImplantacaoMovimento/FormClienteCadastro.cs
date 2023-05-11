using ProjetoImplantacaoMovimento.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoImplantacaoMovimento.Services;
using ProjetoImplantacaoMovimento.Constant;


namespace ProjetoImplantacaoMovimento
{
    public partial class FormClienteCadastro : Form
    {
        private Global.Types.Acao _acao;
        private FormClienteCadastro _cliente;
        private FormClienteCadastro cliente;
        private object textBoxDATACADASTRO;
        

        public string CriadoPor { get; private set; }
        public string CriadoEm { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public string RUA { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Cidade { get; private set; }
        public string Nome { get; private set; }

        public FormClienteCadastro()
        {
            InitializeComponent();
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            var clienteService = new ClienteService();
            var cliente = new Cliente()
            {
                IdCliente = string.IsNullOrEmpty(TextBoxID.Text) ? clienteService.GerarNovoId().ToString() : TextBoxID.Text,
                Nome = textBoxNOME.Text,
                Telefone = maskedTextBoxTELEFONE.Text,
                CPF = maskedTextBoxCPF.Text,
                CEP = maskedTextBoxCPF.Text,
                Rua = textBoxRUA.Text,
                Bairro = textBoxBAIRRO.Text,
                Número = textBoxNUMERO.Text,
                Cidade = textBoxCIDADE.Text,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")

            };

            if (_acao == Global.Types.Acao.Novo)
            {
                cliente.CriadoPor = Usuario.Nome;
                cliente.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");
                clienteService.AdicionaCliente(cliente);
            }
            else if (_acao == Global.Types.Acao.Editar)
            {
                cliente.CriadoPor = _cliente.CriadoPor;
                cliente.CriadoEm = _cliente.CriadoEm;
                clienteService.EditaCliente(cliente);
            }

            this.Close();
        }

        public void Editar(Cliente movimento)
        {
            _acao = Global.Types.Acao.Editar;
            _cliente = cliente;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = Global.Types.Acao.Novo;
            this.ShowDialog();
        }


        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            if (_acao == Global.Types.Acao.Editar) {
                
                textBoxNOME.Text = _cliente.Nome;
                maskedTextBoxTELEFONE.Text = _cliente.Telefone;
                maskedTextBoxCPF.Text = _cliente.CPF;
                textBoxRUA.Text = _cliente.RUA;
                textBoxBAIRRO.Text = _cliente.Bairro;
                textBoxNUMERO.Text = _cliente.Numero;
                textBoxCIDADE.Text = _cliente.Cidade;
            }
        }
    }








}

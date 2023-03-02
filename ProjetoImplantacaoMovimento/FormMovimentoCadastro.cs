﻿using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoImplantacaoMovimento
{
    public partial class FormMovimentoCadastro : Form
    {
        private Global.Types.Acao _acao;
        private Movimento _movimento;
        private List<ItemMovimento> _itensMovimento = new List<ItemMovimento>();

        public FormMovimentoCadastro()
        {
            InitializeComponent();
        }

        private void simpleButtonCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonSALVAR_Click(object sender, EventArgs e)
        {
            var movimentoService = new MovimentoService();
            var movimento = new Movimento()
            {
                IdMovimento = string.IsNullOrEmpty(textBoxIDMOVIMENTO.Text) ? movimentoService.GerarNovoId().ToString() : textBoxIDMOVIMENTO.Text,
                NumeroMovimento = maskedTextBoxNUMEROMOVIMENTO.Text,
                Descricao = textBoxDESCRICAO.Text,
                Observacao = textBoxOBSERVACAO.Text,
                ItensMovimento = _itensMovimento,
                ModificadoPor = Usuario.Nome,
                ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
            };

            movimento.ItensMovimento.ForEach(x => x.IdMovimento = movimento.IdMovimento);
            
            if(_acao == Global.Types.Acao.Novo)
            {
                movimento.CriadoPor = Usuario.Nome;
                movimento.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");

                movimentoService.AdicionaMovimento(movimento);
            }
            else if(_acao == Global.Types.Acao.Editar)
            {
                movimento.CriadoPor = _movimento.CriadoPor;
                movimento.CriadoEm = _movimento.CriadoEm;

                movimentoService.EditaMovimento(movimento);
            }
            
            this.Close();
        }

        public void Editar(Movimento movimento)
        {
            _acao = Global.Types.Acao.Editar;
            _movimento = movimento;

            this.ShowDialog();
        }

        public void Novo()
        {
            _acao = Global.Types.Acao.Novo;
            this.ShowDialog();
        }

        private void FormMovimentoCadastro_Load(object sender, EventArgs e)
        {
            if(_acao == Global.Types.Acao.Editar)
            {
                textBoxDATACADASTRO.Text = _movimento.CriadoEm;
                textBoxIDMOVIMENTO.Text = _movimento.IdMovimento;
                maskedTextBoxNUMEROMOVIMENTO.Text = _movimento.NumeroMovimento;
                textBoxDESCRICAO.Text = _movimento.Descricao;
                textBoxOBSERVACAO.Text = _movimento.Observacao;
                _itensMovimento = _movimento.ItensMovimento;
            }
            else if(_acao == Global.Types.Acao.Novo)
            {
                textBoxDATACADASTRO.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }

            AtualizaGridItens();
        }

        private void toolStripButtonNOVO_Click(object sender, EventArgs e)
        {
            FormPopUpSelecionaItemMovimento frm = new FormPopUpSelecionaItemMovimento();
            frm.ShowDialog();

            if(frm.Acao != Global.Types.Acao.Cancelar)
            {
                ItemMovimento itemMovimento = new ItemMovimento
                {
                    IdItemMovimento = new ItemMovimentoService().GerarNovoId().ToString(),
                    IdItem = frm.Item.IdItem,
                    IdPrevisto = frm.Previsto.IdPrevisto,
                    Observacao = frm.Observacao,
                    ModificadoPor = Usuario.Nome,
                    ModificadoEm = DateTime.Now.ToString("yyyy-MM-dd")
                };

                if (_acao == Global.Types.Acao.Novo)
                {
                    itemMovimento.CriadoPor = Usuario.Nome;
                    itemMovimento.CriadoEm = DateTime.Now.ToString("yyyy-MM-dd");
                }

                if (_acao == Global.Types.Acao.Editar)
                {
                    itemMovimento.CriadoPor = _movimento.CriadoPor;
                    itemMovimento.CriadoEm = _movimento.CriadoEm;
                }

                _itensMovimento.Add(itemMovimento);
            }

            AtualizaGridItens();                
        }

        private void AtualizaGridItens()
        {
            if(_acao == Global.Types.Acao.Novo)
                gridControlITENSMOVIMENTO.DataSource = _itensMovimento;
            if (_acao == Global.Types.Acao.Editar)
                gridControlITENSMOVIMENTO.DataSource = _movimento.ItensMovimento;

            gridView1 = GridViewDefaults.GridViewConfigurationDefaults(gridView1);
        }
    }
}

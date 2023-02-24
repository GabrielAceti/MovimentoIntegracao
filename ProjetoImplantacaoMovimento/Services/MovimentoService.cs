using ProjetoImplantacaoMovimento.Constant;
using ProjetoImplantacaoMovimento.Models;
using ProjetoImplantacaoMovimento.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImplantacaoMovimento.Services
{
    public class MovimentoService
    {
        public void AdicionaMovimento(Movimento movimento)
        {
            var fs = new FileService(MovimentoDefaults.MovimentoPath);
            fs.WriteFile(ParseMovimentoTxt(movimento));
        }

        private string ParseMovimentoTxt(Movimento movimento)
        {
            return String.Format($@"{movimento.IdMovimento}|{movimento.NumeroMovimento}|{movimento.Descricao}|{movimento.CriadoPor}|{movimento.CriadoEm.ToString("yyyy-MM-dd")}|{movimento.ModificadoPor}|{movimento.ModificadoEm.ToString("yyyy-MM-dd")}");
        }
    }
}

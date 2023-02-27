using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImplantacaoMovimento.Constant
{
    public static class MovimentoDefaults
    {
        public const string MovimentoPath = "../../Data/Movimentos.txt";
        public const string PrevistoPath = "../../Data/Previstos.txt";
    }

    public static class GridViewDefaults
    {
        public static GridView GridViewConfigurationDefaults(GridView gridView)
        {
            // Grid somente leitura
            gridView.OptionsBehavior.Editable = false;

            // Grid com seleção de multiplos registros
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

            // Grid com scroll horizontal
            gridView.OptionsView.ColumnAutoWidth = false;

            // Grid com auto ajuste do melhor tamanho das colunas
            gridView.BestFitMaxRowCount = 800;
            gridView.BestFitColumns();

            // Grid mostrar coluna de filtro
            gridView.OptionsView.ShowAutoFilterRow = true;

            return gridView;
        }
    }
}

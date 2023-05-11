using DevExpress.XtraGrid.Views.Grid;

namespace ProjetoImplantacaoMovimento.Constant
{
    public static class MovimentoDefaults
    {
        public const string MovimentoPath = "../../Data/Movimentos.txt";
        public const string PrevistoPath = "../../Data/Previstos.txt";
        public const string ItemPath = "../../Data/Itens.txt";
        public const string ItemMovimentoPath = "../../Data/ItensMovimento.txt";
        public const string ClientePath = "../../Data/Clientes.txt";
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

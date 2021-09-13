using DioSeriesApiRest.Enum;

namespace DioSeriesApiRest.InputSerieModel
{
    public class InputSerieModel
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }
    }
}
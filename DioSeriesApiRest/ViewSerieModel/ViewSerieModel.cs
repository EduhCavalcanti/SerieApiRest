using DioSeriesApiRest.Enum;

namespace DioSeriesApiRest.ViewSerieModel
{
    public class ViewSerieModel
    {
        public int Id {get;set;}
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }
    }
}
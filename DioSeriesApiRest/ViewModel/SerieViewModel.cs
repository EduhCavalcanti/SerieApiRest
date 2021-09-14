using DioSeriesApiRest.Enum;

namespace DioSeriesApiRest.ViewModel
{
    public class SerieViewModel
    {
        public int Id {get;set;}
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }
    }
}
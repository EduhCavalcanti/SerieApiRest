using DioSeriesApiRest.Enum;

namespace DioSeriesApiRest.InputModel
{
    public class SerieInputModel
    {
        
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public Genero Genero { get; set; }
        
    }
}
using DioSeriesApiRest.Enum;

namespace DioSeriesApiRest.InputModel
{
    public class SerieInputModel
    {
        
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        
    }
}
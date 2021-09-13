using DioSeriesApiRest.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Entities
{
    public class SeriesModel
    {
        public int Id {get;set;}
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
    }
}

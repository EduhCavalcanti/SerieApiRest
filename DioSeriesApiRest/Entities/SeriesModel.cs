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
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        
        //Retornar Excluido
        public bool RetornarExcluido(){
            return Excluido;
        }
    }

}

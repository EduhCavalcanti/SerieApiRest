using DioSeriesApiRest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Services
{
    public interface ISeriesService
    {
        //Lista as Series 
        List<SeriesModel> Listar();
        //Criar Serie
        SeriesModel Inserir(SeriesModel serie);
        //Obter Serie por Id
        SeriesModel ObterById(int id);
        //Editar Serie
        void Editar(int id, SeriesModel serie);
        //Excuir Serie
        void Excluir(int id);

    }
}

using DioSeriesApiRest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Repositorie
{
    public interface ISerieRepositorio
    {
        //Lista as Series 
        Task<List<SeriesModel>> Listar();
        //Criar Serie
        Task Inserir(SeriesModel serie);
        //Obter Serie por Id
        Task<SeriesModel> ObterById(int id);
        //Editar Serie
        Task Editar(int id, SeriesModel serie);
        //Excuir Serie
        Task Excluir(int id);

    }
}

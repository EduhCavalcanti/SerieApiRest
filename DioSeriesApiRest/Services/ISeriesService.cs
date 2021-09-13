using DioSeriesApiRest.Entities;
using DioSeriesApiRest.InputModel;
using DioSeriesApiRest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Services
{
    public interface ISeriesService
    {
        //Lista as Series 
        Task<List<SerieViewModel>> Listar();
        //Criar Serie
        Task Inserir(SerieInputModel serie);
        //Obter Serie por Id
        Task<SerieViewModel> ObterById(int id);
        //Editar Serie
        Task Editar(int id, SerieInputModel serie);
        //Excuir Serie
        Task Excluir(int id);

    }
}

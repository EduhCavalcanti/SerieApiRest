using DioSeriesApiRest.Entities;
using DioSeriesApiRest.InputModel;
using DioSeriesApiRest.Repositorie;
using DioSeriesApiRest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Services
{
    public class SerieService : ISeriesService
    {
        private readonly ISerieRepositorio _ISerierepositorio;

        public Task Editar(int id, SerieInputModel serie)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(SerieInputModel serie)
        {
            throw new NotImplementedException();
        }

        public Task<List<SerieViewModel>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<SerieViewModel> ObterById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

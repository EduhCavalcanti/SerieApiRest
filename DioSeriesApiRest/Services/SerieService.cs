using DioSeriesApiRest.Entities;
using DioSeriesApiRest.Repositorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Services
{
    public class SerieService : ISeriesService
    {
        private readonly ISerieRepositorio _ISerierepositorio;

        public SerieService(ISerieRepositorio iSerierepositorio)
        {
            _ISerierepositorio = iSerierepositorio;
        }

        public Task Editar(int id, SeriesModel serie)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(SeriesModel serie)
        {
            throw new NotImplementedException();

        }

        public Task<List<SeriesModel>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<SeriesModel> ObterById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

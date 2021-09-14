using DioSeriesApiRest.Context;
using DioSeriesApiRest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Repositorie
{
    public class SerieRepositorio : ISerieRepositorio
    {
        private readonly SerieContext _Context;

        public Task Editar(SeriesModel serie)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(SeriesModel serie)
        {
            try {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

using DioSeriesApiRest.Context;
using DioSeriesApiRest.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Repositorie
{
    public class SerieRepositorio : ISerieRepositorio
    {
        private readonly SerieContext _Context;

        public async Task Editar(SeriesModel serie)
        {
            throw new Exception();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(SeriesModel serie)
        {
            try {
                await _Context.AddAsync(serie);
                await _Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<SeriesModel>> Listar()
        {
            return await _Context.Serie.ToListAsync();

        }
        public async Task<SeriesModel> ObterById(int id)
        {
            throw new Exception();
        }
    }
}

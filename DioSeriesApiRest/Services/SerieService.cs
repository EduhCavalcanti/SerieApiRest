using DioSeriesApiRest.Entities;
using DioSeriesApiRest.Repositorie;
using DioSeriesApiRest.ViewModel;
using DioSeriesApiRest.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeriesApiRest.Services
{
    public class SerieService : ISeriesService
    {
        private readonly ISerieRepositorio _ISerierepositorio;

        public async Task Editar(int id, SerieInputModel serie)
        {
            var serieId = await _ISerierepositorio.ObterById(id);
            //Verifica se existe serie
            if(serieId == null){
                throw new Exception();
            }

            var insertSerie = new SeriesModel{
                Id= serieId.Id,
                Titulo=serieId.Titulo,
                Descricao=serieId.Descricao,
                Ano=serieId.Ano,
                Excluido=false
            };
            await _ISerierepositorio.Editar(insertSerie);
        }

        public async Task Excluir(int id)
        {
            //Vai primeiro obter o id passado no parâmetro
            var serieId = await _ISerierepositorio.ObterById(id);
            //Vai verificar se a serie existe
            if(serieId == null){
                throw new Exception();
            }

            await _ISerierepositorio.Excluir(serieId.Id);//Depois testar com id 
        }

        public async Task Inserir(SerieInputModel serie)
        {
            var insertSerie = new SeriesModel{
                Titulo=serie.Titulo,
                Descricao=serie.Descricao,
                Ano=serie.Ano,
                Excluido=false,
                
            };

            await _ISerierepositorio.Inserir(insertSerie);
        }

        public async Task<List<SerieViewModel>> Listar()
        {
            var serieLista = await _ISerierepositorio.Listar();

            if(serieLista == null){
                throw new Exception();
            }
            
            //Vai listar todas as series 
            return serieLista.Select(series => new SerieViewModel{
                Titulo = series.Titulo,
                Descricao = series.Descricao,
                Ano = series.Ano,
                Excluido = series.Excluido
            }).ToList();

        }

        public async Task<SerieViewModel> ObterById(int id)
        {
            var serieId = await _ISerierepositorio.ObterById(id);

            if(serieId == null){
                throw new Exception();
            }

            return new SerieViewModel{
                Titulo = serieId.Titulo,
                Descricao = serieId.Descricao,
                Ano = serieId.Ano,
                Excluido = serieId.Excluido
            };
        }
    }
}

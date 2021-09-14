using DioSeriesApiRest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DioSeriesApiRest.Context
{
    public class SerieContext : DbContext
    {
        public DbSet<SeriesModel> Serie { get; set; }

        public SerieContext(DbContextOptions<SerieContext> option) : base(option)
        {
        }

        //Configuração do SqlServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetStringConnection());
            base.OnConfiguring(optionsBuilder);
        }

        //String de configuração com o banco de dados sqlServer
        private string GetStringConnection()
        {
            string strCon = "Password=123456789;Persist Security Info=True;User ID=home; Initial Catalog=CatalogoSerie;Data Source=DESKTOP-J0D6E6R\\SQLEXPRESS";
            return strCon;
        }

    }
}

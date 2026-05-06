
using ControleTarefa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        var config = new ConfigurationBuilder()
             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
             .AddJsonFile("appsettings.json")
             .Build();

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer(config.GetConnectionString("ConnString"))
            .Options;


        using (var context = new ApplicationDbContext(options))
        {
            var TarefasParaExcluir = context.Tarefas
                .Where(t => t.DataTarefa < dataAtual)
                .ToList();

            context.Tarefas.RemoveRange(TarefasParaExcluir);
            context.SaveChanges();
        }
    }
}
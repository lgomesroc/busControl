using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using BusControl.API.DataBase.SqlConnection;
using BuscControl.Test;

namespace BusControl.Test
{
    public class TripsServiceTest
    {
        [Fact]
        public void CriarViagem_DeveInserirNovaViagemNoBancoDeDados()
        {
            // Configuração do DbContext de Teste
            var serviceProvider = new ServiceCollection()
        .AddEntityFrameworkInMemoryDatabase()
        .BuildServiceProvider();

            var options = new DbContextOptionsBuilder<TestDatabaseContext>()
            .UseInMemoryDatabase("TestDatabase")
            .UseInternalServiceProvider(serviceProvider)
            .Options;

            using (var context = new TestDatabaseContext(options))
            {
                // Adicione serviços necessários ao contexto de teste aqui
                context.Database.EnsureCreated();

                // Adicione lógica específica para a inicialização de dados de teste

                // Exemplo: Adicionando um ônibus ao contexto de teste
                context.Buses.Add(new Bus { Number = "1001", Plate = "ABC-1234", Line = "Linha 100" });
                context.SaveChanges();
            }

            using (var context = new TestDatabaseContext(options))
            {
                // Lógica do Teste
                var tripsService = new TripsService(context);

                var novaViagem = new Trip
                {
                    BusId = 1,
                    DepartureTime = DateTime.Now.AddHours(1),
                    ArrivalTime = DateTime.Now.AddHours(2),
                    Duration = 60,
                    LimitPassengers = 40,
                    DriverId = 1
                    // Adicione outros campos conforme necessário
                };

                tripsService.CriarViagem(novaViagem);

                // Asserts para verificar se a viagem foi inserida corretamente
                var viagemDoBancoDeDados = context.Trips.Find(1);
                Assert.NotNull(viagemDoBancoDeDados);
                // Adicione outros asserts conforme necessário
            }
        }
    }
}


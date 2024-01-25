using BuscControl.Test;
using BusControl.API.DataBase.SqlConnection;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BusControl.Test
{
    public class TripsServiceTest
    {
        [Fact]
        public void CriarViagem_DeveInserirNovaViagemNoBancoDeDados()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var options = new DbContextOptionsBuilder<TestDatabaseContext>()
                .UseInMemoryDatabase("TestDatabase")
                .UseInternalServiceProvider(serviceProvider)
                .Options;

            using (var context = new TestDatabaseContext(options))
            {
                context.Database.EnsureCreated();

                context.Buses.Add(new Bus(1, "Ônibus 1", "ABC1234", "Linha 100", "Rota 1, Rota 2"));
                context.SaveChanges();
            }

            using (var context = new TestDatabaseContext(options))
            {
                var tripsService = new TripsService(context);

                Trip novaViagem = new Trip(
                    1,
                    1,
                    DateTime.Now.AddHours(1),
                    DateTime.Now.AddHours(2),
                    60,
                    40,
                    null,
                    "josesilva"
                );

                tripsService.CriarViagem(novaViagem);

                var viagemDoBancoDeDados = context.Trips.Find(1);
                Assert.NotNull(viagemDoBancoDeDados);
                Assert.Equal(1, viagemDoBancoDeDados.Id);
                Assert.Equal(1, viagemDoBancoDeDados.BusId);
                Assert.Equal(DateTime.Now.AddHours(1), viagemDoBancoDeDados.DepartureTime);
                Assert.Equal(DateTime.Now.AddHours(2), viagemDoBancoDeDados.ArrivalTime);
                Assert.Equal(60, viagemDoBancoDeDados.Duration);
                Assert.Equal(40, viagemDoBancoDeDados.LimitPassengers);
                Assert.Null(viagemDoBancoDeDados.Passengers);
                Assert.Equal("josesilva", viagemDoBancoDeDados.DriverId);
            }
        }

    }
}

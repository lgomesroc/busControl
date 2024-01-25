using BuscControl.Test;
using BusControl.API.DataBase.SqlConnection;

namespace BusControl.Test
{
    internal class TripsService
    {
        private TestDatabaseContext context;

        public TripsService(TestDatabaseContext context)
        {
            this.context = context;
        }

        internal void CriarViagem(Trip novaViagem)
        {
            throw new NotImplementedException();
        }
    }
}
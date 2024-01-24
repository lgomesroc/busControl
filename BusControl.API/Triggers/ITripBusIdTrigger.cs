using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Trigger;
using Microsoft.EntityFrameworkCore;

namespace BusControl.API.Triggers
{
    public class TripBusIdTrigger : ITripBusIdTrigger
    {
        public void OnInsert(DbContext context, object entity)
        {
            if (entity is Trip trip)
            {
                var duplicatedBuses = context.Set<Trip>()
                    .Where(t => t.BusId == trip.BusId)
                    .GroupBy(t => t.BusId)
                    .Where(g => g.Count() > 1)
                    .ToList();

                if (duplicatedBuses.Any())
                {
                    throw new InvalidOperationException("Apenas um ônibus pode estar associado a uma viagem.");
                }
            }
        }
    }
}


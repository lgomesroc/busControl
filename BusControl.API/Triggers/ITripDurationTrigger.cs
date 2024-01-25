using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Trigger;
using Microsoft.EntityFrameworkCore;

namespace BusControl.API.Triggers
{
    public class TripDurationTrigger : ITripDurationTrigger
    {
        public void OnInsert(DbContext context, object entity)
        {
            if (entity is Trip trip)
            {
                if (trip.Duration < 1)
                {
                    throw new InvalidOperationException("A duração de uma viagem não pode ser inferior a 1 hora.");
                }

            }
        }

        void ITripDurationTrigger.OnDelete(DbContext context, object entity)
        {
            throw new NotImplementedException();
        }
    }
}

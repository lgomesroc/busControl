using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Trigger;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusControl.API.Triggers
{
    public class TripDepartureTimeTrigger : ITripDepartureTimeTrigger
    {
        public void OnInsert(DbContext context, object entity)
        {
            if (entity is Trip trip)
            {
                if (trip.DepartureTime < DateTime.Now)
                {
                    throw new InvalidOperationException("A data e hora de partida de uma viagem não podem ser anteriores à data e hora atual.");
                }

            }
        }

        void ITripDepartureTimeTrigger.OnUpdate(DbContext context, object entityOld, object entityNew)
        {
            throw new NotImplementedException();
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace BusControl.API.Interfaces.Trigger
{
    public interface ITripDepartureTimeTrigger
    {
        void OnUpdate(DbContext context, object entityOld, object entityNew);
    }
}

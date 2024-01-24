using Microsoft.EntityFrameworkCore;

namespace BusControl.API.Interfaces.Trigger
{
    public interface ITripDurationTrigger
    {
        void OnDelete(DbContext context, object entity);
    }
}

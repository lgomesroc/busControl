using Microsoft.EntityFrameworkCore;

namespace BusControl.API.Interfaces.Trigger
{
    public interface ITripBusIdTrigger
    {
        void OnInsert(DbContext context, object entity);
    }
}

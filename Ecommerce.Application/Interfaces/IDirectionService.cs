
using GoogleApi.Entities.Maps.Geocoding.Common;

namespace Ecommerce.Application.Interfaces
{
    public interface IDirectionService
    {
        public Task<IEnumerable<Result>> GeocodeAddressAsync(string address);
    }
}

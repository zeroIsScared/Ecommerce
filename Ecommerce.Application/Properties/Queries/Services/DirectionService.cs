

using Ecommerce.Application.ConfigurationModels;
using Ecommerce.Application.Interfaces;
using Ecommerce.Integrations.Google;
using GoogleApi.Entities.Maps.Geocoding.Common;
using Microsoft.Extensions.Options;

namespace Ecommerce.Application.Services
{
    public class DirectionService : IDirectionService
    {
        private readonly IntegrationsConfiguration _config;
        public DirectionService(IOptions<IntegrationsConfiguration> configuration)
        {
            _config = configuration.Value;
        }
        public Task<IEnumerable<Result>> GeocodeAddressAsync(string address) => 
            Geocoding.GeocodeAddressAsync(_config.GoogleAPIKey, address);      
    }
}

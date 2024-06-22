

using GoogleApi.Entities.Maps.Geocoding.Address.Request;
using GoogleApi.Entities.Maps.Geocoding;
using GoogleApi;
using GoogleApi.Entities.Maps.Geocoding.Common;

namespace Ecommerce.Integrations.Google
{
    public static class Geocoding
    {
        public static async Task<IEnumerable<Result>> GeocodeAddressAsync(string apiKey, string address)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException($"Please provide an API Key for {nameof(GeocodeAddressAsync)} method.");

            AddressGeocodeRequest request = new AddressGeocodeRequest
            {
                Key = apiKey,
                Address = address,
            };
            GeocodeResponse response = await GoogleMaps.Geocode.AddressGeocode.QueryAsync(request);

            return response.Results;
        }
    }
}

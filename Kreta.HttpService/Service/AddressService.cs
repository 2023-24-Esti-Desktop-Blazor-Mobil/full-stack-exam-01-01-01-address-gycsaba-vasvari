using Kreta.Shared.Models;
using Kreta.Shared.Responses;

namespace Kreta.HttpService.Service
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient? _httpClient;

        public AddressService()
        {
            _httpClient = new HttpClient();
        }

        public AddressService(IHttpClientFactory? httpClientFactory) 
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            }
        }
        public Task<ControllerResponse> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ControllerResponse> InsertAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<List<Address>> SelectAllAddressAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ControllerResponse> UpdateAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}

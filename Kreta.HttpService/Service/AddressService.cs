using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Responses;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Service
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient? _httpClient;

        public AddressService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Address>> SelectAllAddressAsync()
        {
            if (_httpClient is not null)
            {
                try
                {
                    List<AddressDto>? resultDto = await _httpClient.GetFromJsonAsync<List<AddressDto>>("api/Address");
                    if (resultDto is not null)
                    {
                        List<Address> result = resultDto.Select(addressDto => addressDto.ToModel()).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Address>();
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

        public Task<ControllerResponse> UpdateAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}

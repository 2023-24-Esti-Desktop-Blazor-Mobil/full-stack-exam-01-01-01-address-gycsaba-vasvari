using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class AddressExtension
    {
        public static AddressDto ToDto(this Address address)
        {
            return new AddressDto
            {
                ZipCode = address.ZipCode,
                Street = address.Street,
            };
        }

        public static Address ToModel(this AddressDto addressDto) 
        {
            return new Address
            {
                ZipCode = addressDto.ZipCode,
                Street = addressDto.Street,
            };
        }
    }
}

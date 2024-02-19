using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class AddressExtension
    {
        public static AddressDto ToDto(this Address address)
        { }

        public static Address ToModel(this AddressDto addressDto) { }
    }
}

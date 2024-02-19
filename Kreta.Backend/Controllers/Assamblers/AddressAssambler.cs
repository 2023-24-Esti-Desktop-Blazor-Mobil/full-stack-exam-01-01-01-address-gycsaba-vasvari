using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Backend.Controllers.Assamblers
{
    public class AddressAssambler : Assambler<Address, AddressDto>
    {
        public override AddressDto ToDto(Address domainEntity)
        {
            throw new NotImplementedException();
        }

        public override Address ToModel(AddressDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

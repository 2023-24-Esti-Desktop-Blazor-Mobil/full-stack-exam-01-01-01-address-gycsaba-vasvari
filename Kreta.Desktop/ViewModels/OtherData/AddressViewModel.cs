using Kreta.HttpService.Service;

namespace Kreta.Desktop.ViewModels.OtherData
{
    public class AddressViewModel
    {
        private readonly IAddressService _addressService;

        public AddressViewModel()
        {
            _addressService = new AddressService();
        }

        public AddressViewModel(IAddressService addressService)
        {
            _addressService = addressService;
        }
    }
}

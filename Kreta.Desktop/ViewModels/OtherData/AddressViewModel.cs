using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using System.Collections.ObjectModel;

namespace Kreta.Desktop.ViewModels.OtherData
{
    public partial class AddressViewModel : BaseViewModel
    {
        private readonly IAddressService _addressService;

        [ObservableProperty]
        public ObservableCollection<Address> _addresses;
        public AddressViewModel()
        {
            _addressService = new AddressService();
            _addresses = new ObservableCollection<Address>();
        }

        public AddressViewModel(IAddressService addressService)
        {
            _addressService = addressService;
        }
    }
}

using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using Kreta.Desktop.ViewModels.Base;


namespace Kreta.Desktop.ViewModels.OtherData
{
    public partial class OtherDataViewModel : BaseViewModel
    {
        private AddressViewModel _addressViewModel;
        public BaseViewModel CurrentChildView { get; set; }

        public OtherDataViewModel()
        {
            _addressViewModel=new AddressViewModel();
            CurrentChildView = new AddressViewModel();
        }

        public OtherDataViewModel(AddressViewModel addressViewModel)
        {
            _addressViewModel = addressViewModel;
            CurrentChildView = _addressViewModel;
        }

        [RelayCommand]
        private void ShowAddressView()
        {            
            CurrentChildView = _addressViewModel;
        }
    }
}

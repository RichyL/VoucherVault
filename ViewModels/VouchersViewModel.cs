using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VoucherVault.Models;
using VoucherVault.Views;

namespace VoucherVault.ViewModels
{
    public partial class VouchersViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<VoucherSummary> voucherList =new List<VoucherSummary>();

        public VouchersViewModel()
        {
            VoucherList.Add(new Models.VoucherSummary { ShopName = "Morrisons", VoucherValue = "20" });

            VoucherList.Add(new Models.VoucherSummary { ShopName = "M & S", VoucherValue = "10" });
        }

        [RelayCommand]
        void GotoVoucher(VoucherSummary voucher)
        {

            Shell.Current.GoToAsync($"{nameof(VoucherView)}?VoucherSummary=", new Dictionary<string, object>() { ["richy"] = voucher });
        }

        [RelayCommand]
        void HandleItemSelected(VoucherSummary obj)
        {
            System.Diagnostics.Debug.WriteLine($"************************ {obj.ShopName}");
        }

        [RelayCommand]
        void SayHello()
        {
            System.Diagnostics.Debug.WriteLine("Hello1");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using VoucherVault.Models;

namespace VoucherVault.ViewModels
{
    /*
     * The first argument to QueryProperty will be the name of Property in this class whose value will be set
     * The second argument is the key value from the query string used to do the setting. I.e. if the routing command 
     * to show this view was
     * 
     * Shell.Current.GoToAsync($"{nameof(VoucherView)}?VoucherSummary=", new Dictionary<string, object>() { ["richy"] = voucher });
     * 
     * It can be seen that richyl is the quertystring key value
     */
    [QueryProperty(nameof(Voucher), "richy")]
    public partial class VoucherViewModel : ObservableObject
    {
        [ObservableProperty]
        VoucherSummary voucher;
    }
}

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
     * The second argument is the key value from the query string used to do the setting.
     * This can come from two places 
     * 1. querystring
     * 2. IDictionary object passed as part of GoToAsync
     * 
     * Therefore if the routing command
     * Shell.Current.GoToAsync($"{nameof(VoucherView)}?key1=123", new Dictionary<string, object>() { ["key2"] = voucher });
     * 
     * key1 is the value from the query string (value = 123) and can be picked up as a string
     * key2 is the value from the IDictionary object
     * 
     * The two class annotations to get the value from key1 into the Voucher property and the value from key2 into the RichyObject property would be
     * 
     * [QueryProperty(nameof(Voucher), "key1"))]
     * [QueryProperty(nameof(RichyObject), "key2")]
     * 
     * https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation
     */

    [QueryProperty(nameof(Voucher), nameof(VoucherSummary))]
    public partial class VoucherViewModel : ObservableObject
    {
        [ObservableProperty]
        VoucherSummary voucher;

    }
}

using VoucherVault.Models;
using VoucherVault.ViewModels;

namespace VoucherVault.Views;


public partial class VoucherView : ContentPage
{
	public VoucherView(VoucherViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
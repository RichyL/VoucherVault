
using VoucherVault.ViewModels;

namespace VoucherVault.Views;

public partial class VouchersView : ContentPage
{
	public VouchersView(VouchersViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}

}
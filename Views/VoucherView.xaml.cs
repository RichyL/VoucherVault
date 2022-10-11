using VoucherVault.Models;
using VoucherVault.ViewModels;

namespace VoucherVault.Views;

[QueryProperty(nameof(VoucherSummary),nameof(VoucherSummary))]
public partial class VoucherView : ContentPage
{
	public VoucherView(VoucherViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
using VoucherVault.Views;

namespace VoucherVault;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(VouchersView), typeof(VouchersView));
        Routing.RegisterRoute(nameof(VoucherView), typeof(VoucherView));
    }
}

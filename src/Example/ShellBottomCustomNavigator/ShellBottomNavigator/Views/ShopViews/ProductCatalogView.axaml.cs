using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaInside.Shell;
using ShellBottomNavigator.ViewModels.ShopViewModels;
using System.Threading;
using System.Threading.Tasks;

namespace ShellBottomNavigator.Views.ShopViews;

public partial class ProductCatalogView : Page
{
	public ProductCatalogView()
	{
		InitializeComponent();
	}

	public override Task InitialiseAsync(CancellationToken cancellationToken)
	{
        DataContext = new ProductCatalogViewModel(Navigator);

        return base.InitialiseAsync(cancellationToken);
	}

    private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}

	public string Icon => "fa-solid fa-tag";
}


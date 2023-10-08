using MauiTodo.Tasks.ViewModel;

namespace MauiTodo.Tasks;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
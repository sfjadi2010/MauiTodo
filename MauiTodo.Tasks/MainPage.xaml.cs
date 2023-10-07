using MauiTodo.Tasks.ViewModel;

namespace MauiTodo.Tasks
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
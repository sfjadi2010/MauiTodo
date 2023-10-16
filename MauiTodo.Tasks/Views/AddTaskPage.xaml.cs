using MauiTodo.Tasks.Data;
using MauiTodo.Tasks.ViewModels;

namespace MauiTodo.Tasks;

public partial class AddTaskPage : ContentPage
{
	TodoItemDatabase _database;
    public AddTaskPage(TodoItemDatabase database, AddViewModel vm)
    {
        InitializeComponent();
        _database = database;
        BindingContext = vm;
    }
}
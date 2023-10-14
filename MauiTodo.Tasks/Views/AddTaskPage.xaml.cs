using MauiTodo.Tasks.Data;

namespace MauiTodo.Tasks;

public partial class AddTaskPage : ContentPage
{
	TodoItemDatabase _database;
    public AddTaskPage(TodoItemDatabase database)
    {
        InitializeComponent();
        _database = database;
    }
}
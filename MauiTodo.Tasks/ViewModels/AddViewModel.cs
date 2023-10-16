using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTodo.Tasks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTodo.Tasks.ViewModels
{
    public partial class AddViewModel : ObservableObject
    {
        TodoItemDatabase _database;
        public AddViewModel(TodoItemDatabase database)
        {
            _database = database;
        }

        [ObservableProperty]
        string titleText;

        [ObservableProperty]
        string descriptionText;

        [ObservableProperty]
        bool done;
        
        [RelayCommand]
        async Task AddTask()
        {
            if (string.IsNullOrWhiteSpace(TitleText))
                return;

            var todoItem = new Models.TodoItem
            {
                Id = 0,
                Todo = TitleText,
                Description = DescriptionText,
                Done = Done
            };

            await _database.SaveItemAsync(todoItem);
            
            // await Shell.Current.GoToAsync(nameof(MainPage));
        }

        [RelayCommand]
        async Task Cancel()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }
    }
}

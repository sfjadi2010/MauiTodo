using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTodo.Tasks.Data;
using MauiTodo.Tasks.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiTodo.Tasks.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        TodoItemDatabase _database;
        public MainViewModel(TodoItemDatabase database)
        {
            _database = database;
            var todoItems = _database.GetTodoItemsNotDoneAsync();

            InitViewModel();
        }

        private async void InitViewModel()
        {
            Items = await Loaddata();
        }

        private async Task<ObservableCollection<TodoItem>> Loaddata()
        {
            return new ObservableCollection<TodoItem>(await _database.GetTodoItemsNotDoneAsync());
        }

        [ObservableProperty]
        ObservableCollection<TodoItem> items;

        [ObservableProperty]
        string taskText;

        [RelayCommand]
        void AddTask()
        {
            //if (string.IsNullOrWhiteSpace(TaskText))
            //    return;

            //Items.Add();

            //TaskText = string.Empty;
        }

        [RelayCommand]
        void DeleteTask(TodoItem task)
        {
            if (Items.Contains(task))
            {
                Items.Remove(task);
            }
        }

        [RelayCommand]
        async Task TaskTapped(TodoItem task)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={task.Todo}");
        }

        [RelayCommand]
        async Task AddTaskTapped()
        {
            await Shell.Current.GoToAsync(nameof(AddTaskPage));
        }
    }
}

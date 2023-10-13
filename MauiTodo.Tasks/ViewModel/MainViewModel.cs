﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiTodo.Tasks.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string taskText;

        [RelayCommand]
        void AddTask()
        {
            if (string.IsNullOrWhiteSpace(TaskText))
                return;

            Items.Add(TaskText);

            TaskText = string.Empty;
        }

        [RelayCommand]
        void DeleteTask(string task)
        {
            if (Items.Contains(task))
            {
                Items.Remove(task);
            }
        }

        [RelayCommand]
        async Task TaskTapped(string task)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={task}");
        }

        [RelayCommand]
        async Task AddTaskTapped()
        {
            await Shell.Current.GoToAsync(nameof(AddTaskPage));
        }
    }
}

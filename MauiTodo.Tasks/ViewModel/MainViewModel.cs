using CommunityToolkit.Mvvm.ComponentModel;
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
        void OnAddTask()
        {
            if (string.IsNullOrWhiteSpace(TaskText))
                return;

            Items.Add(TaskText);

            TaskText = string.Empty;
        }

        [RelayCommand]
        void OnDeleteTask(string task)
        {
            if (Items.Contains(task))
            {
                Items.Remove(task);
            }
        }
    }
}

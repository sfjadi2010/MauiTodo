using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTodo.Tasks.ViewModels
{
    public partial class AddViewModel : ObservableObject
    {
        public AddViewModel()
        {
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
            
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

        [RelayCommand]
        async Task Cancel()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }
    }
}

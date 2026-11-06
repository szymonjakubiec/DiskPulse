using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DiskPulse.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        private void ExecuteAction(string? tag)
        {
            ExampleMessage = tag ?? string.Empty;
        }
        private string _exampleMessage;
        public string ExampleMessage
        {
            get => _exampleMessage;
            set => SetProperty(ref _exampleMessage, value);
        }
        public MainViewModel()
        {
            // Initialize properties and commands here.
        }
    }
}

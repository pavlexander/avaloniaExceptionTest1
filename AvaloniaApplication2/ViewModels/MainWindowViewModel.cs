using AvaloniaApplication2.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvaloniaApplication2.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [RelayCommand]
    public async Task OpenNewWindowWithToken(CancellationToken token)
    {
        var newWindow = new Window1();
        newWindow.Show();
    }

    [RelayCommand]
    public async Task OpenNewWindow()
    {
        var newWindow = new Window1();
        newWindow.Show();
    }
}

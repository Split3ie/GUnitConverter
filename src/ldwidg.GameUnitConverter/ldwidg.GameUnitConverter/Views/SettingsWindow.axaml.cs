using System;
using Avalonia.ReactiveUI;
using ldwidg.GameUnitConverter.ViewModels;
using ReactiveUI;

namespace ldwidg.GameUnitConverter.Views;

public partial class SettingsWindow : ReactiveWindow<SettingsViewModel>
{
    public SettingsWindow()
    {
        InitializeComponent();
        this.WhenActivated(action => action(ViewModel!.SaveGameSettingsCommand.Subscribe(Close)));
    }
}
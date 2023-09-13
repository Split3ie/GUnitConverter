using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ldwidg.GameUnitConverter.ViewModels;
using ReactiveUI;

namespace ldwidg.GameUnitConverter.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        this.WhenActivated(action => 
            action(ViewModel!.ShowSettings.RegisterHandler(OpenSettingsAsync)));
    }

    private async Task OpenSettingsAsync(InteractionContext<SettingsViewModel, List<ImportGameUnitsViewModel>> interaction)
    {
        var dialog = new SettingsWindow();
        dialog.DataContext = interaction.Input;

        var result = await dialog.ShowDialog<List<ImportGameUnitsViewModel>?>(this);
        interaction.SetOutput(result);
    }
}
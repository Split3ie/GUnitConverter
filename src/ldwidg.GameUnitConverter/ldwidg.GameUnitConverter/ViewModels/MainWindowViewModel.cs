using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Windows.Input;
using DynamicData;
using ldwidg.GameUnitConverter.Views;
using ReactiveUI;

namespace ldwidg.GameUnitConverter.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public Interaction<SettingsViewModel, List<ImportGameUnitsViewModel>?> ShowSettings { get; }
    public ICommand OpenSettingsCommand { get; }
    public ObservableCollection<ImportGameUnitsViewModel> Games { get; private set; } = new();

    public MainWindowViewModel()
    {
        ShowSettings = new Interaction<SettingsViewModel, List<ImportGameUnitsViewModel>>();
        OpenSettingsCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            var settings = new SettingsViewModel();
            var result = await ShowSettings.Handle(settings);
            if (result != null)
            {
                Games.Clear();
                Games.AddRange(result);
            }
        });
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Selection;
using Avalonia.Platform.Storage;
using DynamicData;
using ldwidg.GameUnitConverter.Domain;
using ReactiveUI;

namespace ldwidg.GameUnitConverter.ViewModels;

public class SettingsViewModel : ViewModelBase
{
    private ObservableCollection<ImportGameUnitsViewModel>? _selectedGames = new();

    public ObservableCollection<ImportGameUnitsViewModel> GamesToImport { get; } = new();

    public ObservableCollection<ImportGameUnitsViewModel>? SelectedGames
    {
        get => _selectedGames;
        set => this.RaiseAndSetIfChanged(ref _selectedGames, value);
    }
    public bool IsSelectAll
    {
        get => _isSelectAll;
        set
        {
            this.RaiseAndSetIfChanged(ref _isSelectAll, value);
            if (_isSelectAll)
            {
                SelectedGames.Clear();
                SelectedGames.AddRange(GamesToImport);
            }
            else
            {
                SelectedGames.Clear();
            }
        }
    }

    private string? _importFilePath;
    private bool _isBusy;
    private bool _isSelectAll;

    public string ImportFilePath
    {
        get => _importFilePath;
        set
        {
            this.RaiseAndSetIfChanged(ref _importFilePath, value);
            LoadSettings();
        }
    }

    public bool IsBusy
    {
        get => _isBusy;
        set => this.RaiseAndSetIfChanged(ref _isBusy, value);
    }

    public ReactiveCommand<Unit, List<ImportGameUnitsViewModel>?> SaveGameSettingsCommand { get; }

    public SettingsViewModel()
    {
        GamesToImport.Add(new ImportGameUnitsViewModel { GameName = "Counter Strike" });
        GamesToImport.Add(new ImportGameUnitsViewModel { GameName = "God of War" });
        GamesToImport.Add(new ImportGameUnitsViewModel { GameName = "Grand Theft Auto" });
        IsSelectAll = true;
        SaveGameSettingsCommand = ReactiveCommand.Create(() =>
        {
            return SelectedGames?.ToList();
        });
    }

    private void LoadSettings()
    {
        var fileStream = File.OpenText(ImportFilePath);
        // Reads all the content of file as a text.
        var fileContent = fileStream.ReadToEnd();

        var gameSettings = JsonSerializer.Deserialize<List<GameUnitSetting>>(fileContent);

        if (gameSettings?.Any() == true)
        {
            GamesToImport.Clear();
            foreach (var gameSetting in gameSettings)
            {
                GamesToImport.Add(new ImportGameUnitsViewModel
                {
                    GameName = gameSetting.GameName,
                    Unit = gameSetting.Unit,
                    Cm = gameSetting.Cm,
                    Millimeter = gameSetting.Millimeter,
                    Feet = gameSetting.Feet,
                    Inches = gameSetting.Inches,
                    Meter = gameSetting.Meter
                });
            }
        }
    }

}
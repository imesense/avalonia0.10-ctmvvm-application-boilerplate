using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;

using ImeSense.Boilerplates.Avalonia.Views;

namespace ImeSense.Boilerplates.Avalonia;

public partial class App : Application
{
    public override void Initialize() =>
        AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Remove Avalonia data validation to avoid duplication validations
            // from both Avalonia and CommunityToolkit.Mvvm.
            ExpressionObserver.DataValidators.RemoveAll(x =>
                x is DataAnnotationsValidationPlugin);

            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
}

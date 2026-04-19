using Avalonia.Web.Blazor;

namespace ImeSense.Boilerplates.Avalonia.WebAssembly;

public partial class App
{
    protected override void OnParametersSet()
    {
        WebAppBuilder.Configure<Avalonia.App>()
            .SetupWithSingleViewLifetime();

        base.OnParametersSet();
    }
}

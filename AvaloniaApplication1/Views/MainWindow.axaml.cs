using Avalonia.Controls;
using Mapsui.Tiling;
using Mapsui.UI.Avalonia;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var mapControl = this.FindControl<MapControl>("MyMapControl");
        mapControl?.Map?.Layers.Add(OpenStreetMap.CreateTileLayer());
    }
}
using Microsoft.UI.Input;
using Microsoft.UI.Xaml;

namespace MicrosoftUIXamlIssue10835;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ExtendsContentIntoTitleBar = true;
        _inputNonClientPointerSource = InputNonClientPointerSource.GetForWindowId(AppWindow.Id);
        _inputNonClientPointerSource.RegionsChanged += OnNonClientRegionsChanged;
    }

    private void OnNonClientRegionsChanged(InputNonClientPointerSource sender, NonClientRegionsChangedEventArgs args)
    {
        NonClientRegionKind[] changedRegions = args.ChangedRegions;
    }

    private readonly InputNonClientPointerSource _inputNonClientPointerSource;
}

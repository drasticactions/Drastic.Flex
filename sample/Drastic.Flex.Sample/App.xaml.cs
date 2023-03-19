namespace Drastic.Flex.Sample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new DebugWindow();
    }
}

public class DebugWindow : Window
{
    public DebugWindow()
    {
        Page = new AppShell();
    }

    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
    }
}

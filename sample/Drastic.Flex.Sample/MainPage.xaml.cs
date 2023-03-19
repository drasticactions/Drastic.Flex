namespace Drastic.Flex.Sample;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
#if IOS
        Drastic.FLEX.FLEXManager.SharedManager.ShowExplorer();
#endif
    }
}
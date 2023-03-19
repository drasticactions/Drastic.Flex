[![NuGet Version](https://img.shields.io/nuget/v/Drastic.Flex.svg)](https://www.nuget.org/packages/Drastic.Flex/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.Flex

Drastic.Flex is a binding of [Flex](https://github.com/FLEXTool/FLEX) for .NET iOS.

# How To

- Install the Nuget.
- Run `Drastic.FLEX.FLEXManager.SharedManager.ShowExplorer();` to show the explorer.

# MAUI Notes

When using with MAUI, depending on when you call for `ShowExplorer()`, its contents may be malformed. For best results, show it after your initial page contents have loaded.

```csharp
public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
#if IOS
        Drastic.FLEX.FLEXManager.SharedManager.ShowExplorer();
#endif
    }
}
```

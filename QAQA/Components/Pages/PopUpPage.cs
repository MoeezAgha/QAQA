namespace QAQA.Components.Pages;

using Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components.WebView.Maui;

public class PopUpPage2 : ContentPage
{
    public PopUpPage2(string message)  // <-- parameter here
    {
        Title = "PopUp";

        Content = new BlazorWebView
        {
            HostPage = "wwwroot/index.html",
            RootComponents =
            {
                new RootComponent
                {
                    Selector = "#app",
                    ComponentType = typeof(PopUp),
                    Parameters = new Dictionary<string, object>
                    {
                        { "Message", message }   // pass parameter to Blazor component
                    }
                }
            }
        };
    }
}


public static class AppShellHelper
{
    public static Shell? CurrentShell => Application.Current?.MainPage as Shell;
}

namespace QAQA.Components.Pages;

using Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components.WebView.Maui;

public class GenericPopUpPage : ContentPage
{
    /// <summary>
    /// Create a generic popup page hosting any Blazor component with optional parameters.
    /// </summary>
    /// <param name="blazorComponentType">The Blazor component type (e.g., typeof(PopUp))</param>
    /// <param name="parameters">Optional dictionary of parameters to pass to the Blazor component</param>
    /// <param name="title">Optional page title</param>
    public GenericPopUpPage(Type blazorComponentType, Dictionary<string, object>? parameters = null, string title = "")
    {
        Title = title;

        Content = new BlazorWebView
        {
            HostPage = "wwwroot/index.html",
            RootComponents =
            {
                new RootComponent
                {
                    Selector = "#app",
                    ComponentType = blazorComponentType,
                    Parameters = parameters ?? new Dictionary<string, object>()
                }
            }
        };
    }
}
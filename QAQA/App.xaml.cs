namespace QAQA
{
    public partial class App : Application
    {
            public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("popup", typeof(QAQA.Components.Pages.PopUpPage2));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "QAQA" };  
        }
    }
}

namespace RefitXF
{
    using RefitXF.Services;
    using RefitXF.View;
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegisterDependencyService();

            MainPage = new NavigationPage(new MainView());
        }

        private void RegisterDependencyService() => DependencyService.Register<IApiService, ApiService>();

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}

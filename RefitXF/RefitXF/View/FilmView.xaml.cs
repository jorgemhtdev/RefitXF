namespace RefitXF.View
{
    using RefitXF.ViewModels;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmView : ContentPage
    {
        public FilmView(int id)
        {
            InitializeComponent();

            BindingContext = new FilmViewModel(id);
        }
    }
}
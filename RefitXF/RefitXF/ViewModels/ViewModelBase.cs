namespace RefitXF.ViewModels
{
    using RefitXF.Services;
    using Xamarin.Forms;

    public class ViewModelBase : BindableObject
    {
        public IApiService apiService;
    }
}

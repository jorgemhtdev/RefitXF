namespace RefitXF.ViewModels
{
    using RefitXF.Models;
    using RefitXF.Services;
    using Xamarin.Forms;

    public class FilmViewModel : ViewModelBase
    {
        Film film;

        public Film Film
        {
            get => film;
            set
            {
                film = value;
                OnPropertyChanged();
            }
        }

        public FilmViewModel(int id)
        {
            apiService = DependencyService.Get<IApiService>();
            LoadData(id);
        }

        private async void LoadData(int id) => Film = await apiService.GetFilmById(id);
    }
}

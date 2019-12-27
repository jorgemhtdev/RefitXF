namespace RefitXF.ViewModels
{
    using RefitXF.Models;
    using RefitXF.Services;
    using RefitXF.View;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Film> films;

        Film selectedfilm;
        public Film SelectedFilm
        {
            get => selectedfilm;
            set
            {
                if (selectedfilm != value)
                {
                    selectedfilm = value;
                    NaviteTo();
                }
            }
        }

        public ObservableCollection<Film> Films
        {
            get => films;
            set
            {
                films = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            apiService = DependencyService.Get<IApiService>();

            LoadData();
        }

        private async void LoadData() => Films = new ObservableCollection<Film>(await apiService.GetAllFilm());

        private void NaviteTo() => App.Current.MainPage.Navigation.PushAsync(new FilmView(SelectedFilm.FilmId));

    }
}

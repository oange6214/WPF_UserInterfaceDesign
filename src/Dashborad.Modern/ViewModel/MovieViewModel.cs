using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Dashborad.Modern.Model;

namespace Dashborad.Modern.ViewModel
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource MovieItemsCollection;
        public ICollectionView MovieSourceCollection => MovieItemsCollection.View;

        public MovieViewModel()
        {
            ObservableCollection<MovieItems> movieItems = new ObservableCollection<MovieItems>
            {
                new MovieItems { MovieName = "Action", MovieImage = @"/Assets/Images/clap_icon.png" },
                new MovieItems { MovieName = "Thriller", MovieImage = @"/Assets/Images/clap_icon.png" },
                new MovieItems { MovieName = "Adventure", MovieImage = @"/Assets/Images/clap_icon.png" },
                new MovieItems { MovieName = "Drama", MovieImage = @"/Assets/Images/clap_icon.png" },
                new MovieItems { MovieName = "Fantasy", MovieImage = @"/Assets/Images/clap_icon.png" },
                new MovieItems { MovieName = "Mystery", MovieImage = @"/Assets/Images/clap_icon.png" }
            };

            MovieItemsCollection = new CollectionViewSource { Source = movieItems };
            MovieItemsCollection.Filter += MenuItems_Filter;
        }

        private string _filterText;

        public string FilterText
        {
            get => _filterText;
            set
            {
                _filterText = value;
                MovieItemsCollection.View.Refresh();
                OnPropertyChanged("FilterText");
            }
        }

        private void MenuItems_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            MovieItems _item = e.Item as MovieItems;
            if (_item.MovieName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Dashborad.Modern.Model;

namespace Dashborad.Modern.ViewModel
{
    public class DownloadViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource DownloadItemsCollection;
        public ICollectionView DownloadSourceCollection => DownloadItemsCollection.View;

        public DownloadViewModel()
        {
            ObservableCollection<DownloadItems> downloadItems = new ObservableCollection<DownloadItems>
            {
                new DownloadItems { DownloadName = "Visual Studio 2019", DownloadImage = @"/Assets/Images/vs_icon.png" },
                new DownloadItems { DownloadName = "Android Studio", DownloadImage = @"/Assets/Images/android_icon.png" },
                new DownloadItems { DownloadName = "Python", DownloadImage = @"/Assets/Images/python_icon.png" },
                new DownloadItems { DownloadName = "Swift", DownloadImage = @"/Assets/Images/swift_icon.png" },
                new DownloadItems { DownloadName = "Visual Studio Code", DownloadImage = @"/Assets/Images/vsc_icon.png" },
                new DownloadItems { DownloadName = "Javascript", DownloadImage = @"/Assets/Images/javascript_icon.png" },
                new DownloadItems { DownloadName = "HTML 5", DownloadImage = @"/Assets/Images/html_icon.png" },
                new DownloadItems { DownloadName = "Angular", DownloadImage = @"/Assets/Images/angular_icon.png" },
                new DownloadItems { DownloadName = "Flutter", DownloadImage = @"/Assets/Images/flutter_icon.png" }
            };

            DownloadItemsCollection = new CollectionViewSource { Source = downloadItems };
            DownloadItemsCollection.Filter += MenuItems_Filter;
        }

        private string _filterText;

        public string FilterText
        {
            get => _filterText;
            set
            {
                _filterText = value;
                DownloadItemsCollection.View.Refresh();
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

            DownloadItems _item = e.Item as DownloadItems;
            if (_item.DownloadName.ToUpper().Contains(FilterText.ToUpper()))
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
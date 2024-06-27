using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Dashborad.Modern.Model;

namespace Dashborad.Modern.ViewModel
{
    public class DocumentViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource DocumentItemsCollection;
        public ICollectionView DocumentSourceCollection => DocumentItemsCollection.View;

        public DocumentViewModel()
        {
            ObservableCollection<DocumentItems> documentItems =
            [
                new() { DocumentName = "Books", DocumentImage = @"/Assets/Images/book_icon.png" },
                new() { DocumentName = "Studio", DocumentImage = @"/Assets/Images/studio_icon.png" },
                new() { DocumentName = "Export", DocumentImage = @"/Assets/Images/export_icon.png" },
                new() { DocumentName = "Print", DocumentImage = @"/Assets/Images/print_icon.png" },
                new() { DocumentName = "Orders", DocumentImage = @"/Assets/Images/order_icon.png" },
                new() { DocumentName = "Stocks", DocumentImage = @"/Assets/Images/stock_icon.png" },
                new() { DocumentName = "Invoice", DocumentImage = @"/Assets/Images/invoice_icon.png" }
            ];

            DocumentItemsCollection = new CollectionViewSource { Source = documentItems };
            DocumentItemsCollection.Filter += MenuItems_Filter;
        }

        private string _filterText;

        public string FilterText
        {
            get => _filterText;
            set
            {
                _filterText = value;
                DocumentItemsCollection.View.Refresh();
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

            DocumentItems _item = e.Item as DocumentItems;
            if (_item.DocumentName.ToUpper().Contains(FilterText.ToUpper()))
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
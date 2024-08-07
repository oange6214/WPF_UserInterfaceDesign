﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Dashborad.Modern.Model;

namespace Dashborad.Modern.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource HomeItemsCollection;
        public ICollectionView HomeSourceCollection => HomeItemsCollection.View;

        public HomeViewModel()
        {
            ObservableCollection<HomeItems> homeItems = new ObservableCollection<HomeItems>
            {
                new HomeItems { HomeName = "This PC", HomeImage = @"/Assets/Images/pc_icon.png" },
            };

            HomeItemsCollection = new CollectionViewSource { Source = homeItems };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
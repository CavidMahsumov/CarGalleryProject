using CarGallerry.Commands;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace CarGallerry.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public FilterUserControl filterUserControl { get; set; }
        public RelayCommand FilterBtnCommand { get; set; }
        public IRepository<ImagePath> _repo { get; set; }
        public ObservableCollection<ImagePath> Images { get; set; }
    

        public MainViewModel(MainWindow mainWindow, IImagePathRepository repository)
        {
            Images = new ObservableCollection<ImagePath>();
            _repo = repository;
            filterUserControl = new FilterUserControl();
            FilterBtnCommand = new RelayCommand((sender) =>
              {
                  mainWindow.userGrid.Children.Add(filterUserControl);
              });
            Images = _repo.GetAllData();
            ;
    


        }
        private Uri ConvertToLink(string path)
        {
            Uri uri = new Uri(path);
            return uri;

        }
        
    }
}

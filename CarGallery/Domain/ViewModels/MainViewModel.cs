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
        private string  imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; OnPropertyChanged(); }
        }

        public MainViewModel(MainWindow mainWindow, IImagePathRepository repository)
        {
            ImagePath = "https://github.com/CavidMahsumov/CarGalleryImages/blob/fa211f59be07c2c68a11729429ee44433ac4400f/BMW330.jpg?raw=true";
            Images = new ObservableCollection<ImagePath>();
            _repo = repository;
            filterUserControl = new FilterUserControl();
            FilterBtnCommand = new RelayCommand((sender) =>
              {
                  mainWindow.userGrid.Children.Add(filterUserControl);
              });
            Images = _repo.GetAllData();
            ;
            var fullFilePath = @"https://github.com/CavidMahsumov/CarGalleryImages/blob/fa211f59be07c2c68a11729429ee44433ac4400f/BMW330.jpg?raw=true";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            mainWindow.Image1.Source = bitmap;


        }
        private Uri ConvertToLink(string path)
        {
            Uri uri = new Uri(path);
            return uri;

        }
        
    }
}

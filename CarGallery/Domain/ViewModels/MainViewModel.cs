using CarGallerry.Commands;
using CarGallerry.Domain.AdditionalClasses;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using CarGallery.Domain.AdditionalClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace CarGallerry.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public FilterUserControl filterUserControl { get; set; }
        public RelayCommand FilterBtnCommand { get; set; }
        public IRepository<Car> _repo { get; set; }
        public ObservableCollection<Car> Cars { get; set; }
        public CarsRepository carsRepository { get; set; }



        public MainViewModel(MainWindow mainWindow, ICarsRepository repository)
        {
            Cars = new ObservableCollection<Car>();
            _repo = repository;
            filterUserControl = new FilterUserControl();
            FilterBtnCommand = new RelayCommand((sender) =>
              {
                  mainWindow.userGrid.Children.Add(filterUserControl);
              });
            carsRepository = new CarsRepository();
            Cars = carsRepository.GetAllData();
            ClassHelper.mainWindow = mainWindow ;
            ClassHelper.Cars = Cars;
    


        }
        

        
    }
}

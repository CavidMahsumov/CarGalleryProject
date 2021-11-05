using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarGallerry.Domain.ViewModels
{
    public class FilterUserControlViewModel:BaseViewModel
    {
        public IRepository<Brand> _Brandsrepo { get; set; }
        public IRepository<BanType> _BanTypesrepo { get; set; }
        public IRepository<CarColor> _CarColorsrepo { get; set; }
        public ObservableCollection<Brand> Brands { get; set; }
        public ObservableCollection<BanType> BanTypes { get; set; }
        public ObservableCollection<CarColor> CarColors { get; set; }
        public FilterUserControlViewModel(FilterUserControl filterUserControl)
        {
            Brands = new ObservableCollection<Brand>();
            BanTypes = new ObservableCollection<BanType>();
            CarColors = new ObservableCollection<CarColor>();
            Brands = _Brandsrepo.GetAllData();
            BanTypes = _BanTypesrepo.GetAllData();
            CarColors = _CarColorsrepo.GetAllData();
            filterUserControl.markaCmbbx.ItemsSource = Brands;
        }
    }
}

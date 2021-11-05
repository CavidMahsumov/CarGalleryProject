using CarGallerry.Commands;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        public RelayCommand SearchBtnClick { get; set; }
        public FilterUserControlViewModel(FilterUserControl filterUserControl,BrandsRepository brandsRepository,
            CarColorsRepository carColorsRepository,BanTypesRepository banTypesRepository)
        {
            Brands = new ObservableCollection<Brand>();
            BanTypes = new ObservableCollection<BanType>();
            CarColors = new ObservableCollection<CarColor>();
            _Brandsrepo = brandsRepository;
            _CarColorsrepo = carColorsRepository;
            _BanTypesrepo = banTypesRepository;
        
            filterUserControl.markaCmbbx.ItemsSource = _Brandsrepo.GetAllData().Select(b=>b.Name);
            filterUserControl.colorCmbbx.ItemsSource = _CarColorsrepo.GetAllData().Select(c => c.Name);
            filterUserControl.banTypeCmbbx.ItemsSource = _BanTypesrepo.GetAllData().Select(b => b.Name);

            SearchBtnClick = new RelayCommand((sender) =>
            {



            });
        }
    }
}

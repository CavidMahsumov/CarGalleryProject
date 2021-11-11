﻿using CarGallerry.Commands;
using CarGallerry.Domain.AdditionalClasses;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using CarGallery.Domain.AdditionalClasses;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace CarGallerry.Domain.ViewModels
{
    public class FilterUserControlViewModel : BaseViewModel
    {
        public IRepository<Brand> _Brandsrepo { get; set; }
        public IRepository<BanType> _BanTypesrepo { get; set; }
        public IRepository<CarColor> _CarColorsrepo { get; set; }
        public ObservableCollection<Brand> Brands { get; set; }
        public ObservableCollection<BanType> BanTypes { get; set; }
        public ObservableCollection<CarColor> CarColors { get; set; }
        public RelayCommand SearchBtnClick { get; set; }
        public RelayCommand MarkoComboBoxSelectionChanged { get; set; }
        public RelayCommand ColorComboBoxSelectionChanged { get; set; }
        public RelayCommand BanTypeComboBoxSelectionChanged { get; set; }
        public RelayCommand MilageMinTextChangedCommand { get; set; }
        public RelayCommand MilageMaxTextChangedCommand { get; set; }
        public RelayCommand PriceMinTextChangedCommand { get; set; }
        public RelayCommand PriceMaxTextChangedCommand { get; set; }
        public ObservableCollection<Car> Cars { get; set; }
        public FilterUserControlViewModel(FilterUserControl filterUserControl, BrandsRepository brandsRepository,
            CarColorsRepository carColorsRepository, BanTypesRepository banTypesRepository)
        {
            Brands = new ObservableCollection<Brand>();
            BanTypes = new ObservableCollection<BanType>();
            CarColors = new ObservableCollection<CarColor>();
            _Brandsrepo = brandsRepository;
            _CarColorsrepo = carColorsRepository;
            _BanTypesrepo = banTypesRepository;
            Cars = new ObservableCollection<Car>();

            filterUserControl.markaCmbbx.ItemsSource = _Brandsrepo.GetAllData().Select(b => b.Name);
            filterUserControl.colorCmbbx.ItemsSource = _CarColorsrepo.GetAllData().Select(c => c.Name);
            filterUserControl.banTypeCmbbx.ItemsSource = _BanTypesrepo.GetAllData().Select(b => b.Name);

            SearchBtnClick = new RelayCommand((sender) =>
            {



            });
            MarkoComboBoxSelectionChanged = new RelayCommand((sender) =>
            {
                try
                {
                    Cars = ObserverHelper.ToObservableCollection(ClassHelper.Cars.Where(c => c.Brand.Name.ToString() == filterUserControl.markaCmbbx.SelectedItem.ToString()));
                    ClassHelper.mainWindow.Listbox.ItemsSource = Cars;
                }
                catch (Exception)
                {

                }

            });
            BanTypeComboBoxSelectionChanged = new RelayCommand((sender) =>
            {
                try
                {
                    ClassHelper.mainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.BanType.Name.ToString() == filterUserControl.banTypeCmbbx.SelectedItem.ToString()));

                }
                catch (Exception)
                {

                }

            });
            ColorComboBoxSelectionChanged = new RelayCommand((sender) =>
            {
                try
                {
                    ClassHelper.mainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.CarColor.Name.ToString() == filterUserControl.colorCmbbx.SelectedItem.ToString()));
                }
                catch (Exception)
                {

                }

            });
            MilageMaxTextChangedCommand = new RelayCommand((sender) =>
            {
                try
                {
                    ClassHelper.mainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.Milage.Value <= decimal.Parse(filterUserControl.maxTxtbx.Text)));
                }
                catch (Exception)
                {

                }

            });
            MilageMinTextChangedCommand = new RelayCommand((sender) =>
            {
                try
                {
                    ClassHelper.mainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.Milage >= decimal.Parse(filterUserControl.minTxtbx.Text)));
                }
                catch (Exception)
                {

                }

            });
            PriceMaxTextChangedCommand = new RelayCommand((sender) =>
            {

                try
                {
                    ClassHelper.mainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.Price <= decimal.Parse(filterUserControl.maxPriceTxtbx.Text)));
                }
                catch (Exception)
                {

                }
            });
            PriceMinTextChangedCommand = new RelayCommand((sender) =>
            {
                try
                {
                    ClassHelper.mainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.Price >= decimal.Parse(filterUserControl.minPriceTxtbx.Text)));
                }
                catch (Exception)
                {

                }
            });

        }
    }
}

﻿using CarGallerry.Domain.ViewModels;
using CarGallery.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarGallerry.Views
{
    /// <summary>
    /// Interaction logic for FilterUserControl.xaml
    /// </summary>
    public partial class FilterUserControl : UserControl
    {
   
        public FilterUserControl()
        {
            InitializeComponent();
            DataContext = new FilterUserControlViewModel(this,new BrandsRepository(),new CarColorsRepository(),new BanTypesRepository());

        }

     
    }
}

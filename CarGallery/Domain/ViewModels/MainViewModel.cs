using CarGallerry.Commands;
using CarGallerry.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGallerry.Domain.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public FilterUserControl filterUserControl { get; set; }
        public RelayCommand FilterBtnCommand { get; set; }
        public MainViewModel(MainWindow mainWindow)
        {
            filterUserControl = new FilterUserControl();
            FilterBtnCommand=new RelayCommand((sender)=> 
            {
                mainWindow.userGrid.Children.Add(filterUserControl);
            });
        }
    }
}

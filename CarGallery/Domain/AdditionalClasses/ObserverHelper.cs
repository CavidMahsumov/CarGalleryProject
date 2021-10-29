using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarGallerry.Domain.AdditionalClasses
{
    public class ObserverHelper
    {
        public static ObservableCollection<T> ToObservableCollection<T>(IEnumerable<T> list)
        {
            return new ObservableCollection<T>(list);
        }
    }
}

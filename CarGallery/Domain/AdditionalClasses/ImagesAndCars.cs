using CarGallery.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Domain.AdditionalClasses
{
    
    public class ImagesAndCars
    {
        public ObservableCollection<Car> Cars { get; set; }
        public ObservableCollection<ImagePath> Paths { get; set; }

        public ImagesAndCars()
        {
            Cars = new ObservableCollection<Car>();
            Paths = new ObservableCollection<ImagePath>();
        }
    }
}

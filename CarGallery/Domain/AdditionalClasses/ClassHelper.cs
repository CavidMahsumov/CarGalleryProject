using CarGallerry;
using CarGallery.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Domain.AdditionalClasses
{
    public class ClassHelper
    {
       static  public MainWindow  mainWindow{ get; set; }
        static public ObservableCollection<Car> Cars { get; set; }
        public ClassHelper()
        {
            mainWindow = new MainWindow();
            Cars = new ObservableCollection<Car>();
        }
    }
}

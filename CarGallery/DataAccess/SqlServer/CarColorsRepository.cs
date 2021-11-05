using CarGallerry.Domain.AdditionalClasses;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class CarColorsRepository : ICarColorsRepository
    {
        public CarColorsRepository()
        {
            dataContext = new DataClasses1DataContext();
        }
        public DataClasses1DataContext dataContext { get; set; }
        public void AddData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CarColor> GetAllData()
        {
            var color = from c in dataContext.CarColors
                        select c;
            return ObserverHelper.ToObservableCollection(color);
        }

        public CarColor GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarColor data)
        {
            throw new NotImplementedException();
        }
    }
}

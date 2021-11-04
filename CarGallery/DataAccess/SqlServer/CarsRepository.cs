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
    public class CarsRepository : ICarsRepository
    {
       
        public DataClasses1DataContext DataContext { get; set; }
        public CarsRepository()
        {
            DataContext = new DataClasses1DataContext();
        }
        public void AddData(Car data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Car data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Car> GetAllData()
        {
            var cars = from c in DataContext.Cars
                       select c;
            return ObserverHelper.ToObservableCollection(cars);
        }

        public Car GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Car data)
        {
            throw new NotImplementedException();
        }
    }
}

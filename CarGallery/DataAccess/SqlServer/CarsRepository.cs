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
            var cars = from contact in DataContext.Cars
                       //join dealer in DataContext.Brands on contact.Brand_Id equals dealer.Id
                       join images in DataContext.ImagePaths on contact.ImagePath_Id equals images.Id
                       select contact;
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

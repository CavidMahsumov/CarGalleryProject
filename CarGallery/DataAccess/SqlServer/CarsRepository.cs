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
            throw new NotImplementedException();
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

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
    public class BanTypesRepository : IBanTypeRepository
    {
        public DataClasses1DataContext dataContext { get; set; }
        public BanTypesRepository()
        {
            dataContext = new DataClasses1DataContext();
        }
        public void AddData(BanType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(BanType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<BanType> GetAllData()
        {
            var bantypes = from b in dataContext.BanTypes
                         select b;
            return ObserverHelper.ToObservableCollection(bantypes);
        }

        public BanType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(BanType data)
        {
            throw new NotImplementedException();
        }
    }
}

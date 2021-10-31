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
    public class ImagePathRepository : IImagePathRepository
    {
        public DataClasses1DataContext dataContext { get; set; }
        public ImagePathRepository()
        {
            dataContext = new DataClasses1DataContext();
        }
        public void AddData(ImagePath data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(ImagePath data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ImagePath> GetAllData()
        {
            var images = from a in dataContext.ImagePaths
                          select a;
            return ObserverHelper.ToObservableCollection(images);
        }

        public ImagePath GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(ImagePath data)
        {
            throw new NotImplementedException();
        }
    }
}

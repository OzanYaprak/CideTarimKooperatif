using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDAL _imageDAL;

        public ImageManager(IImageDAL imageDAL)
        {
            _imageDAL = imageDAL;
        }





        public void Add(Image entity)
        {
            _imageDAL.Add(entity);
        }

        public void Delete(Image entity)
        {
            _imageDAL.Delete(entity);
        }

        public List<Image> GetAll()
        {
            return _imageDAL.GetAll();
        }

        public Image GetByID(int id)
        {
            return _imageDAL.GetByID(id);
        }

        public void Update(Image entity)
        {
           _imageDAL.Update(entity);
        }
    }
}

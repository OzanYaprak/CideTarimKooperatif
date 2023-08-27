using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class, new()
    {
        private CideTarımDB CideTarımDB = new CideTarımDB();

        public void Add(T entity)
        {
            CideTarımDB.Add(entity);
            CideTarımDB.SaveChanges();
        }

        public void Delete(T entity)
        {
            CideTarımDB.Remove(entity);
            CideTarımDB.SaveChanges();
        }

        public List<T> GetAll()
        {
            return CideTarımDB.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return CideTarımDB.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            CideTarımDB.Update(entity);
            CideTarımDB.SaveChanges();
        }
    }
}
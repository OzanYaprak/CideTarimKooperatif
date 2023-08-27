namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class, new()
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T GetByID(int id);

        List<T> GetAll();
    }
}
namespace BusManagment.Interface
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }
}

using BusManagment.Interface;
using System.Collections.Generic;

namespace BusManagment.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _entities = new List<T>();

        public void Agregar(T entity)
        {
            _entities.Add(entity);
        }

        public void Actualizar(T entity)
        {
            // Lógica para actualizar una entidad (simplificado)
            Console.WriteLine($"Actualizando {typeof(T).Name}");
        }

        public void Remover(T entity)
        {
            _entities.Remove(entity);
        }

        public List<T> TraerTodos()
        {
            return _entities;
        }

        public T ObtenerPorId(int id)
        {
            // Asumiendo que existe una propiedad "Id" (debe implementarse en las entidades reales).
            return _entities.Find(e => (int)e.GetType().GetProperty("AsientoId")?.GetValue(e, null) == id);
        }
    }
}

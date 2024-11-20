using BusManagment.Entities;
using BusManagment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace BusManagment.Repository
//{
//    public class AsientoRepository : IAsientoRepository    {
//        public void Actualizar(Asiento asiento)
//        {

//        }
//        public void Agregar(Asiento asiento)
//        {

//        }
//        public Asiento ObtenerPorId(int asientoId)
//        {

//        }
//        public void Remover(Asiento asiento)
//        {

//        }
//        public List<Asiento>TraerTodos()
//        {

//        }

//    }
//}




namespace BusManagment.Repository
{
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        // No es necesario agregar implementación adicional
        // ya que la clase base Repository<T> cubre los métodos requeridos.
    }
}
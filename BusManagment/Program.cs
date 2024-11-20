using System;
using BusManagment.Entities;
using BusManagment.Repository;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancia del repositorio
        var asientoRepo = new AsientoRepository();

        // Crear y agregar un asiento
        var asiento1 = new Asiento
        {
            AsientoId = 1,
            BusID = 100,
            NumeroPiso = 1,
            NumeroAsiento = 20,
            FechaCreacion = DateTime.Now
        };

        asientoRepo.Agregar(asiento1);

        // Mostrar todos los asientos
        Console.WriteLine("Lista de asientos:");
        foreach (var asiento in asientoRepo.TraerTodos())
        {
            Console.WriteLine($"AsientoId: {asiento.AsientoId}, BusID: {asiento.BusID}");
        }

        // Obtener un asiento por ID
        var asientoObtenido = asientoRepo.ObtenerPorId(1);
        Console.WriteLine($"Asiento obtenido: AsientoId {asientoObtenido.AsientoId}");

        // Actualizar asiento
        asiento1.NumeroAsiento = 21;
        asientoRepo.Actualizar(asiento1);

        // Remover asiento
        asientoRepo.Remover(asiento1);
        Console.WriteLine("Asiento eliminado.");
    }
}

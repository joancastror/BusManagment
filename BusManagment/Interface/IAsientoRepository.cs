﻿using BusManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagment.Interface
{
    public interface IAsientoRepository
    {
        void Agregar(Asiento asiento);
        void Actualizar(Asiento asiento);
        void Remover(Asiento asiento);
        List<Asiento> TraerTodos();
        Asiento ObtenerPorId(int asientoId);
    }
}

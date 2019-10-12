using System;
using System.Collections.Generic;
using System.Text;
using GestionMateriales.Repository.Models;

namespace GestionMateriales.Services.Contracts
{
    public interface IPersonalService
    {
        IEnumerable<Personal> ListarTodo();

        Personal UltimoModificado();

        void CrearNuevo(Personal personal, string usuario, string ip);

        void EditarExistente(int id, Personal personalActualizado, string usuario, string ip);

        void EliminarExistente(int id, string usuario, string ip);

        Personal BuscarPersonalCon(int id);
    }
}

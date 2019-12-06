using GestionMateriales.Repository.Contracts;
using GestionMateriales.Repository.Models;
using GestionMateriales.Services.Contracts;
using GestionMateriales.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionMateriales.Services.Implementation
{
    public class PersonalService : IPersonalService
    {
        private readonly IPersonalRepository personalRepository;

        public PersonalService(IPersonalRepository personalRepository)
        {
            this.personalRepository = personalRepository;
        }

        public Personal BuscarPersonalCon(int id)
        {
            var personal = personalRepository.FindById(id);

            if (personal == null)
                throw new PersonalException("No existe el personal asociado con Id");

            return personal;
        }

        public IEnumerable<Personal> ListarTodo()
        {
            return personalRepository.GetAll();
        }

        public Personal UltimoModificado()
        {
            return personalRepository.GetLastUpdated();
        }

        public void CrearNuevo(Personal personal, string usuario, string ip)
        {
            if (personalRepository.Find(x => x.Hab).Any(x => (x.FichaCensal == personal.FichaCensal || x.Dni == personal.Dni)))
                throw new Exception("Existe personal con mismo DNI o Ficha Censal");    

            personalRepository.Add(new Personal
            {
                Nombre = personal.Nombre,
                Dni = personal.Dni,
                FichaCensal = personal.FichaCensal,
                CreatedBy = usuario,
                CreationDate = DateTime.Now,
                CreationIp = ip,
                LastUpdatedBy = usuario,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedIp = ip,
                Hab = true
            });
        }

        public void EditarExistente(int id, Personal personalActualizado, string usuario, string ip)
        {
            if (personalRepository.Find(x => x.IdPersonal != id && x.Hab).Any(y => y.FichaCensal == personalActualizado.FichaCensal || y.Dni == personalActualizado.Dni))
                throw new Exception("Existe otro personal con mismo DNI o Ficha Censal");

            var personal = BuscarPersonalCon(id);

            personal.Nombre = personalActualizado.Nombre;
            personal.Dni = personalActualizado.Dni;
            personal.FichaCensal = personalActualizado.FichaCensal;
            personal.LastUpdatedBy = usuario;
            personal.LastUpdatedDate = DateTime.Now;
            personal.LastUpdatedIp = ip;

            personalRepository.Edit(personal);
        }

        public void EliminarExistente(int id, string usuario, string ip)
        {
            var personal = BuscarPersonalCon(id);

            personal.Hab = false;
            personal.LastUpdatedBy = usuario;
            personal.LastUpdatedDate = DateTime.Now;
            personal.LastUpdatedIp = ip;

            personalRepository.Remove(personal);
        }
    }
}

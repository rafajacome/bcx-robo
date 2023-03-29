using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Extensions.Primitives;
using Qyon.AdventureServices.Domain.DataObjects.Competidores.Request;
using Qyon.AdventureServices.Domain.Entities;
using Qyon.AdventureServices.Domain.Interfaces;
using Qyon.AdventureServices.Domain.Interfaces.Competidores;
using Qyon.AdventureServices.Domain.Interfaces.Corrida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Qyon.AdventuresServices.Service.Services.Competidores
{
    public class CompetidoresService : ICompetidores
    {
        private IBaseInterface<CompetidoresEntity> repository;
        private IBaseInterface<CorridaEntity> c_repository;
        public CompetidoresService(IBaseInterface<CompetidoresEntity> repository, IBaseInterface<CorridaEntity> c_repository)
        {
            this.repository = repository;
            this.c_repository = c_repository;
        }

        public bool Create(CreateCompetidorRequest request)
        {
            var result = false;
            if (!ServiceHelpers.IsPositive(request.Altura))
                return result;

            if (!ServiceHelpers.TemperatureInBetween36And38(request.TemperaturaMediaCorpo) && !ServiceHelpers.IsPositive(request.Peso))
                return result;

            if (!ServiceHelpers.VerifyGender(request.Sexo))
                return result;

            result = repository.Create(ServiceHelpers.CreateCompetidorMapper(request));

            return result;
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public List<CompetidoresEntity> Get()
        {
            return repository.Get();
        }

        public List<CompetidoresEntity> GetCompetitorsWithoutRunning()
        {
            var corridas = c_repository.Get();
            var competidores = repository.Get();

            List<CompetidoresEntity> result = new List<CompetidoresEntity>(); 

            foreach( var competidor in competidores)
            {
                if(corridas.Where(u => u.IdCompetidor == competidor.Id).Count() < 1)
                {
                    result.Add(competidor);
                }
            }
            result.removeDuplicates();

            return result;
        }

        public bool Update(CompetidorRequest request)
        {
            var result = false;
            if (!ServiceHelpers.IsPositive(request.Altura))
                return result;

            if (!ServiceHelpers.TemperatureInBetween36And38(request.TemperaturaMediaCorpo) && !ServiceHelpers.IsPositive(request.Peso))
                return result;

            if (!ServiceHelpers.VerifyGender(request.Sexo))
                return result;

            result = repository.Update(ServiceHelpers.CompetidorMapper(request));

            return result;
        }

    }
}

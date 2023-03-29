using Qyon.AdventureServices.Domain.DataObjects.Competidores.Response;
using Qyon.AdventureServices.Domain.DataObjects.Corrida.Request;
using Qyon.AdventureServices.Domain.DataObjects.Corrida.Response;
using Qyon.AdventureServices.Domain.Entities;
using Qyon.AdventureServices.Domain.Interfaces;
using Qyon.AdventureServices.Domain.Interfaces.Corrida;
using Qyon.AdventureServices.Domain.Interfaces.Pista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Qyon.AdventuresServices.Service.Services.Corrida
{
    public class CorridaService : ICorrida
    {
        private IBaseInterface<CorridaEntity> repository;
        public CorridaService(IBaseInterface<CorridaEntity> repository)
        {
            this.repository = repository;
        }

        public bool Create(CreateCorridaRequest request)
        {
            var result = false;

            result = repository.Create(ServiceHelpers.CreateCorridaMapper(request));

            return result;
        }

        public bool Delete(int id)
        {
            var result = false;

            result = repository.Delete(id);

            return result;
        }

        public List<CorridaEntity> Get()
        {
            return repository.Get();
        }

        public List<AveragesResponse> GetCompetitorsAverage()
        {
            var corridas = repository.Get();

            var results = (from row in corridas
                           group row by row.IdCompetidor into rows
                           select new AveragesResponse
                           {
                               IdCompetitor = rows.Key,
                               TotalCompetitor = (int)rows.Average(row => row.TempoGasto)
                           }).ToList();

            return results;
        }

        public List<UsedPistaResponse> GetUsedPista()
        {
            var corridas = repository.Get();

            var results = (from row in corridas
                           group row by row.IdPista into rows
                           select new UsedPistaResponse
                           {
                               IdPista = rows.Key
                           }).ToList();

            return results;
        }

        public bool Update(CorridaRequest request)
        {
            var result = false;

            result = repository.Update(ServiceHelpers.CorridaMapper(request));

            return result;
        }
    }
}

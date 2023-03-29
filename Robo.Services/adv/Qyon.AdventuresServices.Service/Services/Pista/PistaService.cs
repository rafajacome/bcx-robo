using Microsoft.EntityFrameworkCore;
using Qyon.AdventureServices.Domain.DataObjects.Pista.Request;
using Qyon.AdventureServices.Domain.Entities;
using Qyon.AdventureServices.Domain.Interfaces;
using Qyon.AdventureServices.Domain.Interfaces.Pista;
using Qyon.AdventureServices.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qyon.AdventuresServices.Service.Services.Pista
{

    public class PistaService : IPista
    {
        private IBaseInterface<PistaEntity> repository;
        public PistaService(IBaseInterface<PistaEntity> repository)
        {
            this.repository = repository;
        }

        public bool Create(CreatePistaRequest request)
        {
    
            return repository.Create(ServiceHelpers.CreatePistaMapper(request)); ;
        }

        public bool Delete(int id)
        {
            try
            {
                return repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PistaEntity> Get()
        {
            return repository.Get();
        }

        public List<PistaEntity> GetUsed()
        {
            throw new NotImplementedException();
        }

        public bool Update(PistaRequest request)
        {
            return repository.Update(ServiceHelpers.PistaMapper(request));
        }

    }
}


using Robo.Services.Domain.DataObjects.Request;
using Robo.Services.Domain.Entities;
using Robo.Services.Domain.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Robo.Services.Service.Corrida
{
    public class HeadService : IHead
    {
        private IBaseInterface<HeadEntity> repository;
        public HeadService(IBaseInterface<HeadEntity> repository)
        {
            this.repository = repository;
        }

        public bool ChangeInclination(InclinationRequest request)
        {
            var result = false;

            var head = repository.Get();

            if (head is null)
                return false;

            if (!ServiceHelpers.IsInStateRange(head.InclinationState, request.InclinationState))
                return false;

            result = repository.Update(ServiceHelpers.InclinationMapper(request));

            return result;
        }

        public bool ChangeRotation(RotationRequest request)
        {
            var result = false;

            var head = repository.Get();

            if (head is null)
                return false;

            if (!ServiceHelpers.CanChangeHeadState(head.InclinationState))
                return false;

            if (!ServiceHelpers.IsInStateRange(head.RotationState, request.RotationState))
                return false;

            result = repository.Update(ServiceHelpers.RotationMapper(request));

            return result;
        }

        public HeadEntity GetState()
        {
            return repository.Get();
        }


    }
}

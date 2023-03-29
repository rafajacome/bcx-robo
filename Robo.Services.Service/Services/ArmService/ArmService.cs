
using Robo.Services.Domain.DataObjects.Request;
using Robo.Services.Domain.Entities;
using Robo.Services.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Robo.Services.Service.Competidores
{
    public class ArmService : IArm
    {
        private IBaseInterface<ArmEntity> repository;
        private IBaseInterface<HeadEntity> c_repository;
        public ArmService(IBaseInterface<ArmEntity> repository, IBaseInterface<HeadEntity> c_repository)
        {
            this.repository = repository;
            this.c_repository = c_repository;
        }

        public bool ChangeElbowState(ElbowRequest request)
        {
            var result = false;

            var arm = repository.GetList();

            if (arm is null)
                return false;

            var selectedArm = arm.Where(u => u.Side == request.Side).FirstOrDefault();

            if (!ServiceHelpers.IsInStateRange(selectedArm.ElbowState, request.ElbowState))
                return false;

            result = repository.Update(ServiceHelpers.ElbowMapper(request, selectedArm));

            return result;
        }

        public bool ChangeFistState(FistRequest request)
        {
            var result = false;

            var arm = repository.GetList();

            if (arm is null)
                return false;

            var selectedArm = arm.Where(u => u.Side == request.Side).FirstOrDefault();

            if (!ServiceHelpers.CanChangeFistState(selectedArm.ElbowState))
                return false;

            if (!ServiceHelpers.IsInStateRange(selectedArm.FistState, request.FistState))
                return false;

                result = repository.Update(ServiceHelpers.FistMapper(request, selectedArm));

            return result;
        }

        public List<ArmEntity> GetListState()
        {
            return repository.GetList();
        }

        public ArmEntity GetState()
        {
            return repository.Get();
        }
    }
}

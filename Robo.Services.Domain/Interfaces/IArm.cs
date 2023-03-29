using Robo.Services.Domain.DataObjects.Request;
using Robo.Services.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robo.Services.Domain.Interfaces
{
    public interface IArm
    {
        public ArmEntity GetState();
        public List<ArmEntity> GetListState();
        public bool ChangeFistState(FistRequest request);
        public bool ChangeElbowState(ElbowRequest request);

    }
}

using Robo.Services.Domain.DataObjects.Request;
using Robo.Services.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robo.Services.Domain.Interfaces
{
    public interface IHead
    {
        public HeadEntity GetState();
        public bool ChangeInclination(InclinationRequest request);
        public bool ChangeRotation(RotationRequest request);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.DataObjects.Request
{
    public class RotationRequest
    {
        public int Id { get; set; }
        public int RotationState { get; set; }
    }
}

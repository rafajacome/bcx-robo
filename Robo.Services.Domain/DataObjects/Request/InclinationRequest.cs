using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.DataObjects.Request
{
    public class InclinationRequest
    {
        public int Id { get; set; }
        public int InclinationState { get; set; }
    }
}

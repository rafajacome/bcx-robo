using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Robo.Services.Domain.Entities
{
    public class HeadEntity : BaseEntity
    {
        public int RotationState { get; set; }
        public int InclinationState { get; set; }
    }
}

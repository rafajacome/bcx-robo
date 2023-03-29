using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Robo.Services.Domain.Entities
{
    public class ArmEntity : BaseEntity
    {
        public int Side { get; set; }
        public int FistState { get; set; }
        public int ElbowState { get; set; }
    }
}

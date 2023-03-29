using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.DataObjects.Request
{
    public class ArmResponse
    {
        public int Id { get; set; }
        public int FistState { get; set; }
        public int ElbowState { get; set; }
    }
}

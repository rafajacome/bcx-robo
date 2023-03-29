using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.Models
{
    public class Arm
    {
        public int Side { get; set; }
        public int FistState { get; set; }
        public int ElbowState { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.Models
{
    public class Head
    {
        public int RotationState { get; set; }
        public int InclinationState { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.DataObjects.Request
{
    public class ElbowRequest
    {
        public int Id { get; set; }
        public int Side { get; set; }
        public int ElbowState { get; set; }    
    }
}

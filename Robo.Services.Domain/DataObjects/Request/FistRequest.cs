using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Robo.Services.Domain.DataObjects.Request
{
    public class FistRequest
    {
        public int Id { get; set; }
        public int Side { get; set; }
        public int FistState { get; set; }
    }
}

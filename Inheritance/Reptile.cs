using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
         public bool HasScales { get; set; }
         public bool IsColdBlooded { get; set; }
         public bool DoesNotSweat { get; set; }
         public string ReptileNoOneLikes { get; set; }
    }
}

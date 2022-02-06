using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeExcercise
{
    public interface IPet:IOwner
    {
        int NumberOfVisits { get; set; }
        double CostPerVisit { get; set; }
    }
}

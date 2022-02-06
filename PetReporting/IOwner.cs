using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeExcercise
{
    public interface IOwner
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        DateTime JoinedPractice { get; set; }
    }
}

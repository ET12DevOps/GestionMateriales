using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Services.Exceptions
{
    public class PersonalException : Exception
    {
        public PersonalException()
        {

        }

        public PersonalException(string message) : base(message)
        {
        }
    }
}

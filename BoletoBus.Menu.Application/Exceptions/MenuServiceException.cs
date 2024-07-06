using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Menu.Application.Exceptions
{
    public class MenuServiceException : Exception
    {
        public MenuServiceException(string message) : base(message)
        {

        }
    }
}

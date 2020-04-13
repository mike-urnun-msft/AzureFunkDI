using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunkDI
{
    class Greeter : IGreeter
    {
        public string CreateGreeting(string name)
        {
            return $"Sain bain uu, {name}!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class AnotherValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}

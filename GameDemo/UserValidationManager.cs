using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager: IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.YearOfBirth == 1994 && gamer.Name == "ECE" && gamer.Surname == "ÖRÜCÜ"
                && gamer.IdentityNumber==00000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

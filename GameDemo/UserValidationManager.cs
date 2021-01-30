using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager: IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.YearOfBirth == 1985 && gamer.Name == "Engin" && gamer.Surname == "Demiroğ"
                && gamer.IdentityNumber==12345)
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

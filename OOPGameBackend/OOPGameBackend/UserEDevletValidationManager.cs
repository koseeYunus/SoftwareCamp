using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGameBackend
{
    class UserEDevletValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.IdentityNumber == 12312312312 && gamer.FirstName == "Engin" && gamer.LastName == "Demiroğ" && gamer.BirthYear == 1989)
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

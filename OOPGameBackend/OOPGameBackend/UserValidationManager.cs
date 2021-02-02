using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGameBackend
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.FirstName=="Yunus" && gamer.LastName=="Köse" && gamer.BirthYear == 1996)
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

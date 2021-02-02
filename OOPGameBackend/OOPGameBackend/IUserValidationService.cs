using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGameBackend
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}

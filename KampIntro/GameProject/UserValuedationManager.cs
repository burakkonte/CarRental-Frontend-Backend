using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValuedationManager : IUserValuedationService
    {
        public bool Valuedate(Gamer gamer)
        {
            if (gamer.FirstName == "Engin" && gamer.LastName == "Demiroğ" && gamer.BirthYear== 1985 && gamer.IdentityNumber == 12312123)
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

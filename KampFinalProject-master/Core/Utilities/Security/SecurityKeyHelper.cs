using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreteSecurityKey(string securrityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securrityKey));
        }
    }
}

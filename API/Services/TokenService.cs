using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        //___ code to create Toke ____
        //___ Registored this services in   Startup file 
        public string CreateToken(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
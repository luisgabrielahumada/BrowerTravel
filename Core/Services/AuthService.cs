using Common.Infrastructure;
using System;
using BrowerTravel.Dto.Auth;
using BrowerTravel.Mapper.Interface;
using BrowerTravel.Repository.Interface;
using BrowerTravel.Services.Interface;

namespace BrowerTravel.Services
{
    public class AuthService : IAuth
    {
        public IAuthRepository _db;
        public readonly Settings _settings;
        public readonly IAuthMapper _map;
        public AuthService(IAuthMapper map, IAuthRepository db)
        {
            _map = map;
            _db = db;
        }
        public TokenDto Login(UserDto req)
        {
            var user  = _map.MapearUser(req);
            // Access to the database.
            var resp = _db.Login(user);
           
            return resp;
        }
    }
}

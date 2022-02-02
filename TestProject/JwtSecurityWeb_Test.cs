using Common.Infrastructure;
using JwtSecurity;
using NUnit.Framework;
using System;
using BrowerTravel.Dto.Auth;

namespace TestProject
{
    public class JwtSecurityWeb_Test
    {
        JwtSecurityWeb jwt;
        Settings setting;
        [SetUp]
        public void Setup()
        {
            jwt = new JwtSecurityWeb();
            
            setting = new Settings
            {
                Jwt = new Jwt
                {
                    Issuer = "BrowerTravel",
                    Key = "asdv234234^&%&^%&^hjsdfb2%%%"
                }
            };
        }

        [Test]
        public void GenerateJSONWebToken_Success()
        {
            var token = new TokenDto
            {
                Email = "luisgabrielahumada@gmail.com",
                Login = "lahumada",
                Name = "Luis G Ahumada",
                SessionId = Guid.NewGuid().ToString(),
                UserId = 1
            };
            token.Token = jwt.GenerateJSONWebToken(token, setting);
            Assert.IsNotNull(token.Token);
        }

        [Test]
        public void GenerateJSONWebToken_Fail()
        {
            var token = new TokenDto
            {
                Email = "luisgabrielahumada@gmail.com",
                Login = "lahumada",
                Name = "Luis G Ahumada",
                SessionId = Guid.NewGuid().ToString(),
                UserId = 1
            };
            token.Token = jwt.GenerateJSONWebToken(token, setting);
            Assert.IsNotNull(token.Token);
        }
    }
}

using BrowerTravel.Domain.Auth;
using BrowerTravel.Dto.Auth;
using BrowerTravel.Mapper.Interface;

namespace BrowerTravel.Mapper
{
    public class AuthMapper : IAuthMapper
    {
        public TokenDto MapearTokenDto(User req)
        {
            var token = new TokenDto
            {
                Email = req.Email,
                Login = req.Login,
                Name = req.Name,
            };

            return token;
        }

        public User MapearUser(UserDto req)
        {
            var user = new User
            {
                Login = req.Login,
                Password = req.Password
            };
            return user;
        }
    }
}

using BrowerTravel.Dto.Auth;

namespace BrowerTravel.Services.Interface
{
    public interface IAuth
    {
        TokenDto Login(UserDto req);
    }
}

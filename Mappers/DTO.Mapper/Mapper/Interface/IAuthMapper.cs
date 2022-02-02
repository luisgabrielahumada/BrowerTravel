using BrowerTravel.Domain.Auth;
using BrowerTravel.Dto.Auth;

namespace BrowerTravel.Mapper.Interface
{
    public interface IAuthMapper
    {
        User MapearUser(UserDto req);
        TokenDto MapearTokenDto(User req);
    }
}

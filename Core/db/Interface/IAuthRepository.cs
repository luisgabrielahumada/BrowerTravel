using Common.Infrastructure;
using BrowerTravel.Domain.Auth;
using BrowerTravel.Dto.Auth;

namespace BrowerTravel.Repository.Interface
{
    public interface IAuthRepository
    {
        TokenDto Login(User req);
    }
}

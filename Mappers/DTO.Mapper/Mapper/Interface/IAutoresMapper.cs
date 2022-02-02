using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Travel;

namespace BrowerTravel.Mapper.Interface
{
    public interface IAutoresMapper
    {
        Autores MapearAutores(AutoresDto req);
        AutoresDto MapearAutoresDto(Autores req);

    }
}

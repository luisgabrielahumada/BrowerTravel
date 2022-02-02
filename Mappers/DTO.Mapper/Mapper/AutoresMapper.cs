using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Travel;
using BrowerTravel.Mapper.Interface;
using System.Linq;

namespace BrowerTravel.Mapper
{
    public class AutoresMapper : IAutoresMapper
    {
        public Autores MapearAutores(AutoresDto req)
        {
            var resp = new Autores
            {
                Apellido = req.Apellido,
                Id = req.Id,
                Nombre = req.Nombre
            };
            return resp;
        }

        public AutoresDto MapearAutoresDto(Autores req)
        {
            var resp = new AutoresDto
            {
                Apellido = req.Apellido,
                Id = req.Id,
                Nombre = req.Nombre
            };
            return resp;
        }
    }
}

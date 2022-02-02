using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Travel;
using System.Collections.Generic;

namespace BrowerTravel.Mapper.Interface
{
    public interface ILibroMapper
    {
        Libro MapearNuevoLibro(NuevoLibroDto req);
        Libro MapearLibro(LibroDto req);
        List<LibroDto> MapearLibrosDto(List<Libro> req);
        LibroDto MapearLibroDto(Libro req);

    }
}

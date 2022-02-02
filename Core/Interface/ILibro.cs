using Core.Component.Library.PagerRecord;
using BrowerTravel.Dto.Travel;
using BrowerTravel.Dto.Common;

namespace BrowerTravel.Services.Interface
{
    public interface ILibro
    {
        WebPagerRecord<LibroDto> Listar(PaginationDto req);
        int Crear(NuevoLibroDto req);
        LibroDto Obtener(int id);
        int Actualizar(int id, LibroDto req);
        void Eliminar(int id);
    }
}

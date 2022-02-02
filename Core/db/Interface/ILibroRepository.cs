using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Common;
using System.Collections.Generic;

namespace BrowerTravel.Repository.Interface
{
    public interface ILibroRepository
    {
        int ContarRegistos();
        List<Libro> Listar(PaginationDto req);
        int Create(Libro req);
        int Actualizar(int id, Libro req);
        void Delete(int id);
        Libro Obtener(int id);
    }
}

using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Travel;
using BrowerTravel.Mapper.Interface;
using System.Collections.Generic;
using System.Linq;

namespace BrowerTravel.Mapper
{
    public class LibroMapper : ILibroMapper
    {
        public Libro MapearLibro(NuevoLibroDto req)
        {
            var resp = new Libro
            {
                N_Paginas = req.N_Paginas,
                Sinopsis = req.Sinopsis,
                Titulo = req.Titulo,
                Editoriales_Id = req.Editorial.Id
            };
            return resp;
        }

        public Libro MapearLibro(LibroDto req)
        {
            var resp = new Libro
            {
                ISBN=req.ISBN,
                N_Paginas = req.N_Paginas,
                Sinopsis = req.Sinopsis,
                Titulo = req.Titulo,
                Editoriales_Id = req.Editorial.Id
            };
            return resp;
        }

        public LibroDto MapearLibroDto(Libro req)
        {
            var resp = new LibroDto
            {
                ISBN = req.ISBN,
                N_Paginas = req.N_Paginas,
                Sinopsis = req.Sinopsis,
                Titulo = req.Titulo,
                Editorial = new EditorialesDto
                {
                    Id = req.Editoriales_Id
                }
            };
            return resp;
        }

        public List<LibroDto> MapearLibrosDto(List<Libro> req)
        {
            return req.Select(m => new LibroDto
            {
                Titulo = m.Titulo,
                Sinopsis = m.Sinopsis,
                N_Paginas = m.N_Paginas,
                ISBN = m.ISBN,
                Editorial = new EditorialesDto
                {
                    Id = m.Editoriales_Id
                }
            }).ToList();
        }

        public Libro MapearNuevoLibro(NuevoLibroDto req)
        {
            var resp = new Libro
            {
                N_Paginas = req.N_Paginas,
                Sinopsis = req.Sinopsis,
                Titulo = req.Titulo,
                Editoriales_Id = req.Editorial.Id
            };
            return resp;
        }
    }
}

using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Travel;
using System.Collections.Generic;

namespace TestProject.Helper
{
    public static class LibroTest
    {
        public static List<Libro> Libros()
        {
            return new List<Libro>
            {
                new Libro
                {
                    Editoriales_Id=1,
                    ISBN = 1,
                    N_Paginas = "188",
                    Sinopsis = "",
                    Titulo = "EL MENSAJERO DE AGARTHA. ZOMBIES"
                },
                new Libro
                {
                    Editoriales_Id=2,
                    ISBN = 1,
                    N_Paginas = "208",
                    Sinopsis = "",
                    Titulo = "UNA PANDILLA SALVAJE"
                },
                new Libro
                {
                   Editoriales_Id=3,
                    ISBN = 1,
                    N_Paginas = "146",
                    Sinopsis = "",
                    Titulo = "EL REY DEL MUNDO"
                },
                new Libro
                {
                   Editoriales_Id=4,
                    ISBN = 1,
                    N_Paginas = "560",
                    Sinopsis = "",
                    Titulo = "ESCRITO EN EL AGUA"
                },
                 new Libro
                 {
                    Editoriales_Id=5,
                    ISBN = 1,
                    N_Paginas = "315",
                    Sinopsis = "",
                    Titulo = "MALDITO KARMA"
                 },
            };
        }

        public static LibroDto Crear()
        {
            return new LibroDto
            {
                Editorial = new EditorialesDto
                {
                    Id = 1,
                    Nombre = "Planeta Lector",
                    Sede = "Principal"
                },
                ISBN = 1,
                N_Paginas = "188",
                Sinopsis = "",
                Titulo = "EL MENSAJERO DE AGARTHA. ZOMBIES"
            };
        }

        public static Libro Obtener()
        {
            return new Libro
            {
                Editoriales_Id=1,
                ISBN = 1,
                N_Paginas = "188",
                Sinopsis = "",
                Titulo = "EL MENSAJERO DE AGARTHA. ZOMBIES"
            };
        }
    }
}

using BrowerTravel.Dto.Travel;
using System.Collections.Generic;

namespace TestProject.Helper
{
    public static class LibroDtoTest
    {
        public static List<LibroDto> Libros()
        {
            return new List<LibroDto>
            {
                new LibroDto
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
                },
                new LibroDto
                {
                    Editorial = new EditorialesDto
                    {
                        Id = 2,
                        Nombre = "Planeta Lector",
                        Sede = "Principal"
                    },
                    ISBN = 1,
                    N_Paginas = "208",
                    Sinopsis = "",
                    Titulo = "UNA PANDILLA SALVAJE"
                },
                new LibroDto
                {
                    Editorial = new EditorialesDto
                    {
                        Id = 3,
                         Nombre = "Planeta Lector",
                        Sede = "Principal"
                    },
                    ISBN = 1,
                    N_Paginas = "146",
                    Sinopsis = "",
                    Titulo = "EL REY DEL MUNDO"
                },
                new LibroDto
                {
                    Editorial = new EditorialesDto
                    {
                        Id = 4,
                        Nombre = "Booket",
                        Sede = "Principal"
                    },
                    ISBN = 1,
                    N_Paginas = "560",
                    Sinopsis = "",
                    Titulo = "ESCRITO EN EL AGUA"
                },
                 new LibroDto
                 {
                    Editorial = new EditorialesDto
                    {
                        Id = 5,
                         Nombre = "Planeta Booket",
                        Sede = "Principal"
                    },
                    ISBN = 1,
                    N_Paginas = "315",
                    Sinopsis = "",
                    Titulo = "MALDITO KARMA"
                 },
            };
        }

        public static NuevoLibroDto Crear()
        {
            return new NuevoLibroDto
            {
                Editorial = new EditorialesDto
                {
                    Id = 1,
                    Nombre = "Planeta Lector",
                    Sede = "Principal"
                },
                N_Paginas = "188",
                Sinopsis = "",
                Titulo = "EL MENSAJERO DE AGARTHA. ZOMBIES"
            };
        }

        public static LibroDto Actualizar()
        {
            return new LibroDto
            {
                Editorial = new EditorialesDto
                {
                    Id = 1,
                    Nombre = "Planeta Lector",
                    Sede = "Principal"
                },
                ISBN =1,
                N_Paginas = "188",
                Sinopsis = "",
                Titulo = "EL MENSAJERO DE AGARTHA. ZOMBIES"
            };
        }

        public static LibroDto Obtener()
        {
            return new LibroDto
            {
                Editorial = new EditorialesDto
                {
                    Id = 1,
                },
                ISBN = 1,
                N_Paginas = "188",
                Sinopsis = "",
                Titulo = "EL MENSAJERO DE AGARTHA. ZOMBIES"
            };
        }
    }
}

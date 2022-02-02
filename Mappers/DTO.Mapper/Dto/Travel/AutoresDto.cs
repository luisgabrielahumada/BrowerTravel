using System.Collections.Generic;

namespace BrowerTravel.Dto.Travel
{
    public class AutoresDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<LibroDto> Libros { get; set; }

    }
}

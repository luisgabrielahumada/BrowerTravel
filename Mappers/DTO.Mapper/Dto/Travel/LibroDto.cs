namespace BrowerTravel.Dto.Travel
{
    public class LibroDto
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string N_Paginas { get; set; }
        public EditorialesDto Editorial { get; set; }
    }
}

namespace BrowerTravel.Domain.Travel
{
    public class Libro
    {
        public int ISBN { get; set; }
        public int Editoriales_Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string N_Paginas { get; set; }
    }
}

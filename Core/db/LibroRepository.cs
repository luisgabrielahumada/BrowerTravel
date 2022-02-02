using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Common;
using BrowerTravel.Repository;
using BrowerTravel.Repository.Interface;
using Common.Infrastructure;
using Core.Component.Library.SQL;
using System.Collections.Generic;
using System.Linq;

namespace BrowerTravel.Services
{
    public class LibroRepository : ILibroRepository
    {
        readonly AppDatabase db;
        Settings _settings;
        public LibroRepository(Settings settings)
        {
            _settings = settings;
            db = new AppDatabase(settings.ConnectionStrings.ConnectionString);
        }
        public List<Libro> Listar(PaginationDto req)
        {
            var data = new Execute(db, "DB_ListaLibros",
                                  new
                                  {
                                      pageIndex = req.PageIndex,
                                      pageSize = req.PageSize,
                                  })
                                  .Procedure<Libro>()
                                  .ToList();
            return data;
        }
        public int Create(Libro req)
        {
            return new Execute(db, "DB_Create",
                                     new
                                     {
                                         Titulo = req.Titulo,
                                         Sinopsis = req.Sinopsis,
                                         N_Paginas = req.N_Paginas,
                                         Editoriales_Id = req.Editoriales_Id,
                                     })
                                     .Procedure<int>()
                                     .FirstOrDefault();
        }
        public int Actualizar(int id, Libro req)
        {
           return new Execute(db, "DB_Actualizar",
                                     new
                                     {
                                         ISBN = id,
                                         Titulo = req.Titulo,
                                         Sinopsis = req.Sinopsis,
                                         N_Paginas = req.N_Paginas,
                                         Editoriales_Id = req.Editoriales_Id,
                                     })
                                     .Procedure<int>()
                                     .FirstOrDefault();
        }
        public void Delete(int id)
        {
            new Execute(db, "DB_Delete",
                                    new
                                    {
                                        ISBN = id,
                                    })
                                    .Procedure<int>()
                                    .FirstOrDefault();
        }
        public Libro Obtener(int id)
        {
           return new Execute(db, "DB_Obtener",
                                    new
                                    {
                                        ISBN = id,
                                    })
                                    .Procedure<Libro>()
                                    .FirstOrDefault();
        }
        public int ContarRegistos()
        {
            var data = new Execute(db, "DB_ContarRegistos",
                                 new
                                 {
                                 })
                                 .Procedure<int>()
                                 .FirstOrDefault();
            return data;
        }
    }
}
using BrowerTravel.Domain.Travel;
using BrowerTravel.Dto.Common;
using BrowerTravel.Dto.Travel;
using BrowerTravel.Mapper.Interface;
using BrowerTravel.Repository.Interface;
using BrowerTravel.Services;
using Common.Infrastructure;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Helper;

namespace TestProject
{
    public class Libro_Test
    {
        private Mock<ILibroMapper> iLibroMapper;
        private Mock<ILibroRepository> iLibroRepository;
        private LibroService libroService;
        private PaginationDto req;
        [SetUp]
        public void Setup()
        {
            iLibroRepository = new Mock<ILibroRepository>();
            iLibroMapper = new Mock<ILibroMapper>();
            Settings settings = new Settings
            {
                Storage = new Storage
                {
                    ConnectionString = "DefaultEndpointsProtocol=https;AccountName=BrowerTravel;AccountKey=Q7PG9A7+/LgEcp3Wh0xl5Mz0+ZJH1/Uj0vaAQ43iYzmYKj6gDAZ94VsXvfm6iA5ABs7GcvRonBkTrfwLOADpJQ==;EndpointSuffix=core.windows.net",
                    ContaninerName = "attachments"
                }
            };
            libroService = new LibroService(iLibroMapper.Object, iLibroRepository.Object, settings);
            req = new PaginationDto
            {
                PageIndex = 1,
                PageSize = 20
            };
        }

        [Test]
        public void Listar_Exitosa()
        {
            iLibroRepository.Setup(p => p.Listar(It.IsAny<PaginationDto>())).Returns(LibroTest.Libros());
            iLibroMapper.Setup(p => p.MapearLibrosDto(It.IsAny<List<Libro>>())).Returns(LibroDtoTest.Libros());
            var resp = libroService.Listar(req);
            Assert.IsTrue(resp.items.Count() > 0);
        }

        [Test]
        public void Listar_Fallida()
        {
            iLibroRepository.Setup(p => p.Listar(It.IsAny<PaginationDto>())).Returns(new List<Libro>());
            iLibroMapper.Setup(p => p.MapearLibrosDto(It.IsAny<List<Libro>>())).Returns(new List<LibroDto>());
            var resp = libroService.Listar(req);
            Assert.IsFalse(resp.items.Count() >0);
        }


        [Test]
        public void Crear_libro_exitoso()
        {
            iLibroRepository.Setup(p => p.Create(It.IsAny<Libro>())).Returns(1);
            var resp = libroService.Crear(LibroDtoTest.Crear());
            Assert.IsTrue(resp > 0);
        }

        [Test]
        public void Crear_libro_exitoso_fallido()
        {
            iLibroRepository.Setup(p => p.Create(It.IsAny<Libro>())).Returns(0);
            var resp = libroService.Crear(LibroDtoTest.Crear());
            Assert.IsFalse(resp > 0);
        }


        [Test]
        public void Actualizar_exitoso()
        {
            iLibroRepository.Setup(p => p.Actualizar(It.IsAny<int>(), It.IsAny<Libro>()));
            libroService.Actualizar(1, LibroDtoTest.Actualizar());
            Assert.IsTrue(true);
        }

        [Test]
        public void Actualizar_fallido()
        {
            iLibroRepository.Setup(p => p.Actualizar(It.IsAny<int>(), It.IsAny<Libro>()));
            var ex = Assert.Throws<Exception>(() => libroService.Actualizar(0, LibroDtoTest.Actualizar()));
            Assert.AreEqual("El ISBN tiene que ser mayor que cero", ex.Message);
        }
    }
}
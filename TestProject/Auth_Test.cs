using Moq;
using NUnit.Framework;
using TestProject.Helper;
using BrowerTravel.Domain.Auth;
using BrowerTravel.Dto.Auth;
using BrowerTravel.Mapper.Interface;
using BrowerTravel.Repository.Interface;
using BrowerTravel.Services;

namespace TestProject
{
    public class Auth_Test
    {
        private Mock<IAuthMapper> iAuthMapper;
        private Mock<IAuthRepository> iAuthRepository;
        private AuthService authService;
        [SetUp]
        public void Setup()
        {
            iAuthRepository = new Mock<IAuthRepository>();
            iAuthMapper = new Mock<IAuthMapper>();
            authService = new AuthService(iAuthMapper.Object, iAuthRepository.Object);
        }

        [Test]
        public void Login_password_exitoso()
        {
            iAuthRepository.Setup(p => p.Login(It.IsAny<User>())).Returns(TokenDtoTest.TokenSuccessDto());
            var resp = authService.Login(It.IsAny<UserDto>());
            Assert.AreEqual(TokenDtoTest.TokenSuccessDto().Token, resp.Token);
        }

        [Test]
        public void Login_password_fallido()
        {
            iAuthRepository.Setup(p => p.Login(It.IsAny<User>())).Returns(TokenDtoTest.ReturnTokenFailDto());
            var resp = authService.Login(It.IsAny<UserDto>());
            Assert.AreEqual(null, resp.Token);
        }
    }
}
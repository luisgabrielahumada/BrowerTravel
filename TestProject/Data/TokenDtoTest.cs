using BrowerTravel.Dto.Auth;

namespace TestProject.Helper
{
    public static class TokenDtoTest
    {
        public static TokenDto TokenSuccessDto()
        {
            return new TokenDto
            {
                UserId = 0,
                Login = "lahumada",
                Email = "luisgabrielahumada@gmail.com",
                Name = "Luis G Ahumada",
                Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI2OGZiY2I2My01MDk2LTQ4ZTItOWUzNS00Yjk0NjliODNlOGUiLCJuYW1lIjoiTHVpcyBHIEFodW1hZGEiLCJlbWFpbCI6Imx1aXNnYWJyaWVsYWh1bWFkYUBnbWFpbC5jb20iLCJpYXQiOiI2Mzc3MjkyNjg4Njk1MDI0NjIiLCJ1bmlxdWVfbmFtZSI6IjAiLCJqdGkiOiIxMzIxM2U5NS0yMmVlLTRjMjQtYjdjYy03ZjVhYmFlODZjY2QiLCJleHAiOjE2MzczMzcyODYsImlzcyI6IldlZWxvIiwiYXVkIjoiV2VlbG8ifQ.8XUkcauDjyPzQ3L6wclB0FO6Cx2eBS7KdIdr3WaN0XQ",
                SessionId = "68fbcb63-5096-48e2-9e35-4b9469b83e8e",
            };
        }

        public static TokenDto ReturnTokenFailDto()
        {
            return new TokenDto
            {
                UserId = 0,
                Login = null,
                Email = null,
                Name = null,
                Token = null,
                SessionId = null
            };
        }
    }
}

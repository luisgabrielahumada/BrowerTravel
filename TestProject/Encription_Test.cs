using Common.Infrastructure.Helper;
using NUnit.Framework;

namespace TestProject
{
    public class Encription_Test
    {
        public const string TOKEN = "SUkbqO2ycDo7QwpR25kfgmC7f8CoyrZy";
        public const string PASSWORD_OK = "abc123$$";
        public const string PASSWORD_FAILD = "abc123$$$";
        public const string ENCRYPTED_TOKEN = "BWFEZa+/Ci32Y4gSQQNiW/kvFpic9qzx/f2wPLuRG48=";
        Encription cyp;
        [SetUp]
        public void Setup()
        {
            cyp = Encription.GetInstance(TOKEN);
        }

        [Test]
        public void Encrypt_Success()
        {

            var pass = cyp.Encrypt(PASSWORD_OK);
            Assert.AreEqual(ENCRYPTED_TOKEN, pass);
        }

        [Test]
        public void Encrypt_Fail()
        {
            var pass = cyp.Encrypt(PASSWORD_FAILD);
            Assert.AreNotEqual(ENCRYPTED_TOKEN, pass);
        }

        public void Decrypt_Success()
        {

            var pass = cyp.Decrypt(ENCRYPTED_TOKEN);
            Assert.AreEqual(PASSWORD_OK, pass);
        }

        [Test]
        public void Decrypt_Fail()
        {
            var pass = cyp.Decrypt(ENCRYPTED_TOKEN);
            Assert.AreNotEqual(PASSWORD_FAILD, pass);
        }
    }
}

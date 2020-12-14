using NUnit.Framework;
using Desafio.Model;

namespace Desafio.testes.Familia
{
    class PessoaTestes
    {
        [SetUp]
        public void Setup() { }


        [Test]
        public void DeveCalcularIdadeCorretamente()
        {
            Pessoa p = new Pessoa("123123", "Milton Romero", "pretendente", "1996-12-30"); 

            Assert.AreEqual(23, p.getIdade("2020-12-13"));
        }
    }
}

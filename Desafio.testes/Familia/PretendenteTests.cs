using NUnit.Framework;
using System;
using Desafio.Model;
using static Desafio.Model.Enum;

namespace Desafio.testes.Familia
{
    class PretendenteTests
    {
        [SetUp]
        public void Setup() { }

        
        [Test]
        public void DeveCalcularIdadeCorretamente()
        {
            Pretendente p = new Pretendente("123123", "Milton Romero", new DateTime(1996, 12, 30)); 

            //Será necessário atualizar idade a cada ano!
            Assert.AreEqual(23, p.getIdade());
        }
    }
}

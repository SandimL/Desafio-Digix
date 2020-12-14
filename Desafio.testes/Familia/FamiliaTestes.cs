using NUnit.Framework;
using System;
using Desafio.Model;
using System.Collections.Generic;

namespace Desafio.testes.Familia
{
    class FamiliaTestes
    {
        [SetUp]
        public void Setup()  { }

        public Model.Familia gerarFamiliaTeste()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa p1 = new Pessoa("111111", "Milton Romero", "Pretendente", "1998-05-30");
            Pessoa p2 = new Pessoa("222222", "Milton teste1", "Cônjuge", "1996-12-30");
            Pessoa p3 = new Pessoa("333333", "Milton teste2", "Dependente", "2010-02-28");
            Pessoa p4 = new Pessoa("444444", "Milton teste3", "Dependente", "1990-01-30");
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);

            List<Renda> rendas = new List<Renda>();
            Renda r1 = new Renda("111111", 500);
            Renda r2 = new Renda("222222", 450);
            Renda r3 = new Renda("333333", 150);
            rendas.Add(r1);
            rendas.Add(r2);
            rendas.Add(r3);

            return new Model.Familia("000000", pessoas, rendas, "2", 0);
        }

        [Test]
        public void DeveCalcularRendaTotalCorretamente()
        {
            Model.Familia familia = gerarFamiliaTeste();

            Assert.AreEqual(1100, familia.calculaRendaTotal());
        }

        [Test]
        public void DeveCalcularPontosPorRendaTotalCorretamente()
        {
            Model.Familia familia = gerarFamiliaTeste();

            Assert.AreEqual(3, familia.calculaPontosPorRendaTotal());
        }

        [Test]
        public void DeveCalcularPontosPorIdadeDoPretendenteCorretamente()
        {
            Model.Familia familia = gerarFamiliaTeste();

            Assert.AreEqual(1, familia.calculaPontosPorIdadeDoPretendente());
        }

        [Test]
        public void DeveCalcularPontosPorQtdDependentesCorretamente()
        {
            Model.Familia familia = gerarFamiliaTeste();

            Assert.AreEqual(2, familia.calculaPontosPorQtdDependentes());
        }

        [Test]
        public void DeveCalcularPontuacaoTotalCorretamente()
        {
            Model.Familia familia = gerarFamiliaTeste();

            familia.calculaPontuacaoTotal();

            Assert.AreEqual(6, familia.Pontuacao);
        }
    }
}

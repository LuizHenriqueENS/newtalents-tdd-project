using System;
using NewTalents.Console.Services;
using Xunit;

namespace NewTalents.Tests
{
    public class CalculadoraTests
    {
        private Calculadora _calc = new Calculadora();

        public CalculadoraTests()
        {
            _calc = new Calculadora();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestarSomar(int valor1, int valor2, int resultadoSoma)
        {
            // ARRANGE || 
            int soma = _calc.Somar(valor1, valor2);
            // ACT
            int resultado = soma;
            // ASSERT
            Assert.Equal(resultadoSoma, resultado);
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestarSubtrair(int valor1, int valor2, int resultadoSubtracao)
        {
            // ARRANGE || 
            int subtracao = _calc.Subtrair(valor1, valor2);
            // ACT
            int resultado = subtracao;
            // ASSERT
            Assert.Equal(resultadoSubtracao, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(5, 5, 1)]
        public void TestarDividir(int valor1, int valor2, int resultadoDivisao)
        {
            // ARRANGE || 
            int divisao = _calc.Dividir(valor1, valor2);
            // ACT
            int resultado = divisao;
            // ASSERT
            Assert.Equal(resultadoDivisao, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestarMultiplicar(int valor1, int valor2, int resultadoSoma)
        {
            // ARRANGE || 
            int multiplicacao = _calc.Multiplicar(valor1, valor2);
            // ACT
            int resultado = multiplicacao;
            // ASSERT
            Assert.Equal(resultadoSoma, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                _calc.Dividir(3, 0);
            });
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 2);
            _calc.Somar(2, 8);
            _calc.Somar(3, 7);
            _calc.Somar(4, 1);

            var lista = _calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}

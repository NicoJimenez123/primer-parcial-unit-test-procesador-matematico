using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace ProcesadorMatematicoTester
{
    public class TestSumar
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        public void Sumar2ValoresEnterosPositivos(int a, int b, int resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Sumar(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }

        [Theory]
        [InlineData(-1, -2, 0)]
        [InlineData(-3, -3, 0)]
        public void Sumar2ValoresEnterosNegativos(int a, int b, int resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Sumar(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }

        [Theory]
        [InlineData(-1, 2, 1)]
        [InlineData(-3, 1, 0)]
        public void Sumar1EnteroNegativo1EnteroPositivo(int a, int b, int resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Sumar(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }
    }

    public class TestDividir
    {

    }
}
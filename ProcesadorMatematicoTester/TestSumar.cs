using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace ProcesadorMatematicoTester
{
    public class TestSumar
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        public void Sumar2ValoresEnterosPositivos(double a, double b, double resultadoEsperado)
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
        public void Sumar2ValoresEnterosNegativos(double a, double b, double resultadoEsperado)
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
        public void Sumar1EnteroNegativo1EnteroPositivo(double a, double b, double resultadoEsperado)
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
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 6, 1.6666666666666667)]
        public void Dividir2EnterosPosivitos(double a, double b, double resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Dividir(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }

        [Theory]
        [InlineData(-4, -2, 2)]
        [InlineData(-10, -2, 5)]
        public void Dividir2EnterosNegativos(double a, double b, double resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Dividir(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }

        [Theory]
        [InlineData(-4, 2, 0)]
        [InlineData(-10, 2, 0)]
        public void Dividir1EnteroNegativo1EnteroPositivo(double a, double b, double resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Dividir(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }
    }
}
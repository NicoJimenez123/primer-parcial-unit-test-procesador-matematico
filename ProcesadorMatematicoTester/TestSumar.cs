using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace ProcesadorMatematicoTester
{
    public class TestSumar
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        public void Sumar2ValoresEnteros(int a, int b, int resultadoEsperado)
        {
            // Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            // Act
            procesadorMatematico.Sumar(a, b);
            // Assert
            Assert.Equal(resultadoEsperado, procesadorMatematico.getResultado());
        }
    }
}
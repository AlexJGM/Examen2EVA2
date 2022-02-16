using Xunit;
using System.Collections.Generic;

namespace Parejas
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.AdmitenDescendencia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {       
            new object[] { new Persona("Fer", 35, 'F') , 
            new Persona("Carlos", 32, 'M'), true},
            new object[] { new Persona("Juan", 70, 'M') , 
            new Persona("Dolores", 35, 'F'), false},
            new object[] { new Persona("Daniela", 31, 'F') , 
            new Persona("Martin", 44, 'M'), false},
            new object[] { new Persona("Martin", 31, 'F') , 
            new Persona("Irene", 34, 'F'), false},
            new object[] { new Persona("Anuel", 43, 'M') , 
            new Persona("Luis", 38, 'M'), false},
     
        };

    }
}
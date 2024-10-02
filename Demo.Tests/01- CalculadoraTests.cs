using System.Runtime.Intrinsics;

namespace Demo.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Calculadora_Somar_RetornarValorSoma()
    {
        //Arrange
        var calculadora = new Calculadora();

        //Act

        var resultado = calculadora.Somar(2, 2);

        //Assert

        Assert.Equal(4,resultado);
    }

    [Theory]
    [InlineData(1,1,2)]
    [InlineData(3, 3, 6)]
    [InlineData(8, 8, 16)]

    public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2,double total)
    {
        //Arrange 

        var calculadora = new Calculadora();

        //Act

        var resultado = calculadora.Somar(v1, v2);

        //Assert

        Assert.Equal(total,resultado);
    }
}

using CalculadoraTDD;

namespace CalculadoraTDDTest;

public class CalculadoraTest
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestarSoma(int num1, int num2, int resultado)
    {
        Calculadora _calc = new Calculadora();

        int resultadoFuncaoSomar = _calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoFuncaoSomar);
    }

    [Theory]
    [InlineData (1, 2, -1)]
    [InlineData (6, 4, 2)]
    public void TestarSubtracao(int num1, int num2, int resultado)
    {
        Calculadora _calc = new Calculadora();

        int resultadoFuncaoSomar = _calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoFuncaoSomar);
    }

    [Theory]
    [InlineData (2, 1, 1)]
    [InlineData (10, 2, 5)]
    public void TestarDividisao(int num1, int num2, int resultado)
    {
        Calculadora _calc = new Calculadora();

        int resultadoFuncaoSomar = _calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoFuncaoSomar);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora _calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Theory]
    [InlineData (5, 5, 25)]
    [InlineData (10, 2, 20)]
    public void TestarMultiplicacao(int num1, int num2, int resultado)
    {
        Calculadora _calc = new Calculadora();

        int resultadoFuncaoSomar = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoFuncaoSomar);
    }

    [Fact]
    public void TestarGeracaoDeHistorico()
    {
        Calculadora _calc = new Calculadora();

        _calc.Somar(1,2);
        _calc.Subtrair(3,2);
        _calc.Dividir(2,1);
        _calc.Multiplicar(4, 2);

        var lista = _calc.GerarHistorico();

        Assert.NotEmpty(_calc.GerarHistorico());
        Assert.Equal(3, lista.Count);
    }

}
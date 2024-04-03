using CalculadoraTDD;

Calculadora calc = new Calculadora();

Console.WriteLine(calc.Somar(2, 2));
Console.WriteLine(calc.Subtrair(2, 2));
Console.WriteLine(calc.Dividir(2, 2));
Console.WriteLine(calc.Multiplicar(2, 2));

foreach(var elemento in calc.GerarHistorico())
{
    Console.WriteLine(elemento);
}
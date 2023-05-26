Console.WriteLine("tabuada do 0");
Console.WriteLine("inicio: ");
int numero =0;
int contador =1;

while (contador <= 10)
{
    int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");
    Thread.Sleep(200);
    contador = contador + 1;
}

Console.WriteLine("fim. ");

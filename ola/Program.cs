double numero1;
double numero2;
Console.WriteLine("digite um numero");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite outro numero");
numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;
double subtração = numero1 - numero2;
double multiplicacao = numero1 * numero2;
double divisao = numero1 / numero2;

Console.WriteLine($"a soma dos numeros é igual a: {soma}");
Console.WriteLine($"a subtração dos numeros é igual a: {subtração}");
Console.WriteLine("a multiplicação dos numeros é igual a: " + multiplicacao);
Console.WriteLine("a divisão dos numeros é igual a: {0}" , divisao);

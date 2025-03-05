// Variáveis para operações
int numero1 = 20;
int numero2 = 5;
double numeroDecimal1 = 10.0;
double numeroDecimal2 = 3.0;

Console.WriteLine("Operadores Aritméticos em C#:");

// Adição
int soma = numero1 + numero2;
Console.WriteLine($"{numero1} + {numero2} = {soma}");

// Subtração
int subtracao = numero1 - numero2;
Console.WriteLine($"{numero1} - {numero2} = {subtracao}");

// Multiplicação
int multiplicacao = numero1 * numero2;
Console.WriteLine($"{numero1} * {numero2} = {multiplicacao}");

// Divisão Inteira e Decimal
int divisaoInteira = numero1 / numero2;
Console.WriteLine($"{numero1} / {numero2} = {divisaoInteira}");

double divisaoDecimal = numeroDecimal1 / numero2;
Console.WriteLine($"{numeroDecimal1} / {numero2} = {divisaoDecimal}");

// Resto da Divisão 
int restoDivisao = numero1 % numero2;
Console.WriteLine($"{numero1} % {numero2} = {restoDivisao}");

int restoDivisao2 = 17 % 5;
Console.WriteLine($"17 % 5 resto da divisao = {restoDivisao2}");

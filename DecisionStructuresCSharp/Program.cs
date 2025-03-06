Console.WriteLine($"Estrutura de Decisão em C# if,else");

// Exemplo 1: if simples

int idade = 25;

if (idade >= 18)
{
    Console.WriteLine($"Voce é maior de idade");
}

Console.WriteLine($"Continuação do programa");

// Exemplo 2: if else

int numero = 7;

if (numero % 2 == 0)
{
    Console.WriteLine($"{numero} é um número par");
}
else
{
    Console.WriteLine($"{numero} é um número ímpar");
}

Console.WriteLine($"Continuação do programa");

// Exemplo3: if else if else

int nota = 85;
string resposta;

if (nota >= 90)
{
    resposta = "A";
}
else if (nota >= 80)
{
    resposta = "B";
}
else if (nota >= 60)
{
    resposta = "C";
}
else if (nota >= 40)
{
    resposta = "D";
}
else
{
    resposta = "Reprovado";
}

Console.WriteLine($"Nota: {nota}, resposta: {resposta}");

// Exemplo 4 if dentro de outro if

int temperatura = 28; 
bool estaChovendo = true;

if (temperatura > 25)
{
    Console.WriteLine($"Esta calor");
    if (!estaChovendo)
    {
        Console.WriteLine($"E não está chovendo, dia bom para sair!");
    }
    else
    {
        Console.WriteLine($"Mas está chovendo");
    }
}
else
{
    Console.WriteLine($"Temperatura amena ou fria");
}

Console.WriteLine($"Continuação do programa");
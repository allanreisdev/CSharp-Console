// Operadores de Atribuição e Incremento/Decremento em C#

// Operadores de Atribuição Compostos

int valor = 10;
Console.WriteLine($"Valor inicial: {valor}");
Console.WriteLine();

valor += 5;
Console.WriteLine($"Valor += 5: {valor}");

valor -= 3;
Console.WriteLine($"Valor -= 3: {valor}");

valor *= 2;
Console.WriteLine($"Valor *= 2: {valor}");

valor /= 4;
Console.WriteLine($"Valor /= 4: {valor}");

valor %= 3;
Console.WriteLine($"Valor %= 3: {valor}");
Console.WriteLine("------------------------------");

// Operadores de Incremento e Decremento

int contador = 10;
Console.WriteLine($"Contador inicial: {contador}");
Console.WriteLine();

contador++;
Console.WriteLine($"contador++ pos incremento: {contador}");

++contador;
Console.WriteLine($"++contador pré-incremento: {contador}");

contador--;
Console.WriteLine($"contador-- pós-decremento: {contador}");

--contador;
Console.WriteLine($"--contador pré-decremento: {contador}");
Console.WriteLine("------------------------------");
// Diferença entre Pré e Pós Incremento

int contador2 = 10;
Console.WriteLine($"Contador inicial:{contador2}");
int resultadoPreIncremento = ++contador2;
Console.WriteLine($"\nPré-incremento:");
Console.WriteLine($"contador2: {contador2}");
Console.WriteLine($"resultadoPreIncremento: {resultadoPreIncremento}");
Console.WriteLine("------------------------------");
int contador3 = 10;
Console.WriteLine($"Contador inicial:{contador3}");

int resultadoPosIncremento = contador3++;
Console.WriteLine($"\nPós-incremento:");
Console.WriteLine($"contador3: {contador3}");
Console.WriteLine($"resultadoPosIncremento: {resultadoPosIncremento}");
Console.WriteLine("------------------------------");
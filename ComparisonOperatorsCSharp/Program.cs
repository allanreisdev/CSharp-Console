Console.WriteLine("Operadores de Comparação em C#");

// Variáveis para comparação

int numero1 = 10;
int numero2 = 5;
double numeroDecimal = 10.0;
string texto1 = "C Sharp";
string texto2 = "C Sharp";
string texto3 = "Java";
bool verdadeiro = true;
bool falso = false;

// Operador Igual a == 

Console.WriteLine($"\nOperador Igual a == ");
Console.WriteLine($"{numero1} == {numero2}: {numero1 == numero2}");
Console.WriteLine($"{numero1} == 10: {numero1 == 10}");
Console.WriteLine($"{texto1} == {texto2}: {texto1 == texto2}");
Console.WriteLine($"{texto1} == {texto3}: {texto1 == texto3}");
Console.WriteLine($"{verdadeiro} == {falso}: {verdadeiro == falso}");
Console.WriteLine($"{verdadeiro} == true: {verdadeiro == true}");

// Operador Diferente de !=

Console.WriteLine($"\nOperador Diferente de !=");
Console.WriteLine($"{numero1} != {numero2}: {numero1 != numero2}");
Console.WriteLine($"{numero1} != 10: {numero1 != 10}");
Console.WriteLine($"{texto1} != {texto2}: {texto1 != texto2}");
Console.WriteLine($"{texto1} != {texto3}: {texto1 != texto3}");
Console.WriteLine($"{verdadeiro} != {falso}: {verdadeiro != falso}");
Console.WriteLine($"{verdadeiro} != true: {verdadeiro != true}");

// Operador Maior que >

Console.WriteLine($"\n Operador Maior que > ");
Console.WriteLine($"{numero1} > {numero2}: {numero1 > numero2}");
Console.WriteLine($"{numero2} > {numero1}: {numero2 > numero1}");
Console.WriteLine($"{numero1} > {numero1}: {numero1 > numero1}");
Console.WriteLine($"{numeroDecimal} > 9.5: {numeroDecimal > 9.5}");

// Operador Menor que <

Console.WriteLine($"\n Operador Menor que <");
Console.WriteLine($"{numero1} < {numero2}: {numero1 < numero2}");
Console.WriteLine($"{numero2} < {numero1}: {numero2 < numero1}");
Console.WriteLine($"{numero1} < {numero1}: {numero1 < numero1}");
Console.WriteLine($"{numeroDecimal} < 10.5: {numeroDecimal < 10.5}");

// Operador Maior ou Igual a >=

Console.WriteLine($"\n Operador Maior ou igual a >=");
Console.WriteLine($"{numero1} >= {numero2}: {numero1 >= numero2}");
Console.WriteLine($"{numero1} >= 10: {numero1 >= 10}");
Console.WriteLine($"{numero2} >= {numero1}: {numero2 >= numero1}");
Console.WriteLine($"{numero2} >= 5: {numero2 >= 5}");

// Operador Menor ou igual a <=

Console.WriteLine($"\n Operador Menor ou igual a <=");
Console.WriteLine($"{numero1} <= {numero2}: {numero1 <= numero2}");
Console.WriteLine($"{numero1} <= 10: {numero1 <= 10}");
Console.WriteLine($"{numero2} <= {numero1}: {numero2 <= numero1}");
Console.WriteLine($"{numero2} <= 5: {numero2 <= 5}");



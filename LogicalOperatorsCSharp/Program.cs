Console.WriteLine($"Operadores Lógicos em c# (&&, ||, !)");

Console.WriteLine($"Operador AND (&&)");

int idade = 20;
bool temCarteira = true;
bool estaChovendo = false;

if (idade >= 18 && temCarteira)
{
    Console.WriteLine($"Pode dirigir!");
}
else
{
    Console.WriteLine($"Não pode dirigir");
}

Console.WriteLine($"Operador OR (||)");

string diaDaSemana = "domingo";

if(diaDaSemana == "sabado" || diaDaSemana == "domingo")
{
    Console.WriteLine($"É fim de semana!");
}
else
{
    Console.WriteLine($"Dia de semana.");
}

Console.WriteLine($"Operador NOT (!)");

bool usuarioLogado = false;

if(!usuarioLogado)
{
    Console.WriteLine($"Usuário não está logado. Por favor, faça login");
}
else
{
    Console.WriteLine($"Bem-vindo, usuário logado!");
}

if(!estaChovendo)
{
    Console.WriteLine($"Não esta chovendo");
}
else
{
    Console.WriteLine($"Esta chovendo");
}

Console.WriteLine($"Condição Complexa");

idade = 16;
bool temAutorizacaoPais = true;
bool diaEnsolarado = false;

if ((idade >= 18 || temAutorizacaoPais) && !diaEnsolarado)
{
    Console.WriteLine($"Pode ir ao parque de diversões com ou sem autorização se maior de idade, mas nao em dia ensolarado");
}
else
{
    Console.WriteLine($"Não pode ir ao parque de diversões");
}

if ((idade >= 16 && temCarteira) || (!estaChovendo && diaDaSemana != "segunda-feira"))
{
    Console.WriteLine($"Condição complexa é VERDADEIRA");
}
else
{
    Console.WriteLine($"Condição complexa é FALSA");
}
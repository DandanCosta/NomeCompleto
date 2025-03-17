string nome;  
string sobrenome;


Console.Write("Digite o primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite o sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");







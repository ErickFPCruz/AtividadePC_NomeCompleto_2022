string nome, sobrenome;

Console.Write("Escreva seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Escreva seu sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine("");
Console.WriteLine($"Nome Completo: {nome} {sobrenome}");

Console.WriteLine($"Nome de Catálogo: {sobrenome.ToUpper()}, {nome}");
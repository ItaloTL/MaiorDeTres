//Atividade Italo T. Lopes
Console.Clear();

int Número1, Número2, Número3;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("=-=-=-= Maior de Três =-=-=-=");
Console.ResetColor();

Console.WriteLine("Digite 3 números para sabermos qual o maior entre eles.");

Console.Write("digite um n° ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("INTEIRO: ");
Console.ResetColor();

//Lógica-->
Número1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite outro n° ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("INTEIRO: ");
Console.ResetColor();
Número3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite mais um n° ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("INTEIRO: ");
Console.ResetColor();
Número2 = Convert.ToInt32(Console.ReadLine());

if (Número1 >= Número2 && Número1 >= Número3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o maior número é: {Número1}");
}

else if (Número2 >= Número1 && Número2 >= Número3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o maior número é: {Número2}");
}
else if (Número3 >= Número1 && Número3 >= Número2)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o maior número é: {Número3}");
}
Console.ResetColor();

Console.WriteLine("Quer tentar novamnete? (^～^)");
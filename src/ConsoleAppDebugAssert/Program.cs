using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 | Melhorias em Debug.Assert *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();
Console.WriteLine("Informe um numero inteiro positivo:");
var input = Console.ReadLine();

Debug.Assert(int.TryParse(input, out var number) && number > 0);

Console.WriteLine();
Console.WriteLine("Debug.Assert() nao produziu falha...");
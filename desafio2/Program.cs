using System;

namespace desafio2
{
class Desafio {
    static void Main() {
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros * 2;
        Console.WriteLine($"{minutos} minutos");
    }
}

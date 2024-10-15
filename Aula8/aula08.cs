using System;

class Aula8{
    public static void Main(string[] args){
        int v1, v2, soma;

        Console.WriteLine("Digite o primeiro valor ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o seegundo valor ");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1+v2;
        Console.WriteLine("A soma de: {0} + {1} = {2}", v1, v2, soma);
     

    }
}
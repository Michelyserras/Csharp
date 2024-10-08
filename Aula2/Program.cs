using System;
internal class Program
// digitando dotnet new console dentro do terminal é criado o arquivo seguindo o padrão dotnet
{
    private static void Main(string[] args){ // args é um array de strings que recebe os argumentos de entrada
        Console.WriteLine("Cfb, cursos!"); // write line ele quebra a linha no final do texto
        if(args.GetLength(0) > 0){
             Console.Write(args.GetValue(0)); // imprime o parametro no args
        } 
    }
}
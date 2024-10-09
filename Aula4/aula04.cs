using System;

class Aula04{
    static int num1 = 10;
    static void Main(string[] args){
        // escopo de variáveis
        int num = 0; // variavel local
        console.log("local" + num);
        Cosole.WriteLine("Global" + num1);
    }

    // void teste(){
    //     Console.WriteLine(Num);
    // }
}
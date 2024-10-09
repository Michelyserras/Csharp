using System;

class Aula05{
    static void Main(string[] args){
        //operadores 

        // atribuição  "="
        //int res = (10 + 5)*2;
        //operadores relacionais retornam verdadeiro ou falso
        // operadores relacionais > < >= <= != ==
        bool res = 10!=5;
        Console.WriteLine(res);

        // operadores de incremento e decremento
        int num = 10;
        num++; // só pode ser usado para incrementar 1
        // é igual a num+1, ou num+=1(pode ser usado para soma, divisão, multiplicação e subtração);

        Console.WriteLine(num);

        //Operadores lógicos
        bool resp = (5>7) && (8>7);
        Console.WriteLine(resp);
    }
}
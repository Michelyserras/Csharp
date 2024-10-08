using System;

class Aula03{
    static void  Main(string[] args){
        // tipo primitivo de dados
        byte n1 = 10; // é uma variavel de 8 bits, que não tem sinal e só recebe valores entre 0 e 255
        int num = 0; // tipo inteiro com sinal, pode receber numeros negativos e tem tamanho de 32 bits de dados;
        char letra = 'c'; //tipo caractere, só armazena uma letra
        float valor =  5.3f;// valores reais

        // tipos referencias
        string nome ="Michely"; // conjunto de caracteres, pode armazenar mais textos
        var aux = 10; // o tipo da variavel não é especificado e seu tipo é definido pela sua atribuição na hora da execução do programa

        Console.WriteLine(nome);


    }
}
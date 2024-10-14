using System;
class Aula6{
    public static void Main(){
      double valorCompra = 5.50;
      double valorVenda;
      double lucro = 0.1;
      string produto = "Pastel";

      valorVenda = valorCompra + (valorCompra*lucro);

      Console.WriteLine("Produto..............:{0,15}", produto);
      Console.WriteLine("Val.Compra...........:{0,15:c}", valorCompra); // imprime de forma de dinheiro adiciona o R$ em frente a variavel
      Console.WriteLine("Lucro................:{0,15:p}", lucro); // imprime em forma de porcentagem
      Console.WriteLine("Val.Venda............:{0,15:c}", valorVenda);
    }
}
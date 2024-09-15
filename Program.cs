 using estagio2.Fibonacci;
 using estagio2.SomaVariavel;
using estagio2.Faturamento;
using estagio2.FaturamentoDistribuidora;
using estagio2.InverterChar;

   Console.WriteLine("1- Fabonacci: exercicio 1");
   Console.WriteLine("2- Soma da variavel: exercicio 2");
   Console.WriteLine("3- Faturamento: exercicio 3");
  Console.WriteLine("4- Faturamento das Distribuidoras: exercicio 4");
  Console.WriteLine("5- Invertendo caracters: exercicio 5");
  
   int opcao = int.Parse(Console.ReadLine());

 switch(opcao) 
 {
  case 1:
  Console.WriteLine("\nSequência de Fibonacci");

    Console.WriteLine("Digite o elemento para ver se pertence a Fabonacci");
      Console.WriteLine("Digite o numero do elemento");
         int n = int.Parse(Console.ReadLine());

          var numero = new Fibonacci();
         numero.Teste(n);
        
        
    break;
  case 2:
    var soma = new SomaVariavel();
       soma.SomaVariaveis();

    break;
      case 3:
      var faturamentoMenor = new Faturamento();
       faturamentoMenor.MenorFaturamento();
       var faturamentoMaior = new Faturamento();
       faturamentoMaior.MaiorFaturamento();
        var faturamentoMedia = new Faturamento();
      faturamentoMedia.MediaFaturamento();
        
         
         break;
             case 4:
              var porcentagem = new FaturamentoDistribuidora();
            porcentagem.PorcentagemPorEstado();
          
         break;
           case 5:
              var inverterLetras = new InverterChar();
             inverterLetras.InveterAsLetras();
          
         break;
      

         
  default:
    // code block
    break;
}

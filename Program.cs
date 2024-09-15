

using vagabackend.Faturamento;
using vagabackend.SomaVariavel;

Console.WriteLine("1- Soma da variavel: exercicio 1");
   Console.WriteLine("3- Faturamento: exercicio 3");

  
   int opcao = int.Parse(Console.ReadLine());

 switch(opcao) 
 {
  case 1:
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
         

         
  default:
    // code block
    break;
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Newtonsoft.Json;




namespace vagabackend.Faturamento
{
    public class Faturamento
    {
        public  Faturamento() {
        }

        public double faturamento;
        public double media;
        public double soma;
        public int i,dias = 0;
      int[] diasFaturamentoMaior = new int[50];
         string conteudo =  File.ReadAllText("3-Faturamento/faturamento.json");
       
          public void MaiorFaturamento(){ 
              List<Valores> listaValores = JsonConvert.DeserializeObject<List<Valores>>(conteudo);

               foreach (Valores z in listaValores)  
             {
                if (z.valor > faturamento)
                {
                    faturamento = z.valor;
                }

                       
             }
                Console.WriteLine("Maior faturamento é: "+ faturamento.ToString("F2"));
           
            }
             public void MenorFaturamento(){  
                 List<Valores> listaValores = JsonConvert.DeserializeObject<List<Valores>>(conteudo);
               foreach (Valores z in listaValores)  
               {
                if (z.valor != 0 || z.valor < faturamento)
                {
                    faturamento = z.valor;
                }

                       
            }
         Console.WriteLine("Menor faturamento é: "+ faturamento.ToString("F2"));
       
      }

         public void MediaFaturamento(){  
          List<Valores> listaValores = JsonConvert.DeserializeObject<List<Valores>>(conteudo);
         foreach (Valores z in listaValores)  
            {
                  i = i+1;
                  if(z.valor > 0)
                  {
                     soma=soma + z.valor;
                                  
                  }
                   
            }
            
            media = soma /i;
          
           foreach (Valores z in listaValores)  
            {
                 if(z.valor > media && z.valor != 0)
                 {
                 dias = dias+1;
                                 
   
                 }
                  
                                                  
            }

         Console.WriteLine("Media faturamento é: "+ media.ToString("F2"));
         Console.WriteLine("Quantidade de dias superior a media mensal: "+ dias);
       
      }


    }}
     
      
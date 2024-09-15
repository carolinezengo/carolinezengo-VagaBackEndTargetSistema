using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio.RaciocinioLogico
{
    public class RaciocinioLogico
    {
         public  RaciocinioLogico (){
        
         }

         public void SomaDosNumerosImparesPor2(){
         
            int indice = 9, soma = 1;
          
           for (int i = 0; i < indice; i++) { 
            
            
            if(i % 2 != 0 )
            {
                 Console.WriteLine(soma);
                soma = i + 2;
                 
            }
          } 
            Console.WriteLine("Proximo numero: "+ soma);
       
      
        
        
        
        }
    
         public void MultNumerosAnteriorPor2(){
         
            int indice = 12, mult = 2;
          
           for (int i = 0; i < indice; i++) { 
            
            
                 if(i % 2 == 0 )
                {
                  Console.WriteLine(mult);
                  mult = mult * 2;
                                 
                 }
            } 
             Console.WriteLine("Proximo numero: " + mult);
        }   
       
         public void SomaNumerosAnteriorPorImapares(){
         
            int indice = 14, soma = 0;
             Console.WriteLine(soma);
        
              for (int i = 0; i < indice; i++) { 

                if(i%2 != 0 )     
                {
                  
                    soma = soma + i;  
                    Console.WriteLine(soma);    
                 }
                 
                 
            } 
             Console.WriteLine("Proximo numero: " + soma);
        }   
         public void  MultNumerosParAoQuadrado(){
         
            int indice = 12;
            double  mult = 0;
            
            for (int i = 2; i < indice; i++) { 

                if(i%2 == 0 )     
                {
                  
                    mult = Math.Pow(i,2); ;  
                    Console.WriteLine(mult);    
                 }
                 
                 
            } 
             Console.WriteLine("Proximo numero: " + mult);
        }  
       
         public void   Fibonacci(){
             int numero = 0, elementoAtual=0, elementoInicio=1, elementoAnterior=0;
              numero = 6;
             Console.WriteLine(elementoInicio);
               for (int i = 0; i < numero; i++)
             {
               elementoAtual = elementoInicio + elementoAnterior;
               Console.WriteLine(elementoAtual);
                elementoAnterior = elementoInicio;
                 elementoInicio = elementoAtual;
                
             }
              Console.WriteLine("Proximo numero: " + elementoAtual);
        }  

          



       
             
           
        
    }
     

    
}
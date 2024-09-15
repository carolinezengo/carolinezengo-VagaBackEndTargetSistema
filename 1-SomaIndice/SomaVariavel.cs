using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio.SomaVariavel
{
    public class SomaVariavel
    {
         public  SomaVariavel (){
        
      }

   public void SomaVariaveis(){
        int indice = 12, soma = 0, k = 1;
       
        while ( k < indice)
        {
                       
             k = k + 1;
            soma = soma + k;
        }
        
                
                Console.WriteLine("Resultado da soma: " + soma);
           
        
        
    }
}}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPartialView.Models
{
    public class GlossarioArquitetura
    {
        private static string[] _Definicoes = new string[] { "Posição 1", "Posição 2", "Posição 3", "Posição 4", "Posição 5" };

        public static string ObterDefinicao() 
        { 
            Random r = new Random(); 
            int posicao = r.Next(0, 5);

            return _Definicoes[posicao]; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Escola.Classe_2
{
    public class Pais
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Nome}");
        

            

            return sb.ToString();
        }
    }
}

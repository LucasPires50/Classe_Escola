using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Escola.Classe_2
{
    public class Pessoa
    {
        public string nome { get; set; }

        public DateTime dataDeNascimento { get; set; }

        public Casa casa { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {nome}");
            sb.AppendLine($"Data de Nasciemtno: {dataDeNascimento}");

            

            return sb.ToString();
        }
    }
}

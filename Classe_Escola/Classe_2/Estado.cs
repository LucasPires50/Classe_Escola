using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Escola.Classe_2
{
    class Estado
    {
        public string Nome { get; set; }

        public Cidade cidade { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estado: {Nome}");
            

           

            return sb.ToString();
        }
    }
}

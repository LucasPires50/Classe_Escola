using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Escola.ObjEscola
{
    public class professor
    {
        public string nome { get; set; }

        public string Materia { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {nome}");
            sb.AppendLine($"Matéria: {Materia}");

            sb.AppendLine("");

            return sb.ToString();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Escola.ObjEscola
{
    public class Aluno_Classe
    {

        public Turma_Classe turma { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string telefone { get; set; }

        public string endereço { get; set; }

        public string nomeDaMãe { get; set; }

        
        public string nomeDoPai { get; set; }

        public DateTime dataNascimento { get; set; }
        public string estado { get; set; }

        public string cidade { get; set; }
        public int idade
        {
            get
            {
                var dataDiferenca = DateTime.Now - dataNascimento;
                return dataNascimento.Day / 365;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {nome}");
            sb.AppendLine($"Mátricula:{matricula}");
            sb.AppendLine($"Telefone: {telefone}");
            sb.AppendLine($"RG:{RG}");
            sb.AppendLine($"CPF:{CPF}");
            sb.AppendLine($"Nome da Mãe:{nomeDaMãe}");
            sb.AppendLine($"Nome do Pai:{nomeDoPai}");
            sb.AppendLine($"Endereço: {endereço}");
            sb.AppendLine($"Estado: {estado}");
            sb.AppendLine($"Cidade: {cidade}");
            sb.AppendLine($"Data de nascismento:{dataNascimento}");
            sb.AppendLine($"Idade: {idade}");
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}

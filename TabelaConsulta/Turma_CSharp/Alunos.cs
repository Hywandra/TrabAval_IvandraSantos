using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma_CSharp
{
    public class Alunos
    {
        int id;
        int numbAluno;
        string nome;
        string telefone;
        string morada;
        DateTime dataNasc;
        double nota;

        //propriedades getter e setter para fazer a manipulação dos atribitos
        public int Id { get { return id; } set { id = value; } }
        public int NumbAluno { get { return numbAluno; } set { numbAluno = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Morada { get { return morada; } set { morada = value; } }
        public DateTime DataNasc { get { return dataNasc; } set { dataNasc = value; } }
        public double Nota { get { return nota; } set { nota = value; } }
    }

   


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Aluno
    {
        public string Nome;
        public string Turma;
        public int Idade;
        public int NMat;
        public decimal Mensalidade;

        public void ExibirAluno()
        {
            Console.WriteLine($"Aluno: {Nome} - Turma: {Turma} - Mensalidade: {Mensalidade:0.00} ");
        }
            //metodo que vai efetuar a troca de turma do aluno requerente

            public void TrocarTurma(string novaTurma) { 
 
                Turma = novaTurma;
            }
        public void Desconto(decimal desconto)
        {
            Mensalidade = Mensalidade - (desconto / 100)*Mensalidade;
        }
            
    }
    }


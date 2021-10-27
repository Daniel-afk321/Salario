using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Funcionario
    {
        //metodos
        public string Nome { get; set; }
        public int ID { get; set; }
        public double Salario{ get; set; }

        //metodo de incrementação de salario
        public void Salarioincrementado(double porcentagem)
        {
            Salario = Salario * porcentagem;
        }
    }
}

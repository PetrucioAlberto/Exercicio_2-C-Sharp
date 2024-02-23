using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    internal class Reserva
    {
        public Pessoa Pessoa { get; set; }
        public Suite Suite { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Reserva(Pessoa pessoa, Suite suite, DateTime dataInicio, DateTime dataFim)
        {
            Pessoa = pessoa;
            Suite = suite;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
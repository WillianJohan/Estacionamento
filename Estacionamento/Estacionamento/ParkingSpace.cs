using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class ParkingSpace
    {
        public Carro carro;
        public DateTime Entrada;

        public ParkingSpace(Carro carro, DateTime entrada)
        {
            this.carro = carro;
            Entrada = entrada;
        }
    }
}

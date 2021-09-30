using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public struct Carro
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }

        public Carro(string placa, string modelo, string cor)
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public interface IFileManager
    {
        protected void CreateFile(string path);
        string LoadFile(string path); //TODO: Criar uma estrutura de parquimetro para tratar o texto e retornar as informações
        void AddCar(string path, Carro carro);
        void RemoveCar(string path, Carro carro);
        
    }
}

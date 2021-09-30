using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class FileManager : IFileManager
    {
        void IFileManager.CreateFile(string path) => File.Create(path);

        public string LoadFile(string path)
        {
            throw new NotImplementedException();
        }

        public void AddCar(string path, Carro carro)
        {
            Stream output = File.Open(path, FileMode.Append);
            //StreamWriter writer = new StreamWriter(output);
            //foreach (int item in unsorted) writer.WriteLine(item);
            //writer.Close();
            output.Close();
        }

        public void RemoveCar(string path, Carro carro)
        {
            throw new NotImplementedException();
        }
        
    }
}
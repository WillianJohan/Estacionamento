using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Estacionamento
{
    public class FileManager
    {
        string Path;

        public FileManager() => Path = @"c:\Estacionamento\Parking.json";
        public FileManager(string Path) => this.Path = Path;




        void CreateFile() => File.Create(Path);

        public Parking LoadFile()
        {
            //If Empty
            if (!File.Exists(Path))
                return new Parking();
            try
            {
                string jsonText = File.ReadAllText(Path);
                return JsonSerializer.Deserialize<Parking>(jsonText);
            }
            catch
            {
                return new Parking();
            }
        }

        public void Save(Parking parking)
        {
            //if (!File.Exists(Path))
            //    CreateFile();

            string jsonString = JsonSerializer.Serialize(parking);
            File.WriteAllText(Path, jsonString);
        }
        
    }
}
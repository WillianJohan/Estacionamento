using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Parking
    {
        public List<ParkingSpace> Vagas;

        public Parking(List<ParkingSpace> Vagas)
        {
            this.Vagas = Vagas;
        }

        public Parking()
        {
            this.Vagas = new List<ParkingSpace>();
        }
    }
}

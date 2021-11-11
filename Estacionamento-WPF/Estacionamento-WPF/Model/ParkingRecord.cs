using SQLite;
using System;

namespace Estacionamento_WPF.Model
{
    [Table("ParkingRecord")]
    public class ParkingRecord
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [NotNull, MaxLength(8)]
        public string Plate { get; set; }

        public string Model { get; set; }

        public DateTime EntryTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}

using SQLite;

namespace Estacionamento_WPF.Model
{
    [Table("Vehicles")]
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        [NotNull, MaxLength(8)] 
        public string LicensePlate { get; set; }
        
        public string Model { get; set; }
        public string Color { get; set; }
    }
}

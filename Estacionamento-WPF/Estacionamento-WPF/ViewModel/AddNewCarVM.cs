using Estacionamento_WPF.Model;
using System.Windows;

namespace Estacionamento_WPF.ViewModel
{
    public class AddNewCarVM : ViewModelBase
    {
        public Commands.AddNewCarCommand AddCommand { get; private set; }

        #region Propertyes

        string plate;
        public string Plate
        {
            get => plate;
            set
            {
                plate = value;
                OnPropertyChanged(nameof(Plate));
            }
        }

        string model;
        public string Model
        {
            get => model;
            set
            {
                model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        #endregion

        public AddNewCarVM()
            => AddCommand = new Commands.AddNewCarCommand(this);

        public void Save()
        {
            ParkingRecord newRecord = new ParkingRecord();
            newRecord.Plate = Plate;
            newRecord.Model = Model;
            newRecord.EntryTime = System.DateTime.Now;

            bool operationSucess = Database.ParkingOperations.Insert(newRecord, out string insertMessage);
            MessageBox.Show(insertMessage);

            if (operationSucess) //Se for ok, fecha a janela
                View.UpdateParkingRecordWindow.Instance.Close();
                
        }
    }
}

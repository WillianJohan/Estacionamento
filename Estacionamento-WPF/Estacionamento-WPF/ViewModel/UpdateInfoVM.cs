using Estacionamento_WPF.Model;
using System.Windows;

namespace Estacionamento_WPF.ViewModel
{
    public class UpdateInfoVM : ViewModelBase
    {
        public static ParkingRecord ItemToUpdate {get;set;}

        public Commands.UpdateInfoCommand UpdateCommand { get; private set; }

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

        public UpdateInfoVM()
        {
            UpdateCommand = new Commands.UpdateInfoCommand(this);
            if(!ItemToUpdate.CanSaveInDatabase())
            {
                MessageBox.Show("Houve algum problema ao carregar as informações!");
                View.UpdateParkingRecordWindow.Instance.Close();
            }

            Model = ItemToUpdate.Model;
            Plate = ItemToUpdate.Plate;
        }

        public void Save()
        {
            ParkingRecord updatedPR = ItemToUpdate;
            updatedPR.Model = model;
            updatedPR.Plate = plate;


            bool operationSucess = Database.ParkingOperations.Update(ItemToUpdate, updatedPR);


            if (operationSucess) //Se for ok, fecha a janela
                View.UpdateParkingRecordWindow.Instance.Close();
            else
                MessageBox.Show("Não foi possivel salvar! Consulte o administrador do sistema.");
        }
    }
}

using Estacionamento_WPF.Model;
using Estacionamento_WPF.View;
using Estacionamento_WPF.ViewModel.Commands;
using System.Windows;

namespace Estacionamento_WPF.ViewModel
{
    public class UpdateInfoVM : ViewModelBase
    {
        public static ParkingRecord ItemToUpdate {get;set;}

        public UpdateInfoCommand UpdateCommand { get; private set; }

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
            UpdateCommand = new UpdateInfoCommand(this);
            if (ItemToUpdate == null || !ItemToUpdate.CanSaveInDatabase())
                MessageBox.Show("Houve algum problema ao carregar as informações!");
            else
            {
                Model = ItemToUpdate.Model;
                Plate = ItemToUpdate.Plate;
            }
        }

        public void Save()
        {
            ParkingRecord updatedPR = ItemToUpdate;
            updatedPR.Model = model;
            updatedPR.Plate = plate;


            bool operationSucess = Database.ParkingOperations.Update(ItemToUpdate, updatedPR);


            if (operationSucess) //Se for ok, fecha a janela
                UpdateParkingRecordWindow.Instance.Close();
            else
                MessageBox.Show("Não foi possivel salvar! Consulte o administrador do sistema.");
        }
    }
}

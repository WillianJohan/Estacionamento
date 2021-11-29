using Estacionamento_WPF.Model;
using System.Windows;

namespace Estacionamento_WPF.ViewModel
{
    public class UpdateInfoVM : ViewModelBase
    {
        public static ParkingRecord ItemToUpdate {get;set;}

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

        public UpdateInfoVM()
        {
            if(!ItemToUpdate.CanSaveInDatabase())
            {
                MessageBox.Show("Informações Nulas");
                View.UpdateParkingRecordWindow.Instance.Close();
            }
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
            {
                MessageBox.Show("Não foi possivel salvar");
            }


        }

    }
}

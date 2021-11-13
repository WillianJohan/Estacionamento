using Estacionamento_WPF.Model;
using Estacionamento_WPF.View;
using Estacionamento_WPF.ViewModel.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Estacionamento_WPF.ViewModel
{
    

    public class MainWindowVM : ViewModelBase
    {
        public OpenNewCarWindowCommand openNewCarWindowCommand { get; set; }
        public OpenUpdateParkingRecordWindowCommand openUpdateParkingRecordWindowCommand { get; set; }
        public RemoveParkingRecordItemCommand removeParkingRecordItemCommand { get; set; }

        #region Propriedades

        ParkingRecord selectedItem;
        public ParkingRecord SelectedItem 
        { 
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        ObservableCollection<ParkingRecord> parkingRecordList;
        public ObservableCollection<ParkingRecord> ParkingRecordList 
        { 
            get => parkingRecordList;
            set
            {
                parkingRecordList = value;
                OnPropertyChanged(nameof(ParkingRecordList));
            }
        }

        #endregion

        public MainWindowVM()
        {
            openUpdateParkingRecordWindowCommand = new OpenUpdateParkingRecordWindowCommand(this);
            openNewCarWindowCommand = new OpenNewCarWindowCommand(this);
            removeParkingRecordItemCommand = new RemoveParkingRecordItemCommand(this);
            UpdateParkingRecordList();
        }

        #region Command Methods

        public void OpenWindowCommand_AddNewCar()
        {
            //Abre uma nova janela com uma interface de adição de carro
            new AddNewCarWindow().ShowDialog();
            UpdateParkingRecordList(); //Atualiza a lista
        }

        public void OpenWindow_UpdateParkingRecordItem()
        {
            //Abre uma nova janela com uma interface de atualizar os dados de um registro
            new UpdateParkingRecordWindow().ShowDialog();
            UpdateParkingRecordList(); //Atualiza a lista
        }

        public void RemoveParkingItemRecord()
        {
            if (SelectedItem == null)
                return;

            Database.ParkingOperations.Remove(selectedItem.ID);
            UpdateParkingRecordList();
        }

        #endregion

        //Lê do banco de dados e atualiza a lista de carros do estacionamento
        public void UpdateParkingRecordList()
        {
            List<ParkingRecord> list = Database.ParkingOperations.Read();
            foreach (ParkingRecord item in list)
                ParkingRecordList.Add(item);
        }
    }
}

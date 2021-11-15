using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_WPF.ViewModel.Commands.MainWindow
{
    public class RemoveParkingRecordItemCommand : CommandBase
    {

        public MainWindowVM MyViewModel;

        public RemoveParkingRecordItemCommand(MainWindowVM MyViewModel)
            => this.MyViewModel = MyViewModel;

        public override void Execute(object parameter)
        {
            MyViewModel.RemoveParkingItemRecord();
        }
    }
    public class OpenNewCarWindowCommand : CommandBase
    {
        public MainWindowVM MyViewModel;

        public OpenNewCarWindowCommand(MainWindowVM MyViewModel)
            => this.MyViewModel = MyViewModel;

        public override void Execute(object parameter)
        {
            MyViewModel.OpenWindowCommand_AddNewCar();
        }
    }

    public class OpenUpdateParkingRecordWindowCommand : CommandBase
    {
        public MainWindowVM MyViewModel;

        public OpenUpdateParkingRecordWindowCommand(MainWindowVM MyViewModel)
            => this.MyViewModel = MyViewModel;

        public override void Execute(object parameter)
        {
            MyViewModel.OpenWindow_UpdateParkingRecordItem();
        }
    }
}

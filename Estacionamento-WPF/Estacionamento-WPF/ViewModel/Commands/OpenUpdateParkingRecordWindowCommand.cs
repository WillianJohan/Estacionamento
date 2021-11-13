using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_WPF.ViewModel.Commands
{
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

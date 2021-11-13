using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_WPF.ViewModel.Commands
{
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
}

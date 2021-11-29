using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_WPF.ViewModel.Commands
{
    public class UpdateInfoCommand : CommandBase
    {
        UpdateInfoVM vm;

        public UpdateInfoCommand(UpdateInfoVM vm) => this.vm = vm;

        public override bool CanExecute(object parameter)
        {
            return string.IsNullOrEmpty(vm.Plate);
        }

        public override void Execute(object parameter)
        {
            vm.Save();
        }
    }
}

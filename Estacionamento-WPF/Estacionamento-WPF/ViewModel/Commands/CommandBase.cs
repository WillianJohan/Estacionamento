using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Estacionamento_WPF.ViewModel.Commands
{
    public abstract class CommandBase : ICommand
    {
        public abstract void Execute(object parameter);
        public virtual bool CanExecute(object parameter) => true;


        public event EventHandler CanExecuteChanged;
        protected void OnCanExecuteChanged(object sender, PropertyChangedEventArgs e)
            => CanExecuteChanged?.Invoke(this, new EventArgs());
    }
}

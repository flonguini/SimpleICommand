using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleICommand.ViewModel.Commands
{
    public class HelloCommand : ICommand
    {
        public ViewModelBase ViewModelBase { get; set; }

        public HelloCommand(ViewModelBase viewModelBase)
        {
            ViewModelBase = viewModelBase;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModelBase.SayHello();
        }
    }
}

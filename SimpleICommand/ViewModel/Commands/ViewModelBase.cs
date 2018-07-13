using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleICommand.ViewModel.Commands
{
    public class ViewModelBase
    {
        public Commands.HelloCommand HelloCommand { get; set; }

        public ViewModelBase()
        {
            this.HelloCommand = new Commands.HelloCommand(this);
        }

        public void SayHello()
        {
            MessageBox.Show("Hello World.");
        }
    }
}

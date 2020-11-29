using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarWashBillingSystem.Model
{
    public class MainWindowModel 
    {
        #region ICommand
        public class CommandHandler : ICommand
        {
            private Action _action;
            //private Func<bool> _canExec;

           // public CommandHandler(Action action, Func<bool> canEx)
            public CommandHandler(Action action)

            {
                _action = action;
               // _canExec = canEx;
            }
            public event EventHandler CanExecuteChanged;
           // {
                //add { CommandManager.RequerySuggested += value; }
                //remove { CommandManager.RequerySuggested -= value; ; }
            //}
            public bool CanExecute(object param)
            {
                // return _canExec.Invoke();
                return true;
            }
            public void Execute(object param)
            {
                _action();
            }

        }
        #endregion

    }
}











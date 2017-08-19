using System;
using System.Windows.Input;

namespace MVVMXamarinSkeleton.Utility.RelayCommand
{
    public class RelayCommand : ICommand
    {
        #region Properties and Fields

        private Action _Action = null;

        private bool _CanBeExecuted = false;
        public bool CanBeExecuted
        {
            get
            {
                return _CanBeExecuted;
            }
            set
            {
                if (_CanBeExecuted != value)
                {
                    _CanBeExecuted = value;

                    RaiseCanExecuteChanged();
                }
            }
        }

        #endregion

        #region Constructor

        public RelayCommand(Action action, bool canBeExecuted = true)
        {
            _Action = action;
            CanBeExecuted = canBeExecuted;
        }

        #endregion

        #region Methods

        public bool CanExecute(object parameter = null)
        {
            return CanBeExecuted;
        }

        public void Execute(object parameter = null)
        {
            _Action();
        }

        private void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #endregion

        #region Events

        public event EventHandler CanExecuteChanged = delegate { };

        #endregion
    }
}

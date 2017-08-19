using System;
using MVVMXamarinSkeleton.Utility.RelayCommand;

namespace MVVMXamarinSkeleton.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Properties and Fields

        private static readonly Lazy<MainViewModel> _Instance = new Lazy<MainViewModel>(() => new MainViewModel()); 

        public static MainViewModel Instance
        {
            get
            {
                return _Instance.Value;
            }
        }

        private string _LabelText = "This text is changed by pressing the button";
        public string LabelText
        {
            get
            {
                return _LabelText;
            }
            set
            {
                SetField(ref _LabelText, value);
            }
        }

        public RelayCommand SetTextCommand
        {
            get;
            private set;
        }

        #endregion

        #region Constructor

        private MainViewModel() : base()
        {
            SetTextCommand = new RelayCommand(ExecuteSetTextCommand);
        }

        #endregion

        #region Command Execution

        public void ExecuteSetTextCommand()
        {
            LabelText = "This text is changed";
            SetTextCommand.CanBeExecuted = false;
        }

        #endregion
    }
}

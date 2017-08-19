using MVVMXamarinSkeleton.ViewModels;
using Xamarin.Forms;

namespace MVVMXamarinSkeleton.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = MainViewModel.Instance;
        }
    }
}

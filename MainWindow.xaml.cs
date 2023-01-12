using ReactiveUI;
using RxSamples.Samples.StepInterval;
using System.Windows;

namespace RxSamples
{
    public partial class MainWindow : Window, IViewFor<MainViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            this.WhenActivated(disposable =>
            {
                
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StepIntervalView frm = new();
            frm.Show();
        }

        #region ViewModel Properties
        public MainViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (MainViewModel)value;
        }
        MainViewModel IViewFor<MainViewModel>.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value;
        }
        #endregion
    }
}

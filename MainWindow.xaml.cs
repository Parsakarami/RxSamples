using RxSamples.Samples.StepInterval;
using System.Windows;

namespace RxSamples
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StepIntervalView frm = new();
            frm.Show();
        }
    }
}

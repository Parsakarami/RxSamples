using ReactiveUI;
using System.Reactive.Disposables;
using System.Windows;

namespace RxSamples.Samples.StepInterval
{
    public partial class StepIntervalView : Window, IViewFor<StepIntervalViewModel>
    {
        public StepIntervalView()
        {
            InitializeComponent();
            ViewModel = new StepIntervalViewModel();
            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel,
                    vm => vm.Count,
                    v => v.ValueLabel.Content)
                .DisposeWith(disposable);
            });
        }

        #region ViewModel Properties
        public StepIntervalViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (StepIntervalViewModel)value;
        }
        StepIntervalViewModel IViewFor<StepIntervalViewModel>.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value;
        }
        #endregion
    }
}

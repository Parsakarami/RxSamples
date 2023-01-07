using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Linq;
using System;

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
                ViewModel.NotificationChannel
                .Buffer(3)
                .StepInterval(TimeSpan.FromSeconds(1))
                .Take(3)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(batches =>
                {
                    var values = string.Join(", ", batches);
                    var receiveTime = DateTime.Now.TimeOfDay;
                    ValueLabel.Content += $"Values: [{values}]  -  Receive time: {receiveTime} {Environment.NewLine}";
                }).DisposeWith(disposable);
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

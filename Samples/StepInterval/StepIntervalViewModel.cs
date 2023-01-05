using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxSamples.Samples.StepInterval
{
    public class StepIntervalViewModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; set; } = new ViewModelActivator();
        [Reactive]
        public int Count { get; set; } = 0;
        public StepIntervalViewModel()
        {
            this.WhenActivated(disposable =>
            {
                Observable
                .Interval(TimeSpan.FromMilliseconds(250),RxApp.MainThreadScheduler)
                .Subscribe(_ =>
                {
                    Count++;
                }).DisposeWith(disposable);
            });
        }
    }
}

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
        public Subject<int> NotificationChannel { get; set; } = new Subject<int>();
        private int count;
        public StepIntervalViewModel()
        {
            this.WhenActivated(disposable =>
            {
                Observable
                .Interval(TimeSpan.FromMilliseconds(100))
                .Subscribe(_ =>
                {
                    count++;
                    NotificationChannel.OnNext(count);
                }).DisposeWith(disposable);
            });
        }
    }

    public static class RxExtentionsMethods
    {
        public static IObservable<T> StepInterval<T>(this IObservable<T> source, TimeSpan minDelay)
        {
            return source.Select(x =>
                Observable.Empty<T>()
                    .Delay(minDelay)
                    .StartWith(x)
            ).Concat();
        }
    }
}

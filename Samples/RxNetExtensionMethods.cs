using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxSamples.Samples
{
    public static class RxNetExtensionMethods
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

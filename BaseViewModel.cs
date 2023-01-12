using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxSamples
{
    public abstract class BaseViewModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; set; } = new ViewModelActivator();
    }
}

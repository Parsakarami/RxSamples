using ReactiveUI;

namespace RxSamples
{
    public class MainViewModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; set; } = new ViewModelActivator();
    }
}

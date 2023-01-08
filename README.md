# RxSamples

Here, we will talk about reactive programming in C# and .NET framework using the Rx.NET library. Reactive programming is widely in use in desktop and mobile applications nowadays.

## ReactiveUI
<img src="https://d33wubrfki0l68.cloudfront.net/72e8947e9c05a3cf563175010522012406424e8a/efa88/assets/img/logo.png"/>

For this sample, I used ReactiveUI to implement MVVM in the project. However, the ReactiveUI gives us a model-view-ViewModel framework for all .NET platforms. I chose a WPF application to implement the samples. For more information about the ReactiveUI and how to implement the MVVM, you can check the following links:

https://www.reactiveui.net/ <br/>
https://github.com/reactiveui/reactiveui

## Observables
In all the samples, we widely use Observables. If you are not familiar with the observer design pattern, visit the following links: 

https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern <br/>
https://learn.microsoft.com/en-us/dotnet/api/system.iobservable-1?view=net-7.0 <br/>
https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-7.0 <br/>

## Marble Diagram

The best way to show the execution pipeline of the observables sequence is using marble diagrams. Hence, I use it in this repo and my blog as well. In the following figure, execution of the observables sequence is represented by a marble diagram.
<img src="Marble Diagrams/MarbleDiagram - Explanation.jpg" width="550">
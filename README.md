Collectio
=========

Register services in ASP.NET's dependency injection container using attributes.


Usage
-----

Register service with one of the existing lifetimes in the service collection:
```
[Singleton(typeof(IInterfaceOfClassToRegister))]
[Transient(typeof(IAnotherInterfaceOfClassToRegister))]
[Scoped(typeof(IYetAnotherInterfaceOfClassToRegister))]
public class ClassToRegister : IInterfaceOfClassToRegister, IAnotherInterfaceOfClassToRegister, IYetAnotherInterfaceOfClassToRegister
{
    [...]
}

// similar to:
// services.AddSingleton(IInterfaceOfClassToRegister, ClassToRegister)
// services.AddTransient(IAnotherInterfaceOfClassToRegister, ClassToRegister)
// services.AddScoped(IYetAnotherInterfaceOfClassToRegister, ClassToRegister)
```

Register ASP.NET background service in the service collection:
```
[HostedService]
public class CustomBackgroundService : BackgroundService
{
    [...]
}

// similar to:
// services.AddHostedService(CustomBackgroundService)
```

Register typed http client in the service collection:
```
[HttpClient(typeof(IInterfaceOfClientToRegister))]
public class ServiceClient : IInterfaceOfClientToRegister
{
    [...]
}

// similar to:
// services.AddHttpClient(IInterfaceOfClientToRegister, ServiceClient)
```

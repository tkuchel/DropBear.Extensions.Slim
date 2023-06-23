# Slim 

Slim Extension is a .NET library that provides an easy-to-use object slimming extension. 

## Features 

- Squeeze classes into slimmer versions
- Supports multiple types
  
## Installation 

You can add Slim to your project by using the NuGet package manager in Visual Studio, or by using the `dotnet add package` command in the .NET CLI: 

```bash 
dotnet add package DropBear.Extensions.Slim
``` 

## Usage 

First, register the Slim services in your `Startup.cs` file: 

```csharp 
public void ConfigureServices(IServiceCollection services) 
{ 
    // Other service configuration... 

    services.AddSlimExtension(); 
} 
``` 

Then, you can inject and use `ISlim` in your classes: 

```csharp 
public class MyClass 
{ 

} 
``` 

## Documentation 

For more detailed documentation, please see the official documentation. 

## Contributing 

We welcome contributions! Please see our contributing guide for details. 

## License 

MenuManager is licensed under the MIT License. 
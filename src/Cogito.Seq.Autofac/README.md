# Cogito.Seq.Autofac

Registers the Seq options in an Autofac container.

## Install

```shell
dotnet add package Cogito.Seq.Autofac
```

## Use

```csharp
builder.RegisterAllAssemblyModules();
```

`SeqOptions` is bound from configuration and available to anything that needs the Seq server URL or
API key.

## License

MIT.

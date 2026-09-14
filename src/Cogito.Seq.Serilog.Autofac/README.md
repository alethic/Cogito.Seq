# Cogito.Seq.Serilog.Autofac

Adds the Seq sink to the Serilog logger built by the container.

## Install

```shell
dotnet add package Cogito.Seq.Serilog.Autofac
```

## Use

```csharp
builder.RegisterAllAssemblyModules();
```

The Seq sink is contributed to the container's logger, configured from `SeqOptions`. Nothing else to
wire: configure the server URL and logs ship there.

## License

MIT.

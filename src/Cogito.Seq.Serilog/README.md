# Cogito.Seq.Serilog

A Serilog Seq sink configured from `SeqOptions`.

## Why

So that turning Seq on, pointing it at a different server, or rotating its API key is a configuration
change rather than an edit to the logger setup.

## Install

```shell
dotnet add package Cogito.Seq.Serilog
```

## Use

`SeqLoggerConfigurator` is an `ILoggerConfigurator` (see `Cogito.Serilog`), so it contributes the Seq
sink to the logger being built, using the configured server URL and API key. If no server URL is
configured the sink is not added, which makes Seq optional per environment without a code path for it.

## License

MIT.

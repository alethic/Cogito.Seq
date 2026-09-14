# Cogito.Seq

Configuration for shipping logs to [Seq](https://datalust.co/seq).

## Why

The Seq server URL and API key are deployment settings, not code. This holds them as bindable options
so they come from configuration like everything else, and the packages below pick them up.

## Install

```shell
dotnet add package Cogito.Seq
```

## Use

Bind `SeqOptions` from configuration:

```json
{
  "Seq": {
    "ServerUrl": "https://seq.internal",
    "ApiKey": "..."
  }
}
```

## See also

- `Cogito.Seq.Serilog` — a Serilog sink configured from these options.
- `Cogito.Seq.Autofac` / `Cogito.Seq.Serilog.Autofac` — the same, registered in an Autofac container.

## License

MIT.

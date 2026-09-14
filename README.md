# Cogito.Seq

[![Build](https://github.com/alethic/Cogito.Seq/actions/workflows/Cogito.Seq.yml/badge.svg)](https://github.com/alethic/Cogito.Seq/actions/workflows/Cogito.Seq.yml)

Ships logs to Seq, configured from your application's configuration.

## Packages

**[Cogito.Seq](https://www.nuget.org/packages/Cogito.Seq)** — Configuration for shipping logs to [Seq](https://datalust.co/seq).

**[Cogito.Seq.Autofac](https://www.nuget.org/packages/Cogito.Seq.Autofac)** — Registers the Seq options in an Autofac container.

**[Cogito.Seq.Serilog](https://www.nuget.org/packages/Cogito.Seq.Serilog)** — A Serilog Seq sink configured from `SeqOptions`.

**[Cogito.Seq.Serilog.Autofac](https://www.nuget.org/packages/Cogito.Seq.Serilog.Autofac)** — Adds the Seq sink to the Serilog logger built by the container.

Each package carries its own README with the detail; the links above go to nuget.org.

## Building

```shell
dotnet restore Cogito.Seq.slnx
dotnet msbuild -p:Configuration=Release Cogito.Seq.dist.msbuildproj
```

Packages are staged into `dist/nuget` and test suites into `dist/tests`; run a suite with
`dotnet test -f <tfm> <path to its assembly>`.

## License

MIT — see [LICENSE](LICENSE).

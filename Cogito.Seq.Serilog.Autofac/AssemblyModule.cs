using Autofac;

using Cogito.Autofac;
using Cogito.Serilog;

namespace Cogito.Seq.Serilog.Autofac
{

    public class AssemblyModule : ModuleBase
    {

        /// <summary>
        /// Invoked to load the module.
        /// </summary>
        /// <param name="builder"></param>
        protected override void Register(ContainerBuilder builder)
        {
            builder.RegisterFromAttributes(typeof(AssemblyModule).Assembly);
            builder.RegisterType<SeqLoggerConfigurator>().As<ILoggerConfigurator>();
        }

    }

}

using Autofac;

using Cogito.Autofac;
using Cogito.Extensions.Options.Configuration.Autofac;

namespace Cogito.Seq.Autofac
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
            builder.Configure<SeqOptions>("Seq");
        }

    }

}

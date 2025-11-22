using Autofac;

namespace StoreApp.Services.Identity.Application.DependencyResolvers.Autofac;

public class AutofacDependencyModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        // Validation Registrations
        builder.RegisterAssemblyTypes(ThisAssembly)
            .Where(t => t.Name.EndsWith("Validator"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
    }
}

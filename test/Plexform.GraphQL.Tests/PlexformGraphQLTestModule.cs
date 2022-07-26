using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Plexform.Configure;
using Plexform.Startup;
using Plexform.Test.Base;

namespace Plexform.GraphQL.Tests
{
    [DependsOn(
        typeof(PlexformGraphQLModule),
        typeof(PlexformTestBaseModule))]
    public class PlexformGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlexformGraphQLTestModule).GetAssembly());
        }
    }
}
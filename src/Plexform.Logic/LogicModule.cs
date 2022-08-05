using System;
using System.IO;
using Abp.AspNetCore.Configuration;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Plexform.Configuration;
using Plexform.Web.Authentication.TwoFactor;
using Plexform.Web.Configuration;

namespace Plexform.Web
{
    [DependsOn(
		typeof(ANEO.Base.P2P.P2PModule),
        typeof(LIMS.Base.LIMSModule)
		//typeof(Plexform.Base.Clobid.ClobidModule),
		//typeof(Plexform.Base.CrossmarQ.CrossmarQModule),
        //typeof(Plexform.Base.Inventory.BaseInventoryModule),
       // typeof(Plexform.Base.Accounting.BaseAccountingModule)
    )]
    public class LogicModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LogicModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            //Set default connection string
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PlexformConsts.ConnectionStringName
            );

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(PlexformApplicationModule).GetAssembly()
                );

            Configuration.Caching.Configure(TwoFactorCodeCacheItem.CacheName, cache =>
            {
                cache.DefaultAbsoluteExpireTime = TimeSpan.FromMinutes(2);
            });

            Configuration.ReplaceService<IAppConfigurationAccessor, AppConfigurationAccessor>();

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LogicModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            SetAppFolders();
        }

        private void SetAppFolders()
        {
            var appFolders = IocManager.Resolve<AppFolders>();

            appFolders.SampleProfileImagesFolder = Path.Combine(_env.WebRootPath, $"Common{Path.DirectorySeparatorChar}Images{Path.DirectorySeparatorChar}SampleProfilePics");
            appFolders.WebLogsFolder = Path.Combine(_env.ContentRootPath, $"App_Data{Path.DirectorySeparatorChar}Logs");

#if NET461
            if (_env.IsDevelopment())
            {
                var currentAssemblyDirectoryPath = typeof(LogicModule).GetAssembly().GetDirectoryPathOrNull();
                if (currentAssemblyDirectoryPath != null)
                {
                    appFolders.WebLogsFolder = Path.Combine(currentAssemblyDirectoryPath, $"App_Data{Path.DirectorySeparatorChar}Logs");
                }
            }
#endif
        }
    }
}

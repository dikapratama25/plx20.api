using System;
using System.Linq;
using System.Transactions;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Uow;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using Plexform.EntityFrameworkCore;
using Plexform.Migrations.Seed.Host;
using Plexform.Migrations.Seed.Tenants;

namespace Plexform.Migrations.Seed
{
    public static class SeedHelper
    {
        public static void SeedHostDb(IIocResolver iocResolver)
        {
            WithDbContext<PlexformDbContext>(iocResolver, SeedHostDb);
        }

        public static void SeedHostDb(PlexformDbContext context)
        {
            context.SuppressAutoSetTenantId = true;

            //Host seed
            new InitialHostDbBuilder(context).Create();

            //Default tenant seed (in host database).
            new DefaultTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, 1).Create();

            //Tenant Role & Permissions Seed, uncoment to seed new role & permission
            //var tenants = context.Tenants.ToList();
            //foreach (var tenant in tenants)
            //{
            //    new TenantRoleAndUserBuilder(context, tenant.Id).Create();
            //}
        }

        private static void WithDbContext<TDbContext>(IIocResolver iocResolver, Action<TDbContext> contextAction)
            where TDbContext : DbContext
        {
            using (var uowManager = iocResolver.ResolveAsDisposable<IUnitOfWorkManager>())
            {
                using (var uow = uowManager.Object.Begin(TransactionScopeOption.Suppress))
                {
                    var context = uowManager.Object.Current.GetDbContext<TDbContext>(MultiTenancySides.Host);

                    contextAction(context);

                    uow.Complete();
                }
            }
        }
    }
}

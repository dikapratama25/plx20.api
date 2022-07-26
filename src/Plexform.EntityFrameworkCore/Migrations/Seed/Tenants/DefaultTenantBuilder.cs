using System.Linq;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using Plexform.Editions;
using Plexform.EntityFrameworkCore;

namespace Plexform.Migrations.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly PlexformDbContext _context;

        public DefaultTenantBuilder(PlexformDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant
            var _free = "Free";
            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == _free || t.Id == 1);
            if (defaultTenant == null)
            {
                defaultTenant = new MultiTenancy.Tenant(_free, _free);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}

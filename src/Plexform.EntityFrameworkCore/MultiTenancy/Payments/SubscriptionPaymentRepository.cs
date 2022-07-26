using System.Linq;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using Plexform.EntityFrameworkCore;
using Plexform.EntityFrameworkCore.Repositories;

namespace Plexform.MultiTenancy.Payments
{
    public class SubscriptionPaymentRepository : PlexformRepositoryBase<SubscriptionPayment, long>, ISubscriptionPaymentRepository
    {
        public SubscriptionPaymentRepository(IDbContextProvider<PlexformDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<SubscriptionPayment> GetByGatewayAndPaymentIdAsync(SubscriptionPaymentGatewayType gateway, string paymentId)
        {
            return await SingleAsync(p => p.ExternalPaymentId == paymentId && p.Gateway == gateway);
        }

        public async Task<SubscriptionPayment> GetLastCompletedPaymentOrDefaultAsync(int tenantId, SubscriptionPaymentGatewayType? gateway, bool? isRecurring, int? appId = null)
        {
            return (await GetAll()
                    .Where(p => p.TenantId == tenantId)
                    .Where(p => p.Status == SubscriptionPaymentStatus.Completed)
                    .WhereIf(appId.HasValue, p => p.Edition.AppId == appId.Value)
                    .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                    .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                    .ToListAsync()
                    )
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();
        }

        public async Task<SubscriptionPayment> GetLastCompletedPaymentOrDefaultAsync(int tenantId, int? editionId, SubscriptionPaymentGatewayType? gateway, bool? isRecurring, int? appId = null)
        {
            return (await GetAll()
                    .Where(p => p.TenantId == tenantId)
                    .Where(p => p.Status == SubscriptionPaymentStatus.Completed)
                    .WhereIf(appId.HasValue, p => p.Edition.AppId == appId.Value)
                    .WhereIf(editionId.HasValue, p => p.EditionId == editionId.Value)
                    .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                    .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                    .ToListAsync()
                    )
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();
        }

        public async Task<SubscriptionPayment> GetLastPaymentOrDefaultAsync(int tenantId, SubscriptionPaymentGatewayType? gateway, bool? isRecurring, int? appId = null)
        {
            return (await GetAll()
                    .Where(p => p.TenantId == tenantId)
                    .WhereIf(appId.HasValue, p => p.Edition.AppId == appId.Value)
                    .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                    .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                    .ToListAsync()
                    )
                   .OrderByDescending(x => x.Id)
                   .FirstOrDefault();
        }

        public async Task<SubscriptionPayment> GetLastPaymentOrDefaultAsync(int tenantId, int? editionId, SubscriptionPaymentGatewayType? gateway, bool? isRecurring, int? appId = null)
        {
            return (await GetAll()
                    .Where(p => p.TenantId == tenantId)
                    .WhereIf(appId.HasValue, p => p.Edition.AppId == appId.Value)
                    .WhereIf(editionId.HasValue, p => p.EditionId == editionId.Value)
                    .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                    .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                    .ToListAsync()
                    )
                   .OrderByDescending(x => x.Id)
                   .FirstOrDefault();
        }
    }
}

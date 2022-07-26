using System;
using System.Linq;
using Abp.Organizations;
using Plexform.Authorization.Roles;
using Plexform.MultiTenancy;
using System.Collections.Generic;

namespace Plexform.EntityHistory
{
    public static class EntityHistoryHelper
    {
        private static readonly Type[] HostTrace =
        {
            #region ABP
            typeof(Tenant)
            #endregion
        };

        private static readonly Type[] GeneralTrace =
        {
            #region ABP
            typeof(OrganizationUnit), 
            typeof(Role),
            #endregion
        };

        public const string EntityHistoryConfigurationName = "EntityHistory";

        public static readonly Type[] HostSideTrackedTypes =
                HostTrace
                .Concat(GeneralTrace)
                .GroupBy(type => type.FullName)
                .Select(types => types.First())
                .ToArray();

        public static readonly Type[] TenantSideTrackedTypes = GeneralTrace;

        public static readonly Type[] TrackedTypes =
            HostSideTrackedTypes
                .Concat(TenantSideTrackedTypes)
                .GroupBy(type => type.FullName)
                .Select(types => types.First())
                .ToArray();
    }
}

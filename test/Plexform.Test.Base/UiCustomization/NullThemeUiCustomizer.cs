﻿using System.Threading.Tasks;
using Abp;
using Plexform.Configuration.Dto;
using Plexform.UiCustomization;
using Plexform.UiCustomization.Dto;

namespace Plexform.Test.Base.UiCustomization
{
    public class NullThemeUiCustomizer : IUiCustomizer
    {
        public Task<UiCustomizationSettingsDto> GetUiSettings()
        {
            return Task.FromResult(new UiCustomizationSettingsDto());
        }

        public Task UpdateUserUiManagementSettingsAsync(UserIdentifier user, ThemeSettingsDto settings)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTenantUiManagementSettingsAsync(int tenantId, ThemeSettingsDto settings)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateApplicationUiManagementSettingsAsync(ThemeSettingsDto settings)
        {
            throw new System.NotImplementedException();
        }

        public Task<ThemeSettingsDto> GetHostUiManagementSettings()
        {
            throw new System.NotImplementedException();
        }

        public Task<ThemeSettingsDto> GetTenantUiCustomizationSettings(int tenantId)
        {
            throw new System.NotImplementedException();
        }
    }
}
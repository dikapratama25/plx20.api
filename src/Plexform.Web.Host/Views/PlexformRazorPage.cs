using Abp.AspNetCore.Mvc.Views;

namespace Plexform.Web.Views
{
    public abstract class PlexformRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PlexformRazorPage()
        {
            LocalizationSourceName = PlexformConsts.LocalizationSourceName;
        }
    }
}

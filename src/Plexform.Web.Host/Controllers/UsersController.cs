using Abp.AspNetCore.Mvc.Authorization;
using Plexform.Authorization;
using Plexform.Storage;
using Abp.BackgroundJobs;

namespace Plexform.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}
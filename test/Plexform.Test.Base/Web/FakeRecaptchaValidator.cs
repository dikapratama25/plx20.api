using System.Threading.Tasks;
using Plexform.Security.Recaptcha;

namespace Plexform.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}

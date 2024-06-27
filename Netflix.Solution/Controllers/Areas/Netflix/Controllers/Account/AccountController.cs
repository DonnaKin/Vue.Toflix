using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Netflix.Solution.Controllers.Areas.Netflix.Models.Account;
using Netflix.Solution.Controllers.Areas.Netflix.Models.Common;
using Netflix.Solution.Controllers.Areas.Netflix.Services.Account;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Netflix.Solution.Controllers.Areas.Netflix.Controllers.Account
{
    [Area("netflix")]
    [Route("netflix/api/[controller]")]
    [Authorize]
    public class AccountController(ILoginService _loginService) : Controller
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<CommonResponse<AuthInfo>> Login([FromBody] LoginParameter loginParameter)
        {
            CommonResponse<AuthInfo> result = _loginService.Login(loginParameter);

            if (result.ErrorCode == "0000")
            {
                var claims = new List<Claim>
                {
                    new (ClaimTypes.Sid, result.Data.Uid),
                    new (ClaimTypes.DateOfBirth, result.Data.Birth),
                };

                var identity = new ClaimsIdentity(claims, "Login");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
            }

            return result;
        }
    }
}

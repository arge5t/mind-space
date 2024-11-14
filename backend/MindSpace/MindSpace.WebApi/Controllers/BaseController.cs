using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace MindSpace.WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public abstract class BaseController: ControllerBase
{
    internal Guid UserId
    {
        get
        {
            Debug.Assert(User.Identity != null, "User.Identity != null");
            return !User.Identity.IsAuthenticated
                ? Guid.Empty
                : Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value);
        }
    }
}
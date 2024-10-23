using System.Security.Claims;

namespace InstaFakeDetector.Services.Contracts.Identity;

public interface ISecurityTrimmingService
{
    bool CanCurrentUserAccess(string area, string controller, string action);
    bool CanUserAccess(ClaimsPrincipal user, string area, string controller, string action);
}
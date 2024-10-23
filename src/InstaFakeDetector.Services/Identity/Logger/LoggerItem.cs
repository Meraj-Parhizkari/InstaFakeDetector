using InstaFakeDetector.Entities.AuditableEntity;
using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.Services.Identity.Logger;

public class LoggerItem
{
    public AppShadowProperties Props { set; get; }
    public AppLogItem AppLogItem { set; get; }
}
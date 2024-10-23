using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.ViewModels.Identity.Emails;

public class UserProfileUpdateNotificationViewModel : EmailsBase
{
    public User User { set; get; }
}
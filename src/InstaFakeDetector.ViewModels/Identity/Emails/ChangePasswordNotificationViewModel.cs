using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.ViewModels.Identity.Emails;

public class ChangePasswordNotificationViewModel : EmailsBase
{
    public User User { set; get; }
}
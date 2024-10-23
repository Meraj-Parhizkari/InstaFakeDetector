using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.ViewModels.Identity;

public class TodayBirthDaysViewModel
{
    public List<User> Users { set; get; }

    public AgeStatViewModel AgeStat { set; get; }
}
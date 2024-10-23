using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.Services.Contracts.Identity;

public interface IUsedPasswordsService
{
    Task<bool> IsPreviouslyUsedPasswordAsync(User user, string newPassword);
    Task AddToUsedPasswordsListAsync(User user);
    Task<bool> IsLastUserPasswordTooOldAsync(int userId);
    Task<DateTime?> GetLastUserPasswordChangeDateAsync(int userId);
}
﻿using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.Services.Contracts.Identity;

public interface IUsersPhotoService
{
    string GetUsersAvatarsFolderPath();
    void SetUserDefaultPhoto(User user);
    string GetUserDefaultPhoto(string photoFileName);
    string GetUserPhotoUrl(string photoFileName);
    string GetCurrentUserPhotoUrl();
}
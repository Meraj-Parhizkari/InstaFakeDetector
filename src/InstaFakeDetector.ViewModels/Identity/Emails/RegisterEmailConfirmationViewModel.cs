﻿using InstaFakeDetector.Entities.Identity;

namespace InstaFakeDetector.ViewModels.Identity.Emails;

public class RegisterEmailConfirmationViewModel : EmailsBase
{
    public User User { set; get; }
    public string EmailConfirmationToken { set; get; }
}
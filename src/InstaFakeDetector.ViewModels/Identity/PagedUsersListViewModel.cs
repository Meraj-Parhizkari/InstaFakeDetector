﻿using InstaFakeDetector.Entities.Identity;
using cloudscribe.Web.Pagination;

namespace InstaFakeDetector.ViewModels.Identity;

public class PagedUsersListViewModel
{
    public PagedUsersListViewModel()
    {
        Paging = new PaginationSettings();
    }

    public List<User> Users { get; set; }

    public List<Role> Roles { get; set; }

    public PaginationSettings Paging { get; set; }
}
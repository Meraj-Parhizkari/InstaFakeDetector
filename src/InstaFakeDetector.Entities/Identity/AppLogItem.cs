﻿using InstaFakeDetector.Entities.AuditableEntity;

namespace InstaFakeDetector.Entities.Identity;

public class AppLogItem : IAuditableEntity
{
    public int Id { set; get; }

    public DateTime? CreatedDateTime { get; set; }

    public int EventId { get; set; }

    public string Url { get; set; }

    public string LogLevel { get; set; }

    public string Logger { get; set; }

    public string Message { get; set; }

    public string StateJson { get; set; }
}
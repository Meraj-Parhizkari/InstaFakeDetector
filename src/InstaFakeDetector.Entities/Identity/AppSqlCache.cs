﻿namespace InstaFakeDetector.Entities.Identity;

/// <summary>
///     For Microsoft.Extensions.Caching.SqlServer
///     More info: http://www.dntips.ir/post/2577
///     and http://www.dntips.ir/post/2578
///     plus http://www.dntips.ir/post/2581
/// </summary>
public class AppSqlCache
{
    public string Id { get; set; }
    public byte[] Value { get; set; }
    public DateTimeOffset ExpiresAtTime { get; set; }
    public long? SlidingExpirationInSeconds { get; set; }
    public DateTimeOffset? AbsoluteExpiration { get; set; }
}
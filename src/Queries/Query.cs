using System.Security.Cryptography;

/*
 * Query.cs
 *
 *   Created: 2023-10-01-11:36:53
 *   Modified: 2023-10-01-11:36:53
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Queries;

public record struct Query<TId, TDto> : IQuery<TId, TDto>
    where TId : IComparable, IEquatable<TId>
    where TDto : IIdentifiable<TId>
{
    public Query(IEnumerable<TId> ids, int pageNumber = 1, int pageSize = int.MaxValue)
        : this(_ => ids.Contains(_.Id), pageNumber, pageSize) { }

    public Query(TId id)
        : this(_ => id.Equals(_.Id), 1, 1) { }

    public Query(
        Expression<Func<TDto, bool>>? predicate = null,
        int pageNumber = 1,
        int pageSize = int.MaxValue
    )
    {
        Predicate = predicate ?? Predicate;
        PageNumber = pageNumber;
        PageSize = pageSize;
    }

    public int PageSize { get; } = 1;
    public int PageNumber { get; } = int.MaxValue;

    public Expression<Func<TDto, bool>>? Predicate { get; } = _ => true;
}

public record struct Query<TDto> : IQuery<TDto>
{
    public Query(
        Expression<Func<TDto, bool>> predicate,
        int pageNumber = 1,
        int pageSize = int.MaxValue
    )
    {
        Predicate = predicate;
        PageNumber = pageNumber;
        PageSize = pageSize;
    }

    public int PageSize { get; } = 1;
    public int PageNumber { get; } = int.MaxValue;

    public Expression<Func<TDto, bool>>? Predicate { get; } = _ => true;
}

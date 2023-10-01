/*
 * Create.cs
 *
 *   Created: 2022-12-21-09:48:41
 *   Modified: 2022-12-21-10:11:46
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Dgmjr.MediatR.Queries;

public record struct Query<TDto> : IQuery<TDto>
{
    public Query() { }

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

    public Expression<Func<TDto, bool>>? Predicate { get; } = _ => true;
    public int PageSize { get; } = int.MaxValue;
    public int PageNumber { get; } = 1;
}

public record struct Query<TId, TDto> : IQuery<TId, TDto>
    where TId : IComparable, IEquatable<TId>
    where TDto : IIdentifiable<TId>
{
    public Query() { }

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

    public Query(TId id)
        : this(_ => _.Id.Equals(id), 1, 1) { }

    public Expression<Func<TDto, bool>>? Predicate { get; } = _ => true;
    public int PageSize { get; } = int.MaxValue;
    public int PageNumber { get; } = 1;
}

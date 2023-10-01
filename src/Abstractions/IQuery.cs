/*
 * IQuery.cs
 *
 *   Created: 2022-12-21-10:07:40
 *   Modified: 2022-12-21-10:08:05
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Linq.Expressions;
using Dgmjr.Abstractions;

namespace Dgmjr.MediatR.Abstractions;

public interface IQuery<TId, TDto> : IQueryBase<TDto>, IRequest<TDto>
    where TId : IComparable, IEquatable<TId> { }

public interface IQuery<TDto> : IQueryBase<TDto>, IRequest<IEnumerable<TDto>>
{
    int PageSize { get; }
    int PageNumber { get; }
}

public interface IQueryBase<TDto>
{
    Expression<Func<TDto, bool>>? Predicate { get; }
}

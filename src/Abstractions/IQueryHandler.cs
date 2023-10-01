/*
 * IQueryHandler.cs
 *
 *   Created: 2022-12-21-10:49:58
 *   Modified: 2022-12-21-10:49:58
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Abstractions;
using Dgmjr.MediatR.Abstractions;

namespace Dgmjr.MediatR.Handlers.Abstractions;

public interface IQueryHandler<TQuery, TId, TModel, TDto> : IRequestHandler<TQuery, TDto>
    where TQuery : IQuery<TId, TDto>
    where TId : IComparable, IEquatable<TId>
    where TDto : IIdentifiable<TId>
    where TModel : IIdentifiable<TId> { }

public interface IQueryHandler<TQuery, TDto> : IRequestHandler<TQuery, IEnumerable<TDto>>
    where TQuery : IQuery<TDto> { }

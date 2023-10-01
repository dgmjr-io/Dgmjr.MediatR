/*
 * IUpdateHandler.cs
 *
 *   Created: 2022-12-21-10:45:59
 *   Modified: 2022-12-21-10:46:10
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Handlers.Abstractions;

public interface IUpdateHandler<TUpdateCommand, TId, TModel, TUpdateDto, TDto>
    : IRequestHandler<TUpdateCommand, TDto>
    where TUpdateCommand : IUpdateCommand<TModel, TId, TUpdateDto, TDto>
    where TModel : class, IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId> { }

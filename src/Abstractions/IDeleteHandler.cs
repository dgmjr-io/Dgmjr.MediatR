/*
 * IDeleteHandler.cs
 *
 *   Created: 2022-12-21-11:45:44
 *   Modified: 2022-12-21-11:45:58
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.MediatR.Abstractions;

namespace Dgmjr.MediatR.Handlers.Abstractions;

public interface IDeleteHandler<TDeleteCommand, TId, TDto> : IDeleteHandler<TDeleteCommand, TId>
    where TId : IComparable, IEquatable<TId>
    where TDeleteCommand : IDeleteCommand<TId, TDto> { }

public interface IDeleteHandler<TDeleteCommand, TId> : IRequestHandler<TDeleteCommand, Unit>
    where TId : IComparable, IEquatable<TId>
    where TDeleteCommand : IDeleteCommand<TId> { }

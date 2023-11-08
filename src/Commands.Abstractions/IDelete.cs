/*
 * DeleteCommand.cs
 *
 *   Created: 2022-12-21-10:01:23
 *   Modified: 2022-12-21-10:02:34
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Commands.Abstractions;

public interface IDeleteCommand<TId, TDto> : IDeleteCommand<TId>
    where TId : IComparable, IEquatable<TId>
{

    TDto Dto { get; }
}

public interface IDeleteCommand<TId> : ICommand<Unit>
    where TId : IComparable, IEquatable<TId>
{
    TId Id { get; }
}

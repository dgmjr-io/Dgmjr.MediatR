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

namespace Dgmjr.MediatR.Commands;

public record struct DeleteCommand<TId, TDto>(TDto Dto, TId Id) : IDeleteCommand<TId, TDto>
    where TId : IComparable, IEquatable<TId>
{
    // public DeleteCommand(TDto dto, TId id)
    // {
    //     Dto = dto;
    //     Id = id;
    // }

    public TDto Dto { get; } = Dto;
public TId Id { get; } = Id;
}

public record struct DeleteCommand<TId>(TId Id) : IDeleteCommand<TId>
    where TId : IComparable, IEquatable<TId>
{
    // public DeleteCommand(TId id)
    // {
    //     Id = id;
    // }

    public TId Id { get; } = Id;
}

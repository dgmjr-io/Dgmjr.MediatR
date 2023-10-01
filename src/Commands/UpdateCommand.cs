/*
 * IUpdateCommand.cs
 *
 *   Created: 2022-12-21-10:01:45
 *   Modified: 2022-12-21-10:02:43
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Commands;

using Dgmjr.Abstractions;

public record struct UpdateCommand<TModel, TId, TUpdateDto, TDto>(TUpdateDto Update)
    : IUpdateCommand<TModel, TId, TUpdateDto, TDto>
    where TModel : class, IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId>
{
    // public UpdateCommand(TUpdateDto updateDto)
    // {
    //     Update = updateDto;
    // }

    public TUpdateDto Update { get; init; } = Update;
}

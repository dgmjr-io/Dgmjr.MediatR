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

namespace Dgmjr.MediatR.Commands;

public record struct  CreateCommand<TId, TCreateDto, TDto>(TCreateDto Create) : ICreateCommand<TId, TCreateDto, TDto>
    where TId : IComparable, IEquatable<TId>
{
    // public CreateCommand() { }
    // public CreateCommand(TCreateDto createDto) => Create = createDto;
    public TCreateDto Create { get; init; } = Create;
}
